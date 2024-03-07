using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VeiwData.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace VeiwData
{
    public partial class frmMain : Form
    {
        Dataloading Da;
        SetChart setchart;
        List<double> ValuesZoom = new List<double>() { 2.5, 5, 7.5, 10, 20, 30, 50, 70, 100 };
        SetIndexRange SIR = new SetIndexRange();
        public ScroolBar scrollBar;
        Point p;
        public int DisplayRange { get; set; }
        public bool Access { get; set; }
        public double IndexSpace { get; set; }
        double xData, yData = 0;
        public int WithScreen { get; set; }
        public short[] DataIntended { get; set; }
        public int maximumValueScroll { get; set; }
        public int ValueScroll { get; set; }
        public double ValueZoom { get; set; }
        public int SelectIndexZoom { get; set; }
        
        
        public frmMain()
        {
            InitializeComponent();
            DisplayRange = 2;
            var resolotion = new Resolotion();
            WithScreen = resolotion.Width;
            cbZoom.SelectedIndex = 6;
            ValueZoom = ValuesZoom[cbZoom.SelectedIndex];
            SelectIndexZoom = cbZoom.SelectedIndex;
            IndexSpace = SIR.GetIndexRange(ValueZoom, WithScreen);
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
            sbChart.Visible = false;
            tvFileName.Nodes.Clear();
            sbChart.Maximum = 0;
            sbChart.Value = 0;
            sbChart.LargeChange = 0;
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

                lblLengthData.Text = Result.Item2.ToString("#,0");

                tvFileName.Nodes.Add(Result.Item3.ToString());
                tvFileName.Nodes[0].Nodes.Add($"Size : {Result.Item2.ToString("#,0")}kb");
                tvFileName.Nodes[0].Nodes.Add(Result.Item1.Position.ToString());
                tvFileName.Nodes[0].Nodes.Add(Result.Item1.SafeFileHandle.ToString());
                
                tvFileName.ExpandAll();
            }
        }
        private void wfgAllData_PlotAreaMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Access)
            {
                try
                {
                    GetX(wfgAllData, e);
                    DataPoint();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GetX(WaveformGraph wfa, System.Windows.Forms.MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
            lblCurser.Text = e.X.ToString();

            wfa.Plots[0].InverseMapDataPoint(wfa.PlotAreaBounds, p, out xData, out yData);
            xData = (int)(Math.Abs(xData));
        }

        private void wfgAllData_PlotAreaMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (Access)
            {
                try
                {
                    GetX(wfgAllData, e);
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
            if (MessageBox.Show("Close The Window ?", "Exit!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Application.Exit();
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

        private void cbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Access)
            {
                ValueZoom = ValuesZoom[cbZoom.SelectedIndex];
                SelectIndexZoom = cbZoom.SelectedIndex;

                IndexSpace = SIR.GetIndexRange(ValueZoom, WithScreen);
                DataPoint();
            }
        }

        private void DataPoint()
        {

            if (SelectIndexZoom != 8)
            {
                var start = (int)xData - ((int)IndexSpace / 2);
                var end = (int)xData + ((int)IndexSpace / 2);

                start = start <= 0 ? 0 : start;

                lblRangeData.Text = $"{start} - {end}";
                lblIndex.Text = xData.ToString();

                //wfgChartIntended.XAxes[0].Range = new Range(start,end);
                DataIntended = Da.GetData(false, start, (long)IndexSpace, end);
            }
            setchart.DrawingIntendedData(DataIntended, SelectIndexZoom, WithScreen * 2);
        }
    }
}
