using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using VeiwData.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace VeiwData
{
    public partial class frmMain : Form
    {
        Dataloading Da;
        SetChart setchart;
        public int DisplayRange { get; set; }
        public bool Access { get; set; }
        public double IndexSpace { get; set; }
        double xData, yData = 0;
        public int WithScreen { get; set; }
        public short[] DataIntended { get; set; }
        Point p;
        public int maximumValueScroll { get; set; }
        public int ValueScroll { get; set; }

        public ScroolBar scrollBar;

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

        public void Clear()
        {
            wfgAllData.Plots[0].PlotY(0);
            wfgChartIntended.Plots[0].PlotY(0);
            Access = false;
            tvFileName.Nodes.Clear();
            sbChart.Maximum = 0;
            sbChart.Value = 0;
            sbChart.LargeChange = 0;
            sbChart.Visible = false;
            ValueScroll = 0;
            ValueScroll = 0;
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
            if (!Access) Clear();
            Access = true;
            if (Access)
            {
                maximumValueScroll = (int)Result.Item2;
                Da = new Dataloading(Result.Item1, WithScreen, Result.Item2);
                setchart = new SetChart(Da.GetData(true));

                tvFileName.Nodes.Add(Result.Item3.ToString());
                tvFileName.Nodes[0].Nodes.Add($"Size : {Result.Item2.ToString("#,0")}kb");
                lblLengthData.Text = Result.Item2.ToString("#,0");
                tvFileName.Nodes[0].Nodes.Add(Result.Item1.Position.ToString());
                tvFileName.Nodes[0].Nodes.Add(Result.Item1.SafeFileHandle.ToString());
                tvFileName.ExpandAll();

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
            if (Access)
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
            if (Access)
            {
                try
                {
                    GetX(e);
                    DataPoint();
                    ValueScroll = e.X;

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
            if (MessageBox.Show("Close The Window ?", "Exit!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void sbChart_ValueChanged(object sender, EventArgs e)
        {
            xData = sbChart.Value;
            DataPoint();
        }
        
        private void DataPoint()
        {

            if (DisplayRange != 1)
            {
                IndexSpace = DisplayRange == 2 ? WithScreen * 0.5 : WithScreen * 0.1;
                var start = (int)xData - ((int)IndexSpace / 2);
                var end = (int)xData + ((int)IndexSpace / 2);
                start = start <= 0 ? 0 : start;
                lblRangeData.Text = $"{start} - {end}";
                DataIntended = Da.GetData(false, start, (long)IndexSpace, end);                
            }
            setchart.DrawingIntendedData(DataIntended, DisplayRange);

        }
    }
}
