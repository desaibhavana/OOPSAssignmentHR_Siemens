using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "y";
            int choice = 0;
            List<Employee> empList = new List<Employee>();
            do
            {
                Console.WriteLine("1 Display All employee");
                Console.WriteLine("2 Insert Confirm Employee");
                Console.WriteLine("3 Insert Trainee Employee");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        foreach (Employee item in empList)
                        {
                            Console.WriteLine(item + "\n");
                        }
                        Console.WriteLine("----------------------------");
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Address");
                            string add = Console.ReadLine();
                            Console.WriteLine("Enter Desig");
                            string desig = Console.ReadLine();
                            Console.WriteLine("Enter Basic sal > 5000");
                            double basic = double.Parse(Console.ReadLine());

                            ConfirmEmployee emp = new ConfirmEmployee(name, add, desig, basic);
                            empList.Add(emp);
                        }
                        catch (MinimumBasicException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch(Exception  ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                      
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Address");
                            string add = Console.ReadLine();
                            Console.WriteLine("Enter No of days");
                            int days = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter rate");
                            double rate = double.Parse(Console.ReadLine());

                            TraineeEmployee trainee = new TraineeEmployee(name, add, days, rate);
                            empList.Add(trainee);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
                Console.WriteLine("Do you want to continue Y / N ");
                ans = Console.ReadLine();

            } while (ans.ToUpper() == "Y");

   
        }
    }
}
