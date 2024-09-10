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

        public void ForLoopExample2()
        {
            int n = 10;

            //for (int i = 0; i < n; i++)
            //{
            //    n = n - 2;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    //n = n - 2;
            //    i=i - 2;

            //}
            n = 10;
            //for (int i = 0;i < n; i++)
            //{
            //    if (i==5)
            //    {
            //        break;
            //    }
            //}

            //for(int i = 0;i < n; i++)
            //{
            //    if ((i % 2) ==0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Print Even numbers");
            //for (int i = 2; i<n;i=i+2  )
            //{
            //    Console.WriteLine(i);
            //}
            
            //Console.WriteLine("Print Odd numbers");
            //for (int i = 1; i < n; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Print Even numbers");
            //for (int i = 2; i < n; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            /*
             * 1*2=2
             * 2*2=4
             * 3*3=6
             */
            //Console.WriteLine("Print 10 Even numbers");
            //for (int i = 1; i <= n; i++)
            //{
            //    int evenNumber = i * 2;
            //    Console.WriteLine(evenNumber);
            //}
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
               
            }
            Console.WriteLine(sum);

            // 3,9,15,21...n
            n = 100;
            for (int i = 3; i <= n; i=i+6)
            {
                Console.WriteLine(i);
            }

        }
        /*
         * 2
         * 4
         * 6
         * 8
         * 10
         * 12
         * 14
         * 16
         * 18
         * 20
         */

        public void SomeFunction()
        {

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("i =" + i + "  ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("    j =  " + j + "  ");

                }
                Console.WriteLine();

            }
        }
    }
}
