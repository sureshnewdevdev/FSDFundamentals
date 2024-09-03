using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreation
{
    /// <summary>
    /// This is defination for Employee
    /// </summary>
    public class Employee
    {

        private decimal salary;
        public int EmpId { get; set; }
        public string Name { get; set; }
        
        /// <summary>
        /// this only to get the value
        /// </summary>
        public int DetectAmount { get; }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("Salary Can't be less than zero. invalid input");
                }

            }
        }
    }
}

