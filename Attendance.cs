using System;


namespace EmployeeWage
{
    public class Attendance
    {
        public void  CheckAttendance()
        {
            int perHourWage = 20;
            int fullDayHour = 8;
            int halfDayHour = 4;
            Random rnd = new Random();
            int check= rnd.Next(0,3);
    
            if (check == 0) 
            {
                Console.WriteLine("employee is not present");
            }
            if (check == 1)
            {
                Console.WriteLine($"employee is present for half day\ndaily wage of employee is {perHourWage*halfDayHour}");
            }
            else
            {
                Console.WriteLine($"employee is present for half day\ndaily wage of employee is {perHourWage*fullDayHour}");
            }
        }
    }
}
