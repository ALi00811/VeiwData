using System;
using System.Linq;
using System.Windows.Forms;
using NationalInstruments;

namespace VeiwData.FFT
{
    internal class GetFFT
    {
        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();

        public GetFFT(double[] data, double[] XLabelFrequency)
        {
            try
            {
                ComplexDouble[] processData = new ComplexDouble[(data.Length / 2) + 1];
                for (int counter = 0; counter < data.Length; counter++)
                {
                    if (counter % 2 == 0)
                    {
                        processData[counter / 2].Real = data[counter];
                    }
                    else
                    {
                        processData[counter / 2].Imaginary = data[counter];
                    }
                }
                CalculateFFTFunction(processData, XLabelFrequency);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalculateFFTFunction(ComplexDouble[] waveform, double[] XLabelFrequency)
        {
            try
            {
                int _fftSizeValue = XLabelFrequency.Length;
                ComplexDouble[] FFTValue = new ComplexDouble[waveform.Length];
                FFTValue = NationalInstruments.Analysis.Dsp.Transforms.Fft(waveform, true, _fftSizeValue);
                double[] abs = new double[FFTValue.Length];
                for (int i = 0; i < FFTValue.Length; i++)
                {
                    abs[i] = Math.Sqrt(Math.Pow(FFTValue[i].Real, 2) + Math.Pow(FFTValue[i].Imaginary, 2));
                    abs[i] = 10 * Math.Log10(Math.Pow(abs[i], 2) / _fftSizeValue);
                }
                Draw(XLabelFrequency, abs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Draw(double[] xData, double[] yData)
        {
            try
            {
                openForms.scatterGraph1.PlotXY(xData, yData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
