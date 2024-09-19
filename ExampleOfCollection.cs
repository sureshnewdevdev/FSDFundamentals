using ClassCreation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class ExampleOfCollection
    {
        public void WorkOut()
        {
            int[] numbers=new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Disadvantages
            // Limited size
            // Memory leak
            // Constant type

           

            
            //System.Collections.ArrayList numbersList = new System.Collections.ArrayList();
            ArrayList numbersList = new ArrayList();

            numbersList.Add(1);
            numbersList.Add("Gopi");
            numbersList.Add(3);
            numbersList.Add(4);
            numbersList.Add(5);
            numbersList.Insert(2, 1000);

            int integerSum = 0;

            foreach (var item in numbersList)
            {
                if (item is int)
                {
                    integerSum += (int)item; // integerSum = integerSum+(int)item;
                }
                if(item is long)
                {

                }
            }
        }
    }
}
