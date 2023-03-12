using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Employewage Computation Program");
           // (string Compny, int perHourWage, int workingDay, int maxHour)
            Attendance.EmployeeWagweCompute("Tata",30,24,120);

            Attendance.EmployeeWagweCompute("Rakuten", 30, 24, 120);
        }
    }
}
