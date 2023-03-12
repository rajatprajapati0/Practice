using System;


namespace EmployeeWage
{
    public class Attendance
    {
        public const int perHourWage = 20;
        public const int fullDayHour = 2;
        public const int halfDayHour = 1;
        public const int workingDay = 20;
        public const int maxHour = 100;
     
        public void  CheckAttendance()
        {
            int emphour = 0;
            int totalEmpHour = 0;
            int monthlyWage = 0;
            int totalDay = 0;
           
       
            Random rnd = new Random();
            while (totalEmpHour <= maxHour&&totalDay<workingDay)
            {
                totalDay++;
                int check = rnd.Next(0, 3);

                switch (check)
                {
                    case halfDayHour:
                        emphour = 4;
                        break;
                    case fullDayHour:
                        emphour = 8;
                        break;
                    default:
                        emphour = 0;
                        break;

                }
                totalEmpHour += emphour;
                
            }
            monthlyWage =  totalEmpHour*perHourWage;

            Console.WriteLine($"monthly wage :{monthlyWage}");        
        }
    }
}
