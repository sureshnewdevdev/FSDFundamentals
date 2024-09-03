using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDFundamentals
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string programFlow { set; get; }
        private Book()
        {
            programFlow = $"** At {DateTime.Now} Program started ** " + Environment.NewLine;
            
        }
        public Book(int bookId) : this()
        {
            BookID=bookId;
            programFlow += $"** At {DateTime.Now} Book Id Assigned ** " + Environment.NewLine;
        }
        public void DisplayProgramFlow()
        {
            Console.WriteLine(programFlow);
        }
    }
}
