using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Person
    {
        public string Name { get; set; }
        private string _address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            _address = address;
        }

        public new virtual string ToString()
        {
            string personDataSheet = $"Name: {Name}\n" +
                                     $"Adress: {_address}\n";
            return personDataSheet;
        }
    }
}
