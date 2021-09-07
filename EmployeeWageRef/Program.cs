using System;

namespace EmployeeWageRef
{
    public class calculate
    {
        int full_Time = 8;
        int per_Hour_Sal = 20;
        int one_Day_Sal = 0;

        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck==1)
            {
                one_Day_Sal = full_Time * per_Hour_Sal;
                Console.WriteLine("Full Time Salary is:" + one_Day_Sal); ;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
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
