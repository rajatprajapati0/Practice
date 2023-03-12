using System;


namespace EmployeeWage
{
    public class Attendance
    {
        public const int perHourWage = 20;
        public const int fullDayHour = 2;
        public const int halfDayHour = 1;
        public const int workingDay = 20;
        public void  CheckAttendance()
        {
            int emphour = 0;
            int dailywage = 0;
            int monthlyWage = 0;
       
            Random rnd = new Random();

           for (int day=0; day<workingDay;day++)
            {
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
                dailywage = emphour * perHourWage;
                monthlyWage += dailywage;
           }
            Console.WriteLine($"monthly wage :{monthlyWage}");        
        }
    }
}
