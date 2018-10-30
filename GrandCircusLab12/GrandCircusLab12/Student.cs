using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Student : Person
    {
        private string _program { get; set; }
        private int _year { get; set; }
        private double _fee { get; set; }

        public Student(string name, string address,
            string program, int year, double fee) : base(name, address)
        {
            _program = program;
            _year = year;
            _fee = fee;
        }

        public override string ToString()
        {
            string studentDataSheet = $"Progrm: {_program}\n" +
                                    $"Year: {_year}\n" +
                                    $"Fee: {_fee}\n";
            return base.ToString() + studentDataSheet;
        }
    }
}
