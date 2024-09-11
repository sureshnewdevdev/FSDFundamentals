using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public enum Choice
    {
        Add=1,
        Sub=2,
        Mul=3,
        Div=4,
        exit =-1
    }
    public class DoWhileExample
    {



        //public void ExampleOfDoWhile()
        //{
        //    int choice =0;
        //    int ans=0;
        //    int a = 0;
        //    int b = 0;
        //    do
        //    {
        //        Console.WriteLine("Please enter your choice");
        //        Console.WriteLine("1==> Add ");
        //        Console.WriteLine("2==> Subtract");
        //        Console.WriteLine("3==> Multiple");
        //        Console.WriteLine("4 ==> Divide");
        //        Console.WriteLine("-1 ==> to Exit");
        //        choice = int.Parse(Console.ReadLine());

        //        if (choice == -1)
        //            break;

        //        Console.WriteLine("Enter value for a");
        //        a = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter value for b");
        //        b = int.Parse(Console.ReadLine());


        //        if (choice == 1)
        //        {
        //            ans = a + b;
        //            Console.WriteLine($" Answer = {ans} ");
        //            continue;

        //        }

        //        if (choice == 2)
        //        {
        //            ans = a - b;
        //            Console.WriteLine($" Answer = {ans} ");
        //            continue;

        //        }
        //        if (choice == 3)
        //        {
        //            ans = a * b;
        //            Console.WriteLine($" Answer = {ans} ");
        //            continue;
        //        }
        //        if (choice == 4)
        //        { 
        //            ans = a / b;
        //            Console.WriteLine($" Answer = {ans} ");
        //        }



        //    } while (choice != -1);

        //public void ExampleOfDoWhile()
        //{
        //    int choice = 0;
        //    int ans = 0;
        //    int a = 0;
        //    int b = 0;
        //    do
        //    {
        //        Console.WriteLine("Please enter your choice");
        //        Console.WriteLine("1==> Add ");
        //        Console.WriteLine("2==> Subtract");
        //        Console.WriteLine("3==> Multiple");
        //        Console.WriteLine("4 ==> Divide");
        //        Console.WriteLine("-1 ==> to Exit");
        //        choice = int.Parse(Console.ReadLine());

        //        if (choice == -1)
        //            break;

        //        Console.WriteLine("Enter value for a");
        //        a = int.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter value for b");
        //        b = int.Parse(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                {
        //                    ans = a + b;
        //                    Console.WriteLine($" Answer = {ans} ");
        //                    break;
        //                }
        //            case 2:
        //                {
        //                    ans = a - b;
        //                    Console.WriteLine($" Answer = {ans} ");
        //                    break;
        //                }
        //            case 3:
        //                {
        //                    ans = a * b;
        //                    Console.WriteLine($" Answer = {ans} ");
        //                    break;
        //                }
        //            case 4:
        //                {
        //                    ans = a / b;
        //                    Console.WriteLine($" Answer = {ans} ");
        //                    break ;
        //                }
        //            case -1:
        //                {
        //                    continue;
        //                }
        //            default:
        //                {
        //                    Console.WriteLine($" Please enter a valid input  ");
        //                    break;
        //                }
        //        }

        //    } while (choice != -1);

        //}
        public void ExampleOfDoWhile()
        {
            Choice choice=new Choice();

            int ans = 0;
            int a = 0;
            int b = 0;
            do
            {
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("1==> Add ");
                Console.WriteLine("2==> Subtract");
                Console.WriteLine("3==> Multiple");
                Console.WriteLine("4 ==> Divide");
                Console.WriteLine("-1 ==> to Exit");
                
                choice= (Choice) int.Parse(Console.ReadLine());

                if (choice == Choice.exit)
                    break;

                Console.WriteLine("Enter value for a");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter value for b");
                b = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case Choice.Add:
                        ans = a + b;
                        break;
                    case Choice.Sub:
                        ans = a - b;
                        break;
                    case Choice.Mul:
                        ans = a * b;
                        break;
                    case Choice.Div:
                        ans = a / b;
                        break;
                    case Choice.exit:
                         break;
                    default:
                        break;
                }
                Console.WriteLine("Ans =" + ans);

            } while (choice != Choice.exit);

        }
    }
}
