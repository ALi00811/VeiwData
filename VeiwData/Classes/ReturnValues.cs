using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwData.Classes
{
    public class ReturnValues
    {
        public long[] ItemX{ get; set; }
        public long[] ItemY { get; set; }

        public ReturnValues(long[] valuesX , long[] valuesY )
        {
            ItemX = valuesX;
            ItemY = valuesY;
        }
    }
}
