using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private double basic;

        public double Basic
        {
            get { return basic; }
            set
            {
                if (value < 5000)
                {
                    throw new MinimumBasicException("Minimum basic 5000");
                }
               basic = value;
                
            }
        }

        public ConfirmEmployee(string name, string add, string desig, double sal) : base(name, add)
        {
            this.Designation = desig;
            this.Basic = sal;
        }

        public sealed  override double CalculateSalary()
        {
            double hra, conv, pf, netsal;
            if (Basic > 30000)
            {
                hra = Basic * .30;
                conv = Basic * .30;
                pf = Basic * .10;
            }
            else if (Basic > 20000)
            {
                hra = Basic * .20;
                conv = Basic * .20;
                pf = Basic * .10;
            }
            else 
            {
                hra = Basic * .10;
                conv = Basic * .10;
                pf = Basic * .10;
            }
            return netsal = Basic + hra + conv - pf;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Designame = {0} Basic = {1} \nNetSalary = {2}", Designation, Basic, CalculateSalary());
        }
    }
}
