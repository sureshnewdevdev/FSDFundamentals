using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class ExamplesOfStrings
    {
        public void CommonMethods()
        {
            string name = "Shankar";

            string result = name.ToUpper();
            result = name.ToLower();

            DateTime toDay = DateTime.UtcNow;

            result = toDay.ToString();

            Console.WriteLine(DateTime.Now);


        }
        public void ReverseString()
        {
            string normalString = "***";
            //malayalam
            //for (int j = 0; j < 10; ) // for printing the loop till program stops
            //for (int j = 0; j < 10;)
            //while(1==1)
            while(true)
            {
                for (int i = normalString.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(normalString.Substring(i));
                    //Thread.Sleep(1000);
                }
                Thread.Sleep(1000);

                for (int i = 0; i < normalString.Length; i++)
                {
                    Console.WriteLine(normalString.Substring(i));
                    //Thread.Sleep(1000);

                }

            }
            
            //Console.Write(normalString.Substring(4, 1));
            //Console.Write(normalString.Substring(3, 1));
            //Console.Write(normalString.Substring(2, 1));
            //Console.Write(normalString.Substring(1, 1));
            //Console.Write(normalString.Substring(0, 1));
        }
    }
}
