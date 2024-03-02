using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VeiwData
{
    public static class OpenFile
    {
        public static Tuple<FileStream, long> Open()
        {

            frmMain OpenForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
            FileStream streamReader = null;
            long fileLength = 0;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    streamReader = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    fileLength = new FileInfo(ofd.FileName).Length;
                    OpenForms.access = true;
                }
            }
            return Tuple.Create(streamReader, fileLength);
        }
    }
}
