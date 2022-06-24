using System.Globalization;
using System.Collections.Generic;
using System;
using AcmeProject.Model;
namespace AcmeProject.Services
{
    public static class Wrapper
    {
        public static Employee TextToEmployee(string value)
        {

            if ((value.Length - value.Replace("=", "").Length) > 1)
            {
                return null;
            }
            int days = 0;
            String[] valores = value.Split("=");
            for (int i = 0; i < 7; i++)
            {
                int dayId = (int)Math.Pow(2, i);
                if (valores[1].Contains($"{(Days)dayId}"))
                {
                    valores[1] = valores[1].Replace($"{(Days)dayId}".Trim(), $"{dayId}=").Replace(":", "");
                    days += dayId;
                }
            }

            Dictionary<Days, int[]> workingSchedule = new Dictionary<Days, int[]>();

            foreach (string day in valores[1].Split(","))
            {
                string[] schedule = day.Split("=");
                int[] sRange = new int[] { int.Parse(schedule[1].Split("-")[0]), int.Parse(schedule[1].Split("-")[1]) };
                workingSchedule.Add((Days)int.Parse(schedule[0]), sRange);
            }
            Employee employee = new Employee()
            {
                Name = valores[0],
                Days = (Byte)days,
                WorkingSchedule = workingSchedule
            };

            return employee;
        }
        public static List<Employee> TextToEmployee(string[] values)
        {
            List<Employee> EmployeesList = new List<Employee>();
            foreach (string value in values)
            {
                EmployeesList.Add(TextToEmployee(value));
            }
            return EmployeesList;
        }

        public static List<Employee> TextFileToEmployee(string filePath)
        {
            string[] lines = new String[] { };
            lines = System.IO.File.ReadAllLines(filePath);
            return TextToEmployee(lines);
        }
    }
}