﻿using System;
using System.IO;

namespace VeiwData.Classes
{
    public class Dataloading
    {
        #region Properties
        private FileStream FileStream { get; set; }
        private FileStream FileStreamIntended { get; set; }
        short[] Data { get; set; }
        long dataLength = 0;
        long step = 0;
        #endregion

        public Dataloading(FileStream fileStream, int withScreen, long filelength)
        {
            FileStream = fileStream;
            FileStreamIntended = fileStream;
            dataLength = withScreen * 2;

            step = filelength / dataLength;
        }

        public short[] GetAllData()
        {
            Data = new short[dataLength];
            byte[] buff = new byte[2];

            for (int i = 0; i < dataLength; i++)
            {
                FileStream.Seek(i * step, SeekOrigin.Begin);
                FileStream.Read(buff, 0, 2);
                Data[i] = BitConverter.ToInt16(buff, 0);
            }

            return Data;
        }

        public short[] GetDataIntended(int startIndex, long dataLength, int end)
        {
            short[] DataIntended = new short[dataLength + 1];
            byte[] buff = new byte[2];
            int indexCount = 0;
            int i = startIndex;
            FileStreamIntended.Seek(startIndex, SeekOrigin.Begin);
            for (; i < end; i++)
            {
                FileStreamIntended.Read(buff, 0, 2);
                DataIntended[indexCount] = BitConverter.ToInt16(buff, 0);
                indexCount ++;
            }

            return DataIntended;
        }
    }
}