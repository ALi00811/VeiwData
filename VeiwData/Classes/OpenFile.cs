using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VeiwData
{
    public static class OpenFile
    {
        public static string FileName { get; set; }
        public static long FileLength { get; set; }

        public static Tuple<FileStream, long, string> Open()
        {

            Stopwatch stopwatch = new Stopwatch();
            frmMain OpenForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
            FileStream streamReader = null;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    stopwatch.Start();
                    streamReader = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    FileLength = new FileInfo(ofd.FileName).Length;
                    FileName = ofd.FileName;
                    stopwatch.Stop();
                    OpenForms.isAccess = true;
                }
            }
            OpenForms.lblStatusProcessor.Text = $"Opened in {stopwatch.Elapsed} Secend";
            return Tuple.Create(streamReader, FileLength, FileName);
            
        }
    }
}
