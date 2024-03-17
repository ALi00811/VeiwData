using NationalInstruments.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VeiwData.Classes;


namespace VeiwData
{
    public partial class frmMain : Form
    {
        #region Property
        public int DisplayRange { get; set; }
        public long Step { get; set; }
        public bool isAccess { get; set; } = false;
        public double IndexSpace { get; set; }
        double xData, yData = 0;
        public int WithScreen { get; set; }
        public ClassDatas DataIntended { get; set; }
        public int MaximumValueScroll { get; set; }
        public int ValueScroll { get; set; }
        public double ValueZoom { get; set; }
        public int SelectIndexZoom { get; set; }
        public int Start { get; private set; } = 0;
        public int End { get; private set; }
        private int Length { get; set; }

        #endregion

        #region Model
        Tuple<FileStream, long, string> Result;
        Dataloading DL;
        SetChart setchart;
        List<double> ValuesZoom = new List<double>() { 2.5, 5, 7.5, 10, 20, 30, 50, 70, 100 };
        SetIndexRange SIR = new SetIndexRange();
        public ScroolBar scrollBar;
        Point p;
        DataTable dt;

        #endregion

        public frmMain()
        {
            InitializeComponent();
            DisplayRange = 2;
            var resolotion = new Resolotion();
            WithScreen = resolotion.Width * 2;
            cbZoom.SelectedIndex = 8;
            ValueZoom = ValuesZoom[cbZoom.SelectedIndex];
            SelectIndexZoom = cbZoom.SelectedIndex;

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenOfd();
        }

        public void Clear()
        {
            sgAllData.Plots[0].ClearData();
            sgIntendedData.Plots[0].ClearData();
            isAccess = false;
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
            Result = OpenFile.Open();
            if (!isAccess) Clear();
            if (isAccess)
            {
                IndexSpace = SIR.GetIndexRange(ValueZoom, Step);
                MaximumValueScroll = (int)Result.Item2;
                DL = new Dataloading(Result.Item1);
                Step = Result.Item2 / (WithScreen * 2);

                var item = DL.GetData(0, Step, WithScreen * 2);
                setchart = new SetChart(item.ItemX, item.ItemY);

                lblLengthData.Text = Result.Item2.ToString("#,0");

                tvFileName.Nodes.Add(Result.Item3.ToString());
                tvFileName.Nodes[0].Nodes.Add($"Size : {Result.Item2.ToString("#,0")}kb");
                tvFileName.Nodes[0].Nodes.Add(Result.Item1.Position.ToString());
                tvFileName.Nodes[0].Nodes.Add(Result.Item1.SafeFileHandle.ToString());

                End = (int)Result.Item2;
                Length = End;

                tvFileName.ExpandAll();
                SourceDataGride();

            }
        }

        private void GetX(System.Windows.Forms.MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
            lblCurser.Text = e.X.ToString();

            sgAllData.Plots[0].InverseMapDataPoint(sgAllData.PlotAreaBounds, p, out xData, out yData);
            xData = (int)(Math.Abs(xData));
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
            if (isAccess)
            {
                ValueZoom = ValuesZoom[cbZoom.SelectedIndex];
                SelectIndexZoom = cbZoom.SelectedIndex;

                IndexSpace = SIR.GetIndexRange(ValueZoom, Step);
                //DataPoint();
            }
        }

        private void sgAllData_PlotAreaMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (isAccess)
            {
                try
                {
                    GetX(e);
                    DataPoint();
                    ValueScroll = e.X;
                    lblSelector.Text = xData.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void DataPoint()
        {
            if (SelectIndexZoom != 8)
            {
                Start = (int)xData;
                End = (int)IndexSpace;
                Start = Start <= 0 ? 0 : Start;

                DataIntended = DL.GetData(Start, End, WithScreen * 2);
                RangePlot();
            }
            
        }

        private void SourceDataGride()
        {
            dt = new DataTable();
            dt.Columns.Add("Begin", typeof(int));
            dt.Columns.Add("End", typeof(int));
            dt.Columns.Add("LengthFile", typeof(string));
            dt.Rows.Add(Start, Start + SIR.GetIndexRange(ValueZoom, Start), Result.Item2.ToString());

            dgSelectSample.DataSource = dt;
            dgSelectSample.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.Dispose();
        }

        private void RangePlot()
        {
            switch (ValueZoom)
            {
                case 2.5:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom,Start));
                    break;
                case 5:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom, Start));
                    break;
                case 7.5:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom,Start));
                    break;
                case 10:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom,Start));
                    break;
                case 20:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom,Start));
                    break;
                case 30:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom,Start));
                    break;
                case 50:
                    sgIntendedData.Plots[0].XAxis.Range = new Range(Start, SetRange(ValueZoom,Start));
                    break;
                case 70:
                    break;
                default:
                    break;
            }
        }

        private void btnMenuFFT_Click(object sender, EventArgs e)
        {
            if (gbFFT.Visible)
            {
                gbFFT.Visible = false;
            }
            else
            {
                gbFFT.Visible = true;
            }
        }

        private void btnMenuSelect_Click(object sender, EventArgs e)
        {
            if (gbSelect.Visible)
            {
                gbSelect.Visible = false;
            }
            else
            {
                gbSelect.Visible = true;
            }
        }

        private void btnMenuData_Click(object sender, EventArgs e)
        {
            if (gbData.Visible)
            {
                gbData.Visible = false;
            }
            else
            {
                gbData.Visible = true;
            }
        }

        private int SetRange(double valueZoom, int start)
        {
            var result = start + SIR.GetIndexRange(ValueZoom, start);
            if (Result.Item2 > result && start + SIR.GetIndexRange(ValueZoom,Result.Item2) < Result.Item2)
            {
                setchart.DrawingIntendedData(DataIntended.ItemX, DataIntended.ItemY, SelectIndexZoom);
                
                lblRangeData.Text = $"{Start} - {result}";
                lblIndex.Text = xData.ToString();

                SourceDataGride();

                return (int)result;
            }
            else
            {
                return (int)Result.Item2;
            }
        }
    }


}
