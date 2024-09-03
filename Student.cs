using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreation
{
    public class Student
    {

        public Student()
        {
            
        }

        public Student(int studentId)
        {
            Id = studentId;
        }
        public Student(int studentId, string studentName)
        {
            Id = studentId;
            Name = studentName;
        }
        public Student(int studentId, string studentName, int mark1)
        {
            Id = studentId;
            Name = studentName;
            Mark1 = mark1; 
        }
        // Constructor will set the initial memory and construct the object
        public Student(int studentId, string studentName, int mark1,int mark2)    
        {
            Id= studentId;
            Name= studentName;
            Mark1 = mark1;
            Mark2 = mark2;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }

        public int MaxMark { get; set; }
        public string ObjectCreatedTime { get; set; }

        public int GetTotal()
        { 
            int result = Mark1 + Mark2;
            return result;
        }

        public int GetAvg()
        {
            int avg = 0;
            avg= (Mark1 + Mark2)/2;
            return avg;
        }

    }
}
