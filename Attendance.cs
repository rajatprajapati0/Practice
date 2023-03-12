using System;


namespace EmployeeWage
{
    public class Attendance
    {
        public const int fullDayHour = 2;
        public const int halfDayHour = 1;
        public static void EmployeeWagweCompute(string Compny, int perHourWage, int workingDay, int maxHour)
        {
            int emphour = 0;
            int totalEmpHour=0;
            int totalDay = 0;

            while (totalEmpHour < maxHour && totalDay < workingDay)
            {
                totalDay++;
                Random rnd = new Random();
                  int c= rnd.Next(0,3);
                switch (c)
                {
                    case halfDayHour :
                        emphour = 4;
                        break;
                    case fullDayHour :
                        emphour = 8;
                        break;
                    default:
                        emphour = 0;
                        break;
                }
                totalEmpHour = totalEmpHour + emphour;
            }
                int monthlyWage = totalEmpHour * perHourWage;

                Console.WriteLine($"Compny : {Compny} \nmonthly wage of a rendom Employee {Compny} :{monthlyWage}");
        }  
    }           
}
