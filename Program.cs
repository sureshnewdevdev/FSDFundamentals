﻿

using ClassCreation;
using MathsLib;

namespace FSDFundamentals
{

    class ProductItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return $" Product Id  = { ProductId } - Product Name {ProductName}  ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region COnstructor Chain  
            //Book book = new Book(10);

            //book.DisplayProgramFlow();

            //Console.ReadLine();

            #endregion

            // InheritanceExample();

            /*
             * This function is checking abstract
             */


            // AbstractClassExample();

            // LoopingState l = new LoopingState();
            // l.SomeFunction();

            //l.ForLoopExample2();


            //WhileLoopExamples whileLoopExamples = new WhileLoopExamples();
            //whileLoopExamples.Example1();

            //whileLoopExamples.Example2();
            //whileLoopExamples.Example3();

            //DoWhileExample doWhileExample=new DoWhileExample();

            //doWhileExample.ExampleOfDoWhile();


            //ConditionalOperator conditionalOperator = new ConditionalOperator();

            //conditionalOperator.ExampleOfStringOperations();

            //conditionalOperator.ExampleReplaceSpace();


            //var callobejct = new ConditionalOperator();
            //callobejct.ExampleReplaceSpace();

            //ExamplesOfStrings examplesOfStrings = new ExamplesOfStrings();

            //examplesOfStrings.ReverseString();

            //NuroNumberSystem nuroNumberSystem=new NuroNumberSystem();

            //var result = nuroNumberSystem.BrainWeight();
            //Console.WriteLine(result);

            //examplesOfStrings.CommonMethods();


            //int x = 100; //int 
            //object obj = x; // object

            //int unboxedValue = (int)obj; // unboxing

            //Maths m = new Maths();
            //obj = m;

            //ExampleOfCollection collection = new ExampleOfCollection();

            //collection.WorkOut();


            //ExampleDataStructureWithCollection exampleDataStructureWithCollection = new ExampleDataStructureWithCollection();

            //exampleDataStructureWithCollection.Workout();

            //ExampleOfGenerics exampleOfGenerics = new ExampleOfGenerics();

            //exampleOfGenerics.Workout();

            //exampleOfGenerics.UsingDictionary();

            ProductItem productItem = new ProductItem();
            productItem.ProductId = 10;
            productItem.ProductName = "Apple";


            Console.WriteLine(productItem);

            Console.ReadLine();
        }

        private static void AbstractClassExample()
        {
            //IndainEmployee employee= new IndainEmployee();

            Employee employee2 = new IndainEmployee(10);//child


        }

        private static void InheritanceExample()
        {
            #region Inhertiance Examples

            Father father = new Father() { Id = 100, Name = "Father " };


            Son son = new Son() { Id = 1000, Name = "Son" };


            Dauhter daughter = new Dauhter()
            {
                Id = 2000,
                Name = "Daughter"
            };

            father = daughter;

            father = son;

            Console.WriteLine(father.Id); // Since son is assigned in father . you will get only son's properties
            Console.WriteLine(father.Name);

            //To To get son properties stored in father , you have convert or cast to original or Child type to GET THE SON PROPERTIES

            Son s1 = (Son)father;

            s1.GoingSchool(); // the child or son property is called from father or parent object.

            DisplayObject(son);
            DisplayObject(daughter);

            #endregion
        }


        // big <== Small
        // Father = Son

        // Small <== Big
        // Son = Fathre as son

        private static void DisplayObject(Father father)
        {

            GovtWorker gt = new GovtWorker();
            Console.WriteLine( father.Name + "  " + father.Id);

            if (father is Son)
            {
                Son convertedSon = father as Son;
                Console.WriteLine($"Welcome my come son {convertedSon.Name}");
                convertedSon.GoingSchool();
            }

            if (father is Dauhter)
            {
                Dauhter d = father as Dauhter;
                Console.WriteLine($"Welcome my come Daughter {d.Name}");
                d.GoingTOCollege();
            }

        }
    }
}
