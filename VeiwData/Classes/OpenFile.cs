using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeiwData.Classes;

namespace VeiwData
{
    public static class OpenFile
    {
        public static Model Open()
        {
            Model Model = null;
            frmMain OpenForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();
            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream sr = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(sr);

                    Model = new Model(){BinaryReader = br ,FileStream = sr, OpenFileDialog=ofd};

                    OpenForms.access = true;
                }
            }
            return Model;

        }

    }
}
