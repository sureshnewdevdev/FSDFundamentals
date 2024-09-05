using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public abstract class Employee
    {
        protected Employee()
        {
            Id = 0;
            Name = "A";
        }
        protected Employee(int id)
        {
            Id= id;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract string LivingStyle();

        public int GetSalary()
        {
            return 10;
        }

        public string DisplayName()
        {
            return Name;
        }
    }

    public class IndainEmployee : Employee
    {
        public IndainEmployee()
        {
            
        }

        public IndainEmployee(int v)
        {
        }

        public override string LivingStyle()
        {
            return "Living TOgether as Family";
        }
    }

    public class USEmployee : Employee
    {
        public override string LivingStyle()
        {
            return "Love to Live alone and family";
        }
    }
}
