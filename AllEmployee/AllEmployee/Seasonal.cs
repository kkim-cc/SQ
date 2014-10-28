using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllEmployee
{
    enum Seasons
    {
        Spring,
        Summer,
        Fall,
        Winter
    }
    public class SeasonalEmployee : Employee
    {
        private double piecePay;
        private Seasons season;

        public SeasonalEmployee() { }
        public SeasonalEmployee(string FN, string LN, int SIN, DateTime DOB,
            Seasons SS, double PP)
            : base(FN, LN, SIN, DOB)
        {
            // need to verify
            piecePay = PP;
            season = SS;
        }
        public Seasons Season
        {
            get { return season; }
            set { season = value; }
        }
        public double PiecePay
        {
            get { return piecePay; }
            set { piecePay = value; }
        }
        //public bool ValidateSeason() { }
    }
}
