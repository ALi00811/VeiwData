using NationalInstruments.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

        short[] datas;
        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
        private double[] allData;
        private short[] allDataIntended;
        private double[] dataIntended;

        #endregion

        public SetChart(short[] data)
        {
            datas = data;
            allData = new double[datas.Length];
            Array.Copy(datas, 0, allData, 0, datas.Length);
            DrawingAllData();
        }
        private void DrawingAllData()
        {
            openForms.wfgAllData.Plots[0].PlotY(allData);
        }
        public void DrawingIntendedData(double indexIntendedDatas, double step, int perecentIntended)
        {
            switch (perecentIntended)
            {
                case 1:
                    DrawingAllData();
                    break;

                case 2:
                    DrawingChart(indexIntendedDatas, step);
                    break;

                case 3:
                    //openForms.wfgChartIntended.Plots[0].PlotY(allDataIntended);
                    break;

            }
        }
        private void DrawingChart(double indexIntendedDatas, double step)
        {
            allDataIntended = new short[(int)step * 2];
            int i = (int)(indexIntendedDatas - step);
            int numBreak = (int)(indexIntendedDatas + step);

            for (; i < datas.Length; i++)
            {
                for (int j = 0; j < numBreak; j++)
                {
                    if (j == allDataIntended.Length) { break; }
                    allDataIntended[j] = datas[i];
                }
            }

            dataIntended = new double[allDataIntended.Length];
            Array.Copy(allDataIntended, 0, dataIntended, 0, allDataIntended.Length - 1);
            openForms.wfgChartIntended.Plots[0].PlotY(dataIntended);
        }

    }
}
