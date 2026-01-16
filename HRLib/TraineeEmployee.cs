using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class TraineeEmployee : Employee
    {
        private int noOfDays;

        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public TraineeEmployee(string name, string add, int days, double rate) : base (name, add)
        {
            this.NoOfDays = days;
            this.Rate = rate;
        }

        public override double CalculateSalary()
        {
            return NoOfDays * Rate;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" No of Days = {0} Rate = {1} \nNetSalary = {2}", NoOfDays, Rate, CalculateSalary());
        }
    }
}
