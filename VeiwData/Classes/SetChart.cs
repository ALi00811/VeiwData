using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace VeiwData.Classes
{
    public class SetChart
    {
        #region Properties
        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
        private double[] allData;
        private double[] dataIntended;

        #endregion

        public SetChart(short[] data)
        {
            allData = new double[data.Length];
            Array.Copy(data, 0, allData, 0, data.Length);

            DrawingAllData();
        }
        private void DrawingAllData()
        {
            openForms.wfgAllData.Plots[0].PlotY(allData);
            openForms.scrollBar = new ScroolBar();
        }
        public void DrawingIntendedData(short[] dataChart, int perecentIntended)
        {
            switch (perecentIntended)
            {
                case 1:
                    openForms.wfgChartIntended.Plots[0].PlotY(allData);
                    break;

                case 2:
                    DrawingChart(dataChart);
                    break;

                case 3:
                    DrawingChart(dataChart);
                    break;

            }
        }
        private void DrawingChart(short[] data)
        {
            dataIntended = new double[data.Length];
            Array.Copy(data, 0, dataIntended, 0, data.Length);
            openForms.wfgChartIntended.Plots[0].PlotY(dataIntended);
        }
    }
}
