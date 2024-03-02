using System.Drawing;
using System.Windows.Forms;

namespace VeiwData.Classes
{
    public class Resolotion
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public  Resolotion()
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            Width = resolution.Width;
            Height = resolution.Height;
        }
    }
}
