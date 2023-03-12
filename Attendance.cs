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

        static int emphour = 0;
        static int totalEmpHour = 0;
        static int monthlyWage = 0;
        static int totalDay = 0;

        public static int GetWorkingHopur(int rnd) 
        {
            switch (rnd)
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
             return emphour;
        }

        public static void ComputEmployeeWage() 
        {
            while (totalEmpHour < maxHour && totalDay < workingDay)
            {
                totalDay++;
                Random rnd = new Random();

                int random =GetWorkingHopur( rnd.Next(0,3));

                totalEmpHour = totalEmpHour+random;
            }
            monthlyWage = totalEmpHour * perHourWage;

            Console.WriteLine($"monthly wage :{monthlyWage}");
        }
    }
       
    
}
