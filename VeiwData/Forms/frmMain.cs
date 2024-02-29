using System;
using System.Drawing;
using System.Windows.Forms;
using VeiwData.Classes;
using System.Windows.Input;


namespace VeiwData
{
    public partial class frmMain : Form
    {
        Dataloading Da;
        SetChart setchart;
        Resolotion resolotion;
        public int DisplayRange { get; set; }
        public bool access = false;
        public double IndexSpace { get; set; }
        double xData, yData = 0;

        public frmMain()
        {
            InitializeComponent();
            DisplayRange = 2;
            resolotion = new Resolotion();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenOfd();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSizeData.Text = "0M";
            lblNameFile.Text = "FileName";
            wfgAllData.Plots.Clear();
            wfgChartIntended.Plots.Clear();
        }

        private void btnMenuOpenFile_Click(object sender, EventArgs e)
        {
            OpenOfd();
        }

        private void OpenOfd()
        {
            var Result = OpenFile.Open();
            if (access)
            {
                Da = new Dataloading(Result, resolotion);
                setchart = new SetChart(Da.GetAllData(),Result);

                lblNameFile.Text = Result.OpenFileDialog.FileName;
                lblSizeData.Text = Result.FileStream.Length.ToString("#,0");
            }
        }

        private void rdFull_CheckedChanged(object sender, EventArgs e)
        {
            DisplayRange = 1;
        }

        private void rdHalf_CheckedChanged(object sender, EventArgs e)
        {
            DisplayRange = 2;
        }

        private void rdless_CheckedChanged(object sender, EventArgs e)
        {
            DisplayRange = 3;
        }


        private void wfgAllData_PlotAreaMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (access)
            {
                try
                {
                    Point p = new Point(e.X, e.Y);

                    wfgAllData.Plots[0].InverseMapDataPoint(wfgAllData.PlotAreaBounds, p, out xData, out yData);
                    wfgAllData.Cursors[0].XPosition = xData;

                    xData = (int)(Math.Abs(xData));

                    if (DisplayRange != 1) { IndexSpace = DisplayRange == 2 ? resolotion.Width * 0.5 : resolotion.Width * 0.1; }
                    setchart.DrawingIntendedData(xData, (int)IndexSpace, DisplayRange);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
