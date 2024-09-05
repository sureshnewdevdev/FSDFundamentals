using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class Father
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string EarnMoney()
        {
            return "Handful Money";
        }
    }

    public class Son :Father
    {
        public string GoingSchool()
        {
            return "Govt School";
        }
    }

    public class Dauhter : Father
    {
        public string GoingTOCollege()
        {
            return "IT Enginnering College";
        }
    }
}
