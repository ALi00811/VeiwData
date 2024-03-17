using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwData.Classes
{
    public class ClassDatas
    {
        public long[] ItemX{ get; set; }
        public long[] ItemY { get; set; }
        public long FinalNumber { get; set; }

        public ClassDatas(long[] valuesX , long[] valuesY , long finalNumber)
        {
            ItemX = valuesX;
            ItemY = valuesY;
            FinalNumber = finalNumber;
        }
    }
}
