using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public interface IProduct
    {
        int GetProductWeight();
        string GetOwnerName();
    }

    public class MyProduct : IProduct
    {
        public string GetOwnerName()
        {
            return "MRF";
        }

        public int GetProductWeight()
        {
            return 5;
        }
    }

    public class Type : IProduct
    {
        public string GetOwnerName()
        {
            return "Nylon";
        }

        public int GetProductWeight()
        {
            return 4;
        }
    }
}
