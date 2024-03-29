﻿using NationalInstruments.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VeiwData.FFT;


namespace VeiwData.Classes
{
    public class SetChart
    {
        #region Properties
        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
        private double[] X, Y;
        private double[] xDraw, yDraw;
        #endregion

        public SetChart(long[] x, long[] y)
        {
            X = new double[x.Length];
            Y = new double[y.Length];
            Array.Copy(x, 0, X, 0, x.Length);
            Array.Copy(y, 0, Y, 0, y.Length);
            DrawingAllData();
            
        }

        private void DrawingAllData()
        {
            openForms.sgAllData.PlotXY(X, Y);
            openForms.scatterGraph2.PlotXY(X, Y);
            openForms.sgAllData.XAxes[0].Range = new Range(1, X.Max());
            openForms.sgIntendedData.XAxes[0].Range = new Range(1, X.Max());
            openForms.scrollBar = new ScroolBar();
        }

        public void DrawingIntendedData(long[] x, long[] y, double perecentIntended)
        {
            switch (perecentIntended)
            {
                case 8:
                    openForms.sgIntendedData.Plots[0].PlotXY(X, Y);
                    openForms.sgIntendedData.XAxes[0].Range = new Range(1, X.Max());
                    break;

                default:
                    DrawingChart(x, y);
                    break;
            }
        }

        private void DrawingChart(long[] x, long[] y)
        {
            xDraw = new double[x.Length];
            yDraw = new double[y.Length];
            Array.Copy(x, 0, xDraw, 0, x.Length);
            Array.Copy(y, 0, yDraw, 0, y.Length);

            openForms.scatterGraph2.Plots[0].PlotXY(xDraw, yDraw);
        }
        private void FFT()
        {
            var bandwith = X[X.Length - 1] - X[0];
            var center = X[X.Length - 1] - bandwith / 2;

            double[] FX = new double[256];
            for (int i = 0; i < FX.Length; i++)
            {
                FX[i] = center - bandwith / 2 + (i * (bandwith / 256));
            }
            GetFFT fft = new GetFFT(Y, FX);
        }
    }
}


