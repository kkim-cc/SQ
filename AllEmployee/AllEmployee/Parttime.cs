using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployee
{
    public class ParttimeEmployee : Employee
    {
        private DateTime dateOfHire;
        private DateTime dateOfTermination;
        private double hourlyRate;

        public ParttimeEmployee() { }
        public ParttimeEmployee(string FN, string LN, int SIN, DateTime DOB,
            DateTime DOH, DateTime DOT, double HR)
            : base(FN, LN, SIN, DOB)
        {
            dateOfHire = DOH;
            dateOfTermination = DOT;
            hourlyRate = HR;
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
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
    }
}
