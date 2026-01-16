using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract  class Employee
    {
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee(string name, string add)
        {
            this.EmpName = name;
            this.Address = add;

        }

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return string.Format("EmpName = {0}, Addres = {1}", EmpName, Address);
        }
    }
}
