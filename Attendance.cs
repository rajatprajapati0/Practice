using System;


namespace EmployeeWage
{
    public class Attendance
    {
        public void  CheckAttendance()
        {
            int perHourWage = 20;
            int perDayHour = 8;
            Random rnd = new Random();
            int check= rnd.Next(0,2);
    
            if (check == 0) 
            {
                Console.WriteLine("employee is not present");
            }
            else
            {
                Console.WriteLine($"employee is present \ndaily wage of employee is {perHourWage*perDayHour}");
            }
        }
    }
}
