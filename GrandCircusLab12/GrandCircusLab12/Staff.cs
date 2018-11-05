using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Staff : Person
    {
        
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff(string firstName, string lastName, string address,
            string school, double pay) : base (firstName, lastName, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            string staffDataSheet = $"{School}\t" +
                                    $"{Pay}\t";
            return base.ToString() + staffDataSheet;
        }

    }
}
