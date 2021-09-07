using System;

namespace EmployeeWageRef
{
    public class calculate
    {
        int full_Time = 8;
        int part_Time = 4;
        int per_Hour_Sal = 20;
        int one_Day_Sal = 0;

        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case 1:

                    one_Day_Sal = full_Time * per_Hour_Sal;
                    Console.WriteLine("Full Time Salary is:" + one_Day_Sal);
                    break;

                case 2:
                    one_Day_Sal = part_Time * per_Hour_Sal;
                    Console.WriteLine("Part Time Salary is:" + one_Day_Sal);
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
