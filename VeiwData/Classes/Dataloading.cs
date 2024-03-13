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
        public ReturnValues GetData(int startIndex, long dataLength, long step,int arrayLength)
        {
            Y = new long[arrayLength];
            X = new long[arrayLength];
            buff = new byte[2];
            var index = 0;
            int i;
            if (startIndex != 0) FileStream.Seek(startIndex, SeekOrigin.Begin);
            i = startIndex != 0 ? i = startIndex : i = 0;
            for (; i < dataLength; i++)
            {
                if (startIndex == 0) FileStream.Seek(step * i, SeekOrigin.Begin);
                FileStream.Read(buff, 0, 2);
                Y[index] = BitConverter.ToInt16(buff, 0);
                X[index] = index * step; 
                index++;
            }
            return new ReturnValues(X, Y);
        }
        #endregion
    }
}
