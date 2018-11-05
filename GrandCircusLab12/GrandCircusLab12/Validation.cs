using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Validation
    {
        private readonly string _nameRegex = @"^[A-Za-z]{1,30}$";
        private readonly string _addressRegex = @"^\d{1,5}\s([A-Za-z]{1,20})(\s\w{1,7})|(\.{1})$";
        private readonly string _programRegex = @"^[A-Za-z]{1,20}|\s[A-Za-z]{1,20}$";
        private readonly int _currentYear = DateTime.Now.Year;
        private readonly int _maxYear = 9999;
        private readonly double _minTuition = 0;
        private readonly double _maxTuition = 300000;
        private readonly int _minScore = 0;
        private readonly int _maxScore = 100;

        public Validation()
        {

        }

        public string ValidateName(string input)
        {
            bool validate = Regex.IsMatch(input, _nameRegex);
            if (validate)
            {
                string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                return titleCase;
            }
            else
            {
                Console.WriteLine("Please enter a valid name.\n" +
                    "First and last names are limited to 30 characters.");
                return "notValid";
            }
        }

        public string ValidateAddress(string input)
        {
            bool validate = Regex.IsMatch(input, _addressRegex);
            if (validate)
            {
                string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                return titleCase;
            }
            else
            {
                Console.WriteLine("Please enter a valid address.\n");
                return "notValid";
            }
        }

        public string ValidateProgram(string input)
        {
            bool validate = Regex.IsMatch(input, _programRegex);
            if (validate)
            {
                string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
                return titleCase;
            }
            else
            {
                Console.WriteLine("Please enter a valid address.\n");
                return "notValid";
            }
        }

        public bool ValidateYear(int input)
        {
            
            bool validate = input >= _currentYear && input <= _maxYear;
            if (validate)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid year greater than or equal to the current year.\n");
                return false;
            }
        }

        public bool ValidateTuition(double input)
        {

            bool validate = input > _minTuition && input <= _maxTuition;
            if (validate)
            {
                return true;
            }
            else if (input > _maxTuition)
            {
                Console.WriteLine("That's just cruel! Try again!");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
                return false;
            }
        }

        public bool ValidateScore(int input)
        {

            bool validate = input >= _minScore && input <= _maxScore;
            if (validate)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid score between 0-100.");
                return false;
            }
        }

        public bool ValidteMenuSelection(int input)
        {
            if (input > 0 && input < 5)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid response.");
                return false;
            }
        }

        public bool? YesNo(string input, string nullMessage)
        {
            switch (input)
            {
                case "yes":
                case "y":
                    return true;

                case "no":
                case "n":
                    return false;


                default:
                    Console.WriteLine(nullMessage);
                    return null;
            }
        }
    }
}
