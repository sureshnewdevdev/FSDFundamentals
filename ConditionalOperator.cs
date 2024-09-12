using ClassCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class ConditionalOperator
    {


        /// <summary>
        /// Example of using replace statement
        /// </summary>
        public void ExampleReplaceSpace()
        {
            string sentense = "Goa&&&&&&&is&&&&&&&beautiful&&&&&spot&&to&&&&visit.";

            string fineTuned = sentense.Replace("&", " ");

            sentense = sentense.Replace("&", " ");

            Console.WriteLine(fineTuned);
        }


        /// <summary>
        /// String functions 
        /// </summary>

        public void ExampleOfStringOperations()
        {
            string words = "Subbaian is Great man.";

            // convert 
            char[] chars = words.ToCharArray();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ' )
                    count++;

            }

            Console.WriteLine($"Number of spaces in {words} is {count}");

        }



        public void ExampleOfConditionalOperator1()
        {
            int a = 10;
            int b = 90;

            if (a>b)
            {
                Console.WriteLine("A is big");
            }
            else
            {
                Console.WriteLine("B is Big");
            }
            
            // && -and
            // || or
            // ! not

            // to check which is biggest nuber using condition operator
            string output  = (a > b) ? Print(a) : Print(b);

            int bigNumberIs  = (a > b) ? a : b;

            //a,b,c

            int x,y,z,w;

            x = 20;
            y = 10;
            z = 50;
            w = 70;

            
            var big = (x > y) && (x > z) && (x > w) ? x :
                      (y > z) && (y > w) ? y :
                      (z > w) ? z : w;

            Print(b);

            Console.WriteLine(output);
        }

        private string Print(int n)
        {
            
            return $"{n} is big ";
        }

         
    }
}
