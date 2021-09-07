using System;

namespace EmployeeWageRef
{
    // class to calculate monthly wage
    public class calculate
    {
        //declaring variables
        int full_Time = 8;
        int part_Time = 4;
        int per_Hour_Sal = 20;
        int no_Work_Days = 20;
        int total_Sal = 0;
        int one_Day_Sal = 0;
        int total_Work_Hours = 0;

        public void monthlyWage(int one_Day_sal,int no_Work_Days) // method for calculate monthly wage
        {
            total_Sal = no_Work_Days * one_Day_sal;
            Console.WriteLine("Total Salary of 20 Days in Months :" + total_Sal);
        }
        public void hoursDays(int work_Hours,int no_work_Days) // work hours and days condition method
        {
            if (work_Hours > 100 || no_Work_Days>=20)
            {
                Console.WriteLine("Working Hours : {0} ", work_Hours);
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        
        public void check()   // method to generate the logic for switch case declare random function 
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)  // switch case logic
            {
                case 1:

                    one_Day_Sal = full_Time * per_Hour_Sal;
                    Console.WriteLine("Full Time Salary is:" + one_Day_Sal);
                    total_Work_Hours = no_Work_Days * full_Time;
                    monthlyWage(one_Day_Sal,no_Work_Days);
                    hoursDays(total_Work_Hours, no_Work_Days);
                    break;

                case 2:
                    one_Day_Sal = part_Time * per_Hour_Sal;
                    Console.WriteLine("Part Time Salary is:" + one_Day_Sal);
                    total_Work_Hours = no_Work_Days * part_Time;
                    monthlyWage(one_Day_Sal, no_Work_Days);
                    hoursDays(total_Work_Hours, no_Work_Days);
                    break;

                default:
                    Console.WriteLine("Wrong Input!!Please run the code once again");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args) //main method 
        {
            Console.WriteLine("WelCome to Employee Wage Computation Program With OOPS");
            calculate cal = new calculate(); //creating object  of calculate class
            cal.check();      // calling method(check)
        }
    }
}
