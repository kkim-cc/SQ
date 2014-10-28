using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployee
{
    public class FulltimeEmployee : Employee
    {
        private DateTime dateOfHire;
        private DateTime dateOfTermination;
        private double salary;

        public FulltimeEmployee() { }
        public FulltimeEmployee(string FN, string LN, int SIN, DateTime DOB,
            DateTime DOH, DateTime DOT, double SL)
            : base(FN, LN, SIN, DOB)
        {
            dateOfHire = DOH;
            dateOfTermination = DOT;
            salary = SL;
        }
        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }
        public DateTime DateOfTermination
        {
            get { return dateOfTermination; }
            set { dateOfTermination = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
