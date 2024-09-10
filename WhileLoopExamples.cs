using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class WhileLoopExamples
    {
        public  void Example1()
        {
            int n = 10;
            int i = 0;

            while (i<n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        // 0,1,1,2,3,5,8,13,21..n
       public void Example3() {
            int n = 10;
            int i = 0;

            int firstNumber = -1;
            int secondNumber = 1;
            int fibNumber = 0;

            while (true)
            {
                fibNumber =firstNumber + secondNumber;
                if (fibNumber > n)
                    break;
                Console.WriteLine(fibNumber);
                firstNumber = secondNumber;
                secondNumber = fibNumber;

            }
        }
        public void Example2()
        {
           
            int choice = 0;
            int a = 0;
            int b = 0;
            int ans = 0;

            Console.WriteLine("Please enter your choice");
            Console.WriteLine("1==> Add ");
            Console.WriteLine("2==> Subtract");
            Console.WriteLine("3==> Multiple");
            Console.WriteLine("4 ==> Divide");
            Console.WriteLine("-1 ==> to Exit");
            choice = int.Parse(Console.ReadLine());

            while (choice != -1)
            {
                Console.WriteLine("Enter value for a");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter value for b");
                b = int.Parse(Console.ReadLine());
                                      
                
                if (choice==1)
                    ans = a + b;

                if (choice == 2)
                    ans = a - b;
                if (choice == 3)
                    ans = a * b;
                if (choice == 4)
                    ans = a / b;


                Console.WriteLine($" Answer = {ans} ");

                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1==> Add ");
                Console.WriteLine("2==> Subtract");
                Console.WriteLine("3==> Multiple");
                Console.WriteLine("4 ==> Divide");
                Console.WriteLine("-1 ==> to Exit");
                choice = int.Parse(Console.ReadLine());

            }

            
        }


    }
}
