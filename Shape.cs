using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class Shape
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual int CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        public int Radious { get; set; }
        public override int CalculateArea()
        {
            return (22/7)*Radious*Radious;
        }
    }

    public class Squre : Shape
    {
        public int length { get; set; }
        public override int CalculateArea()
        {
            return length * length;
        }
    }

}
