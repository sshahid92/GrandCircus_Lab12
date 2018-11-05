using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Student : Person, IComparable<Student>
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student(string firstName, string lastName, string address,
            string program, int year, double fee) : base(firstName, lastName, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public virtual int CompareTo(Student other)
        {
            // Alphabetic sort by firstname if lastname is equal. [A to Z]
            if (LastName == other.LastName)
            {
                int result = FirstName.CompareTo(other.FirstName);
                return result;
            }
            // Default lastname sort. [A to Z]
            return LastName.CompareTo(other.LastName);
        }

        public virtual int CompareTo(ArchivedStudent other)
        {
            // Alphabetic sort by firstname if lastname is equal. [A to Z]
            if (LastName == other.LastName)
            {
                int result = FirstName.CompareTo(other.FirstName);
                return result;
            }
            // Default lastname sort. [A to Z]
            return LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            string studentDataSheet = $"{Program}\t" +
                                      $"{Year}\t" +
                                      $"{Fee:C}\t";
            return base.ToString() + studentDataSheet;
        }


    }
}
