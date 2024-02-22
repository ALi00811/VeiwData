using NationalInstruments.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace VeiwData.Classes
{
    public class SetChart
    {
        #region Properties
        private short[] Datas { get; set; }
        #endregion
        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();

        public SetChart(short[] data)
        {
            Datas = data;
            Drawing();
        }
        private void Drawing()
        {
            double[] testdata = new double[Datas.Length];
            Array.Copy(Datas, 0, testdata, 0, Datas.Length);

            //openForms.wfgChart.Plots.Clear();
            openForms.wfgAllData.Plots[0].PlotY(testdata);
        }
    }
}
