using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreation
{
    /// <summary>
    /// This class is to define Person
    /// </summary>
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// This function help to get the display string of person.
        /// </summary>
        /// <returns>The result.</returns>
        public string DisplayPerson()
        {
            
            string result = string.Empty; //""
            result = Id.ToString() + " " + Name;
            return result;
        }
    }
}
