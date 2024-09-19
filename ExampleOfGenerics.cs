using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{

    public class Stu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $" Id= {Id} Name = {Name} ";
        }


    }
    public class ExampleOfGenerics
    {
        public void Workout()
        {
            List<string> names = new List<string>();
            names.Add("Anu");
            names.Add("Balu");
            names.Add("Raja");
            names.Add("Citra");

            Console.WriteLine("Before Ordering");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            names.Sort();

            Console.WriteLine("After Ordering");


            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public void UsingDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1000, "A");
            dict.Add(565, "B");
            dict.Add(3232, "C");
            dict.Add(4343, "D");

            //for (int i = 1;i <= dict.Count;i++) {
            //    Console.WriteLine(dict[i]);Ḥ
            //}

            foreach (var item in dict)
            {
                Console.WriteLine($"Key is {item.Key} value is {item.Value}");
            }

            Dictionary<string, string> productCatalog = new Dictionary<string, string>();
            productCatalog.Add("Fruits01", "Apple");
            productCatalog.Add("Fruits02", "Mango");
            productCatalog.Add("Fruits03", "Orange");

            foreach (var item in productCatalog)
            {
                Console.WriteLine(item.Value);
            }

            Dictionary<int, Stu> stuList = new Dictionary<int, Stu>();

            Stu s1 = new Stu()
            {
                Id = 1,
                Name = "A"
            };

            stuList.Add(10, s1);
            stuList.Add(20, new Stu { Id=10, Name="Raj"  });
            stuList.Add(30, new Stu { Id=30, Name="Ram"  });
            stuList.Add(40, new Stu { Id=40, Name="varma"  });
            stuList.Add(50, new Stu { Id=50, Name="GG"  });

            //foreach (var stuItem in stuList)
            //{
            //    Console.WriteLine($" Id {stuItem.Value.Id} Name {stuItem.Value.Name} ");

            //}

            foreach (var item in stuList)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}




