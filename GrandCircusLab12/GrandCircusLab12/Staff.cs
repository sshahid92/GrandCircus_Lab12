using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Staff : Person
    {
        
        private string _school { get; set; }
        private double _pay { get; set; }

        public Staff(string name, string address,
            string school, double pay) : base (name, address)
        {
            _school = school;
            _pay = pay;
        }

        public override string ToString()
        {
            string staffDataSheet = $"School: {_school}\n" +
                                    $"Pay: {_pay}\n";
            return base.ToString() + staffDataSheet;
        }


    }
}
