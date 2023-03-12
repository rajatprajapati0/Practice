using System;


namespace EmployeeWage
{
    public class Attendance
    {
        public const int fullDayHour = 2;
        public const int halfDayHour = 1;

      private  string Company;
      private  int perHourWage;
      private  int workingDay;
      private  int maxHour;
        private int monthlyWage;
        private int totalEmpHour = 0;

        public Attendance(string Company, int perHourWage, int workingDay, int maxHour)
        {
            this.Company = Company;
            this.maxHour = maxHour;
            this.workingDay = workingDay;   
            this.perHourWage = perHourWage;
            

        }
        public void EmployeeWagweCompute()
        {
            int emphour = 0;
            int totalDay = 0;

            while (this.totalEmpHour < this.maxHour && totalDay < this.workingDay)
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
                this.totalEmpHour = this.totalEmpHour + emphour;
            }
                this.monthlyWage = totalEmpHour * this.perHourWage;
                Console.WriteLine($"Total workingDay{totalDay} Total employee Hours :{totalEmpHour}");
                Console.WriteLine($"Compny : {this.Company} \nmonthly wage of a rendom Employee {this.Company} :{this.monthlyWage}");
        }  
        public string ToString() 
        {
              return  
                  @$" 
                    +----------------------------------------------------------------------+
                    |Compny: {this.Company}                                               
                    +----------------------------------------------------------------------+                                   
                    |{this.Company} : {this.monthlyWage} 
                    |Total Hour : {this.totalEmpHour}
                    +----------------------------------------------------------------------+
                  ";

        }

    }           
}
