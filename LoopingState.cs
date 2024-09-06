using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public  class LoopingState
    {
        public LoopingState()
        {
            
        }

        public void SomeFunction()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("i =" + i + "  ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("    j =" + j + "  ");

                }
                Console.WriteLine();

            }
        }
    }
}
