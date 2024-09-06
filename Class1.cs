using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreation
{
    public interface IAccount
    {
        int GetAccountNo();
    }

    public interface IPrint
    {
        void Print();
        void SendMail(string emailID);
    }

    public class Sales : IAccount, IPrint
    {
        public int GetAccountNo()
        {
            return 100;
        }

        public void Print()
        {
            Console.WriteLine("Print...");
        }

        public void SendMail(string emailID)
        {
            Console.WriteLine($"Mail sending to {emailID}");
        }
    }

    public class Purchase : IAccount
    {
        public int GetAccountNo()
        {
            return 199;
        }
    }
}
