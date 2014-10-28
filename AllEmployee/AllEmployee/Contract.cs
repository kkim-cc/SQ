using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployee
{
    public class ContractEmployee : Employee
    {
        private DateTime contractStartDate;
        private DateTime contractStopDate;
        private double fixedContractAmount;

        public ContractEmployee() { }
        public ContractEmployee(string FN, string LN, int SIN, DateTime DOB,
            DateTime CSD, DateTime CED, double FCA)
            : base(FN, LN, SIN, DOB)
        {
            // need to verify
            contractStartDate = CSD;
            contractStopDate = CED;
            fixedContractAmount = FCA;
        }
        public DateTime ContractStartDate
        {
            get { return contractStartDate; }
            set
            {
                // need to verify...
                contractStartDate = value;
            }
        }
        public DateTime ContractStopDate
        {
            get { return contractStopDate; }
            set
            {
                // need to verify...
                contractStopDate = value;
            }
        }
        public double FixedContractAmount
        {
            get { return fixedContractAmount; }
            set
            {
                // need to verify...
                fixedContractAmount = value;
            }
        }
        public bool ValidateBusinessNumber(int businessNumber)
        {
            bool bRet = true;

            return bRet;
        }
    }
}
