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
        int GetOwnerName();
    }

    public class MyProduct : IProduct
    {
        public int GetOwnerName()
        {
            throw new NotImplementedException();
        }

        public int GetProductWeight()
        {
            throw new NotImplementedException();
        }
    }
}
