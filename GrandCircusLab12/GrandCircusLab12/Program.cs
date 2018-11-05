using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Program
    {
        private static bool cont = true;
        static void Main(string[] args)
        {
            Validation validation = new Validation();

            var studentList = StudentList();
            var archivedStudentList = ArchivedStudentList();
            var sortList = SortAlpha(studentList, archivedStudentList);
            sortList.Sort();
            Console.WriteLine("Welcome to your student roster.\nHere is a list of your current students.\n");
            Console.WriteLine("NAME:\t\t\tADDRESS:\tPROGRAM\t\t\tYEAR\tTUITION\t\tFINAL SCORE:\n" +
                "============================================================================================");
            foreach (var item in sortList)
            {
                Console.WriteLine($"{item.ToString()}\n");
            }
            Console.ReadLine();

            while (cont)
            {
                Console.WriteLine("What would you like to do?\n1) View the list of students\n2) View the list of students sorted by grade\n3) Add a student\n4) Exit");
                bool isNum = false;
                bool isValid = false;
                int answer = 0;
                while (!isNum || !isValid)
                {
                    isNum = int.TryParse(Console.ReadLine(), out answer);
                    isValid = validation.ValidteMenuSelection(answer);
                }

                switch (answer)
                {
                    case 1:
                        var sortedList = SortAlpha(studentList, archivedStudentList);
                        Console.WriteLine("NAME:\t\t\tADDRESS:\tPROGRAM\t\t\tYEAR\tTUITION\t\tFINAL SCORE:\n" +
                            "============================================================================================");
                        foreach (var item in studentList)
                        {
                            Console.WriteLine($"{item.ToString()}\n");
                        }
                        break;

                    case 2:
                        archivedStudentList.Sort();
                        studentList.Sort();
                        Console.WriteLine("NAME:\t\t\tADDRESS:\tPROGRAM\t\t\tYEAR\tTUITION\t\tFINAL SCORE:\n" +
                            "============================================================================================");
                        foreach (var aitem in archivedStudentList)
                        {
                            Console.WriteLine($"{aitem.ToString()}\n");
                        }
                        foreach (var item in studentList)
                        {
                            Console.WriteLine($"{item.ToString()}\n");
                        }
                        break;

                    case 3:
                        bool? yn = null;
                        CRUD crud = new CRUD();
                        Console.WriteLine("");
                        while (yn == null)
                        {
                            Console.WriteLine("Does the student have a final grade? (y/n)");
                            string promptUser = Console.ReadLine();
                            yn = validation.YesNo(promptUser, "Enter a valid response");
                        }
                        if (yn == true)
                        {
                            archivedStudentList = crud.AddStudent(archivedStudentList);
                        }
                        else if (yn == false)
                        {
                            studentList = crud.AddStudent(studentList);
                        }

                        
                        break;

                    case 4:
                        cont = false;
                        break;
                }


            }

            
            
        }

        #region Create List
        static List<Student> StudentList()
        {
            List<Student> studentList = new List<Student>
            {
                new Student("Bob", "Smith", "123 Fake St.", "Computer Science", 2020, 2000.00),
                new Student("Allen", "Smith", "123 Fake St.", "Computer Science", 2020, 2000.00),
                new Student("Darrius", "Smith", "123 Fake St.", "Computer Science", 2020, 2000.00),
                new Student("Shah", "Shahid", "123 Fake St.", "Computer Science", 2020, 2000.00),
                new Student("Billy", "Bob", "123 Fake St.", "Computer Science", 2020, 2000.00),
                new Student("Robert", "Roddy", "123 Fake St.", "Computer Science", 2020, 2000.00),
            };
            return studentList;
        }

        static List<ArchivedStudent> ArchivedStudentList()
        {
            List<ArchivedStudent> archivedStudentList = new List<ArchivedStudent>
            {
                new ArchivedStudent("Helga", "Hufflepuff", "123 Fake St.", "Computer Science", 2020, 2000.00, 90),
                new ArchivedStudent("Ron", "Weasley", "123 Fake St.", "Computer Science", 2020, 2000.00, 50),
                new ArchivedStudent("Draco", "Malfoy", "123 Fake St.", "Computer Science", 2020, 2000.00, 50),
                new ArchivedStudent("Hermione", "Granger", "123 Fake St.", "Computer Science", 2020, 2000.00, 100),
                new ArchivedStudent("Will", "Smith", "123 Fake St.", "Computer Science", 2020, 2000.00, 75),
                new ArchivedStudent("Richard", "Prior", "123 Fake St.", "Computer Science", 2020, 2000.00, 68),
                new ArchivedStudent("Donald", "Glover", "123 Fake St.", "Computer Science", 2020, 2000.00, 89)
            };
            return archivedStudentList;
        }
        #endregion

        static List<Student> SortAlpha(List<Student> studentList, List<ArchivedStudent> archivedStudentList)
        {
            var list = studentList;
            var result2 = archivedStudentList.Where(s => !list.Any(a => a.LastName == s.LastName && a.FirstName == s.FirstName));
            list.AddRange(result2);
            list.Sort();
            return list;
        }

        #region Update Persons
        static List<Person> UpdateStudent(List<Person> personList, string name, string address, string program, int year, double fee)
        {
            var updatedList = personList.FirstOrDefault(s => s.FirstName.Contains(name));
            if(updatedList != null)
            {
                updatedList.FirstName = "";
            }
            return personList;
        }

        static void UpdatePerson(List<Person> personList, string firstName, string lastName, string address, string school, double pay)
        {
            Person staff = new Staff(firstName,lastName, address, school, pay);
            personList.Add(staff);
        }
        #endregion

    }
}
