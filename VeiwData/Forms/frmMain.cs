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
        public short[] DataIntended { get; set; }
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

        private void Clear()
        {
            wfgAllData.Plots[0].PlotY(0);
            wfgChartIntended.Plots[0].PlotY(0);
            access = false;
            tvFileName.Nodes.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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

                tvFileName.Nodes.Add(Result.Item3.ToString());
                tvFileName.Nodes[0].Nodes.Add($"Size : {Result.Item2.ToString("#,0")}kb");
                lblLengthData.Text = Result.Item2.ToString("#,0");
                
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
            lblCurser.Text = e.X.ToString();
            
            wfgAllData.Plots[0].InverseMapDataPoint(wfgAllData.PlotAreaBounds, p, out xData, out yData);
            wfgAllData.Cursors[0].XPosition = xData;

            xData = (int)(Math.Abs(xData));
        }

        private void wfgAllData_PlotAreaMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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

        private void btnMenuTreeView_Click(object sender, EventArgs e)
        {
            if (tvFileName.Visible)
            {
                tvFileName.Visible = false;
            }
            else
            {
                tvFileName.Visible = true;
            }
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Close The Window ?","Exit!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DataPoint()
        {

            if (DisplayRange != 1)
            {
                IndexSpace = DisplayRange == 2 ? WithScreen * 0.5 : WithScreen * 0.1;
                var start = (int)xData - ((int)IndexSpace / 2);
                var end = (int)xData + ((int)IndexSpace / 2);
                lblRangeData.Text = $"{start} - {end}";
                DataIntended = Da.GetData(false, start, (long)IndexSpace, end);
            }

            setchart.DrawingIntendedData(DataIntended, DisplayRange);

        }
    }
}
