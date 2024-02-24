using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeiwData.Classes;

namespace VeiwData
{
    public partial class frmMain : Form
    {
        Dataloading Da;
        SetChart setchart;
        Resolotion resolotion;
        public int DisplayRange { get; set; }
        //public short[] DataDisplayRange { get; set; }
        public bool access = false;
        public double IndexSpace { get; set; }

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
                Da = new Dataloading(Result , resolotion);
                setchart = new SetChart(Da.GetAllData());

                lblNameFile.Text = Result.OpenFileDialog.FileName;
                lblSizeData.Text = Result.FileStream.Length.ToString("#,0");
            }
        }

        private void rdFull_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFull.Checked)
            {
                DisplayRange = 1;
            }
        }

        private void rdHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHalf.Checked)
            {
                DisplayRange = 2;
            }
        }

        private void rdless_CheckedChanged(object sender, EventArgs e)
        {
            if (rdless.Checked)
            {
                DisplayRange = 3;
            }
        }

        private void wfgAllData_PlotAreaMouseUp(object sender, MouseEventArgs e)
        {
            if (access)
            {
                double xData, yData = 0;
                Point p = new Point(e.X, e.Y);

                wfgAllData.Plots[0].InverseMapDataPoint(wfgAllData.PlotAreaBounds, p, out xData,out yData);
                wfgAllData.Cursors[0].XPosition = xData;
                if (DisplayRange != 1) { IndexSpace = DisplayRange == 2 ? resolotion.Width * 0.1 : resolotion.Width * 0.5; }
                setchart.DrawingIntendedData(xData, (int)IndexSpace, DisplayRange);
            }
        }
    }
}
