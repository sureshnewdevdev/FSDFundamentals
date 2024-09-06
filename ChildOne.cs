using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    //class A
    //{

    //}
    //class B
    //{

    //}

    //class C: A,B
    //{

    //}

    public class ChildOne : IFather, IMother
    {
        public string Drive()
        {
            return "Car Drive";
        }

        public string Teaching()
        {
            return "Maths";
        }
    }
}
