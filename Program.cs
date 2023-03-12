using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Employewage Computation Program");
           // (string Compny, int perHourWage, int workingDay, int maxHour)
            Attendance Tata=new Attendance("Tata",30,24,120);
            Tata.EmployeeWagweCompute();
            Attendance rakuten=new Attendance("Rakuten", 30, 24, 120);
            rakuten.EmployeeWagweCompute();
            Console.WriteLine( Tata.ToString());
            Console.WriteLine(rakuten.ToString());


        }
    }
}
