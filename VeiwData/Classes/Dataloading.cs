using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeiwData.Classes
{
    public class Dataloading
    {
        #region Properties
        private BinaryReader BinaryReader { get; set; }
        private FileStream FileStream { get; set; }
        private OpenFileDialog OpenFileDialog { get; set; }
        short[] Data { get; set; }
        long dataLength = 0;
        long fileLength = 0;
        long step = 0;
        #endregion

        public Dataloading(Model model, Resolotion resolotion)
        {
            BinaryReader = model.BinaryReader;
            FileStream = model.FileStream;
            OpenFileDialog = model.OpenFileDialog;

            dataLength = resolotion.Width * 2;

            fileLength = new FileInfo(OpenFileDialog.FileName).Length;
            step = fileLength / dataLength;

            GetAllData();
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
    }
}