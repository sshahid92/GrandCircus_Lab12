using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        
        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public new virtual string ToString()
        {
            string personDataSheet = $"{LastName}, {FirstName}\t\t" +
                                     $"{Address}\t";
            return personDataSheet;
        }
    }
}
