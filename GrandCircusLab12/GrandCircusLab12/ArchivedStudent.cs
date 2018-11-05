using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class ArchivedStudent : Student
    {
        public int FinalScore { get; set; }

        public ArchivedStudent(string firstName, string lastName, string address, string program, int year, double fee,
                    int finalScore) : base(firstName, lastName, address, program, year, fee)
        {
            FinalScore = finalScore;
        }
                
        public override string ToString()
        {
            string studentDataSheet = $"{FinalScore, 6}";
            return base.ToString() + studentDataSheet;
        }

        public override int CompareTo(ArchivedStudent other)
        {
            if (FinalScore == other.FinalScore)
            {
                int result = LastName.CompareTo(other.LastName);
                if (FinalScore == other.FinalScore)
                {
                    int result2 = FirstName.CompareTo(other.FirstName);
                    return result2;
                }
                return result;
            }
            return FinalScore.CompareTo(other.FinalScore);
        }
    }
}
