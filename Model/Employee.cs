using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AcmeProject.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public byte Days { get; set; }
        public Dictionary<Days, int[]> WorkingSchedule { get; set; }

        public override string ToString()
        {
            string answer = $"{Name}={(Days)Days}";
            return answer;
        }
        public int CompareSchedule(Employee employee)
        {
            int occurrences = 0;
            byte d = (byte)(employee.Days & this.Days);
            BitArray bits = new BitArray(new[] { (int)d });
            for (int i = 0; i < 7; i++)
            {
                if (bits[i])
                {
                    Days thisDay = (Days)Math.Pow(2, i);
                    bool startsBeforeThisEnds = this.WorkingSchedule[thisDay][1] > employee.WorkingSchedule[thisDay][0];
                    bool finishesBeforeThisStarts = employee.WorkingSchedule[thisDay][1] > this.WorkingSchedule[thisDay][0];
                    occurrences += (startsBeforeThisEnds && finishesBeforeThisStarts) ? 1 : 0;
                }
            }

            return occurrences;
        }
        
        public static List<string> CompareEmployeesSchedule(List<Employee> employees)
        {
            List<string> compareResult = new List<string>();
            List<Employee> supportList = new List<Employee>(employees);
            foreach (Employee e in employees)
            {
                supportList.Remove(e);
                compareResult.AddRange(from Employee e2 in supportList select $"{e.Name}-{e2.Name}: {e.CompareSchedule(e2)}");
            }
            return compareResult;
        }
    }

}
