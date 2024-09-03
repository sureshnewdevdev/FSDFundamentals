using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreation
{
    public class Maths
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        private int sum;

        public Maths()
        {
            sum = 0;
        }
        public int Sum
        {
            get
            {
                return GetCalculation();
            }
        }

        private int GetCalculation()
        {
            int result = 0;
            result = NumberOne + NumberTwo;
            return result;
        }

        
    }
}
