using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployee
{
    abstract public class Employee
    {
        private string  firstName;
        private string lastName;
        private int socialInsuranceNumber;
        private DateTime dateOfBirth;

        public Employee() { }
        public Employee(string FN, string LN, int SIN, DateTime DOB)
        {
            // need to verify the parameters
            firstName = FN;
            lastName = LN;
            socialInsuranceNumber = SIN;
            dateOfBirth = DOB;
        }
        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                // need to verify...
                firstName = value; 
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                // need to verify...
                lastName = value;
            }
        }
        public int SocialInsuranceNumber
        {
            get { return socialInsuranceNumber; }
            set
            {
                // need to verify...
                socialInsuranceNumber = value;
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                // need to verify...
                dateOfBirth = value;
            }
        }
    }
}
