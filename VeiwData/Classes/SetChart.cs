﻿using NationalInstruments.UI;
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
        public void DrawingIntendedData(short[] dataChart, double perecentIntended, int withScreen)
        {
            switch (perecentIntended)
            {
                case 8:
                    openForms.wfgChartIntended.Plots[0].PlotY(allData);
                    openForms.wfgChartIntended.XAxes[0].Range = new Range(0, withScreen);
                    break;

                default:
                    openForms.wfgChartIntended.XAxes[0].Range = new Range(0, dataChart.Length);
                    openForms.wfgChartIntended.YAxes[0].Range = new Range(Int16.MinValue, Int16.MaxValue);
                    DrawingChart(dataChart);

                    break;


            }
        }
        private void DrawingChart(short[] data)
        {
            dataIntended = new double[data.Length];
            Array.Copy(data, 0, dataIntended, 0, data.Length);
            openForms.wfgChartIntended.Plots[0].PlotY(dataIntended);
            openForms.wfgChartIntended.InteractionModeDefault = GraphDefaultInteractionMode.ZoomX;
            

        }
    }
}
