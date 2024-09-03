
namespace FSDFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region COnstructor Chain  
            //Book book = new Book(10);

            //book.DisplayProgramFlow();

            //Console.ReadLine();

            #endregion

            #region Inhertiance Examples

            Father father = new Father() { Id=100, Name="Father " };


            Son son = new Son() { Id =1000, Name ="Son" };


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

            Son s1=(Son)father;

            s1.GoingSchool(); // the child or son property is called from father or parent object.

            DisplayObject(son);
            DisplayObject(daughter);

            #endregion
        }

        private static void DisplayObject(Father father)
        {
            Console.WriteLine( father.Name + "  " + father.Id);

            if (father is Son)
            {

            }

            if (father is Dauhter)
            {

            }

        }
    }
}
