using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwData.Classes
{
    public class SetIndexRange
    {
        public double Result { get; set; }
        public double GetIndexRange(double valueZoom, int width)
        {
            switch (valueZoom)
            {
                case 2.5:
                    Result = (width * 2) * 0.025;
                    break;
                case 5:
                    Result = (width * 2) * 0.05;
                    break;
                case 7.5:
                    Result = (width * 2) * 0.075;
                    break;
                case 10:
                    Result = (width * 2) * 0.1;
                    break;
                case 20:
                    Result = (width * 2) * 0.2;
                    break;
                case 30:
                    Result = (width * 2) * 0.3;
                    break;
                case 50:
                    Result = (width * 2) * 0.5;
                    break;
                case 70:
                    Result = (width * 2) * 0.7;
                    break;
            }
            return Result;
        }

    }
}
