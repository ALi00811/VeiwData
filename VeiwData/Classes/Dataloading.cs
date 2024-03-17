using NationalInstruments.UI;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VeiwData.Classes
{
    public class Dataloading
    {
        #region Properties
        long[] Y { get; set; }
        long[] X { get; set; }

        byte[] buff;
        #endregion

        #region objects
        private FileStream FileStream { get; set; }
        #endregion

        public Dataloading(FileStream fileStream)
        {
            FileStream = fileStream;
        }
        #region GetData
        public ClassDatas GetData(int startIndex, long step, int arrayLength)
        {
            Y = new long[arrayLength];
            X = new long[arrayLength];
            buff = new byte[2];

            for (int i = 0; i < arrayLength; i++)
            {
                FileStream.Seek(startIndex + (step * i), SeekOrigin.Begin);
                FileStream.Read(buff, 0, 2);
                Y[i] = BitConverter.ToInt16(buff, 0);
                X[i] = i * step;
            }
            var finalNumber = startIndex + (step * arrayLength - 1);
            return new ClassDatas(X, Y, finalNumber);
        }
        #endregion
    }
}
