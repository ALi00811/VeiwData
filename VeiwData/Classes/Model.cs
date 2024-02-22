using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeiwData.Classes
{
    public class Model
    {
        public BinaryReader BinaryReader { get; set; }
        public FileStream FileStream { get; set; }
        public OpenFileDialog OpenFileDialog{ get; set; }
    }
}
