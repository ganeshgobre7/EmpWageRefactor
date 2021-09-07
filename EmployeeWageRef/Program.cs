using System;

namespace EmployeeWageRef
{
    public class calculate
    {
        int full_Time = 8;
        int part_Time = 4;
        int per_Hour_Sal = 20;
        int no_Work_Days = 20;
        int total_Sal = 0;
        int one_Day_Sal = 0;

        public void monthlyWage(int one_Day_sal,int no_Work_Days)
        {
            total_Sal = no_Work_Days * one_Day_sal;
            Console.WriteLine("Total Salaru of 20 Days in Months :" + total_Sal);
        }

        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case 1:

                    one_Day_Sal = full_Time * per_Hour_Sal;
                    Console.WriteLine("Full Time Salary is:" + one_Day_Sal);
                    monthlyWage(one_Day_Sal,no_Work_Days);
                    break;

                case 2:
                    one_Day_Sal = part_Time * per_Hour_Sal;
                    Console.WriteLine("Part Time Salary is:" + one_Day_Sal);
                    monthlyWage(one_Day_Sal, no_Work_Days);
                    break;

                default:
                    Console.WriteLine("Wrong Input!!Please run the code once again");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Employee Wage Computation Program With OOPS");
            calculate cal = new calculate();
            cal.check();
        }
    }
}
