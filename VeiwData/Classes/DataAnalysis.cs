using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace VeiwData.Classes
{
    public class DataAnalysis
    {

        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
        Rectangle resolution = Screen.PrimaryScreen.Bounds;

        public DataAnalysis(byte[] Datas, int Percent)
        {
            openForms.chartData.Series.Clear();
            //int Count = listData.Length / Percent;
            Series data = new Series();
            for (int i = 0; i < resolution; i++)
            {
                data.Points.Add(Datas[i + 500000], i);
            }
            openForms.chartData.Series.Add(data);
        }
    }
}

