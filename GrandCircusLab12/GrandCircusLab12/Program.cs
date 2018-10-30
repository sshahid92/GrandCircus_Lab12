using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = PersonList();
            AddPerson(personList, "Shah Shahid", "123 fake street", "Computer Science", 2018, 100000);
            UpdatePerson(personList, "Shah", "", "", 1, 1);
            //need to finish the extended challenge for CRUD
        }

        #region Create List
        static List<Person> PersonList()
        {
            List<Person> personList = new List<Person>();
            return personList;
        }
        #endregion

        #region Create Persons
        static void AddPerson(List<Person> personList, string name, string address, string program, int year, double fee)
        {
            Person student = new Student(name: name, address: address, program: program, year: year,fee: fee);
            personList.Add(student);
        }

        static void AddPerson(List<Person> personList, string name, string address, string school, double pay)
        {
            Person staff = new Staff(name: name, address: address, school: school, pay: pay);
            personList.Add(staff);
        }
        #endregion

        #region Update Persons
        static List<Person> UpdatePerson(List<Person> personList, string name, string address, string program, int year, double fee)
        {
            var updatedList = personList.FirstOrDefault(s => s.Name.Contains(name));
            if(updatedList != null)
            {
                updatedList.Name = "cats";
            }
            return personList;
        }

        static void UpdatePerson(List<Person> personList, string name, string address, string school, double pay)
        {
            Person staff = new Staff(name, address, school, pay);
            personList.Add(staff);
        }
        #endregion

    }
}
