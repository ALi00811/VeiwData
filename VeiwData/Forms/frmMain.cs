using NationalInstruments.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using VeiwData.Classes;


namespace VeiwData
{
    public partial class frmMain : Form
    {
        Dataloading Da;
        SetChart setchart;
        public int DisplayRange { get; set; }
        public bool access = false;
        public double IndexSpace { get; set; }
        double xData, yData = 0;
        public int WithScreen { get; set; }
        public short[] DataIntended{ get; set; }
        Point p;

        public frmMain()
        {
            InitializeComponent();
            DisplayRange = 2;
            var resolotion = new Resolotion();
            WithScreen = resolotion.Width;
        
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
                Da = new Dataloading(Result.Item1, WithScreen, Result.Item2);
                setchart = new SetChart(Da.GetData(true));

                lblNameFile.Text = Result.Item1.ToString();
                lblSizeData.Text = Result.Item1.Length.ToString("#,0");
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
                    GetX(e);
                    DataPoint();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GetX(System.Windows.Forms.MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);

            wfgAllData.Plots[0].InverseMapDataPoint(wfgAllData.PlotAreaBounds, p, out xData, out yData);
            wfgAllData.Cursors[0].XPosition = xData;

            xData = (int)(Math.Abs(xData));
        }

        private void wfgChartIntended_PlotAreaMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                int a = e.Location.X;
                
            }
        }

        private void DataPoint()
        {

            if (DisplayRange != 1)
            {
                IndexSpace = DisplayRange == 2 ? WithScreen * 0.5 : WithScreen * 0.1;
                DataIntended = Da.GetData(false,(int)xData - ((int)IndexSpace / 2), (long)IndexSpace, (int)xData + ((int)IndexSpace / 2));
            }

            setchart.DrawingIntendedData(DataIntended, DisplayRange);

        }
    }
}
