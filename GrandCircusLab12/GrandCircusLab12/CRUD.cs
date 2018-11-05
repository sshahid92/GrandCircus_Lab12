using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class CRUD
    {
        public CRUD()
        {

        }

        #region Create Persons
        public List<Student> AddStudent(List<Student> list)
        {
            Validation validation = new Validation();

            Console.WriteLine("What is the students first name?");
            string firstName;
            do
            {
                firstName = validation.ValidateName(Console.ReadLine());
            } while (firstName == "notValid");

            Console.WriteLine("What is the students last name?");
            string lastName;
            do
            {
                lastName = validation.ValidateName(Console.ReadLine());
            } while (lastName == "notValid");

            Console.WriteLine("What is the students address?");
            string address;
            do
            {
                address = validation.ValidateAddress(Console.ReadLine());
            } while (address == "notValid");

            Console.WriteLine("What is the program the student is enrolled in?");
            string program;
            do
            {
                program = validation.ValidateProgram(Console.ReadLine());
            } while (program == "notValid");

            Console.WriteLine("What year is the sudent expected to complete the program?");
            int year;
            bool isYear = false;            
            do
            {
                bool isNum = int.TryParse(Console.ReadLine(), out year);
                isYear = validation.ValidateYear(year);
            } while (!isYear);

            Console.WriteLine("What is the students cost of tuition?");
            double fee;
            bool isTuition = false;
            do
            {
                bool isTuitionNum = double.TryParse(Console.ReadLine(), out fee);
                if (isTuitionNum)
                {
                    isTuition = validation.ValidateTuition(fee);
                }
                else
                {
                    Console.WriteLine("Enter a valid number. Try again.");
                    continue;
                }
            } while (!isTuition);
            
            Student student = new Student(firstName: firstName, lastName: lastName, address: address, program: program, year: year, fee: fee);
            list.Add(student);
            return list;
            
        }

        public List<ArchivedStudent> AddStudent(List<ArchivedStudent> list)
        {
            Validation validation = new Validation();

            Console.WriteLine("What is the students first name?");
            string firstName;
            do
            {
                firstName = validation.ValidateName(Console.ReadLine());
            } while (firstName == "notValid");

            Console.WriteLine("What is the students last name?");
            string lastName;
            do
            {
                lastName = validation.ValidateName(Console.ReadLine());
            } while (lastName == "notValid");

            Console.WriteLine("What is the students address?");
            string address;
            do
            {
                address = validation.ValidateAddress(Console.ReadLine());
            } while (address == "notValid");

            Console.WriteLine("What is the program the student is enrolled in?");
            string program;
            do
            {
                program = validation.ValidateProgram(Console.ReadLine());
            } while (program == "notValid");

            Console.WriteLine("What year is the sudent expected to complete the program?");
            int year;
            bool isYear = false;
            do
            {
                bool isNum = int.TryParse(Console.ReadLine(), out year);
                isYear = validation.ValidateYear(year);
            } while (!isYear);

            Console.WriteLine("What is the students cost of tuition?");
            double fee;
            bool isTuition = false;
            do
            {
                bool isTuitionNum = double.TryParse(Console.ReadLine(), out fee);
                if (isTuitionNum)
                {
                    isTuition = validation.ValidateTuition(fee);
                }
                else
                {
                    Console.WriteLine("Enter a valid number. Try again.");
                    continue;
                }
            } while (!isTuition);
                                  
            Console.WriteLine("What is the students final score?");
            int finalScore;
            bool isScore = false;
            do
            {
                bool isNum = int.TryParse(Console.ReadLine(), out finalScore);
                if (isNum)
                {
                    isScore = validation.ValidateScore(finalScore);
                }
                else
                {
                    Console.WriteLine("Enter a valid number. Try again.");
                    continue;
                }
            } while (!isScore);
            ArchivedStudent archivedStudent = new ArchivedStudent(firstName, lastName, address, program, year, fee, finalScore);
            list.Add(archivedStudent);
            return list;
           
        }

        public void AddStaff(List<Person> personList, string firstName, string lastName, string address, string school, double pay)
        {
            Person staff = new Staff(firstName: firstName, lastName: lastName, address: address, school: school, pay: pay);
            personList.Add(staff);
        }
        #endregion

    }
}
