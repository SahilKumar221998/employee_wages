//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Project
//{
//    public class EmployeeWage
//    {
//        double wage = 0.0;
//        public int present(int maxDays)
//        {
//            Random random = new Random();
//            int present = random.Next(1, maxDays);
//            return present;

//        }
//        public void dailyWages(double maxHoursPerDay, double minWages)
//        {
//            wage = 0.0;
//            wage = maxHoursPerDay * minWages;
//            Console.WriteLine("Your daily wage is " + wage + "rs");
//        }
//        public void monthlyWage(int maxDays, double maxHoursPerDay, double minWages)
//        {
//            wage = 0.0;
//            wage = maxDays * maxHoursPerDay * minWages;
//            Console.WriteLine("Your Monthly wage is" + wage + "rs");
//        }
//        public void tillTheMonth(int maxDays, int minWage)
//        {
//            wage = 0.0;
//            int days = present(maxDays);
//            wage = days * minWage;
//            Console.WriteLine("Your wage is " + wage + "rs");

//        }
//        public void partTimeEmployee(double hours, double wages)
//        {
//            wage = 0.0;
//            wage = hours * wages;
//            Console.WriteLine("Your wage is " + wage + "rs");
//        }
//        public void calculateWages(int maxDays, int maxHoursPerDays, int minWage)
//        {
//            Console.WriteLine("Press For Claculating");
//            Console.WriteLine("1.Present Days\n2.Daily Wage\n3.Monthly Wage\n4.Present Wage");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            switch (choice)
//            {
//                case 1: Console.WriteLine(present(maxDays)); break;
//                case 2: dailyWages(maxHoursPerDays, minWage); break;
//                case 3: monthlyWage(maxDays, maxHoursPerDays, minWage); break;
//                case 4: tillTheMonth(maxDays, minWage); break;
//                default: Console.WriteLine("Invalid choice"); break;
//            }
//        }
//        public void company()
//        {
//            Console.WriteLine("Select which company Presenty You are Working In :-");
//            Console.WriteLine("1.Lytax India\n2.Infosys\n3.Google\n4.Accenture\n5.Wizergos");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Hii!!Press\n 1:For Regular Employee\n2:For Part Time Employee");
//            int employeeType = Convert.ToInt32(Console.ReadLine());
//            switch (employeeType)
//            {
//                case 1:
//                    switch (choice)
//                    {
//                        case 1: calculateWages(24, 6, 30); break;
//                        case 2: calculateWages(20, 6, 25); break;
//                        case 3: calculateWages(26, 8, 50); break;
//                        case 4: calculateWages(28, 10, 35); break;
//                        case 5: calculateWages(3, 7, 20); break;
//                        default: Console.WriteLine("Invalid Choice"); break;

//                    }
//                    break;
//                case 2:
//                    switch (choice)
//                    {
//                        case 1: partTimeEmployee(6, 25); break;
//                        case 2: partTimeEmployee(6, 25); break;
//                        case 3: partTimeEmployee(6, 25); break;
//                        case 4: partTimeEmployee(6, 25); break;
//                        case 5: partTimeEmployee(6, 25); break;
//                        default: Console.WriteLine("Invalid choice"); break;
//                    }
//                    break;
//            }

//        }
//        static void Main(string[] args)
//        {
//            EmployeeWage employeeWage = new EmployeeWage();
//            Console.WriteLine("_________Welcome to Employee Wage Computation Program On Master Branch__________");
//            employeeWage.company();

//        }
//    }
//}
