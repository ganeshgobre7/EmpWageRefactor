using System;

namespace EmployeeWageRef
{
    public class calculate
    {
        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck==1)
            {
                Console.WriteLine("Employee is Present");
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
