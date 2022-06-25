using System.Collections.Generic;
using AcmeProject.Model;
using AcmeProject.Services;
using Xunit;
public class EmployeeTest
{
    
    [Fact]
    public void PassingScheduleCompareTest()
    {
        string[] input = new string[] { "RENE=MO10:00-12:00,SA14:00-18:00,SU20:00- 21:00", "MARIA=SA16:00-18:00,SU21:30- 22:30" };

        List<Employee> inputEmployee = Wrapper.TextToEmployee(input);
        List<string> compareAnswer = Employee.CompareEmployeesSchedule(inputEmployee);
        for (int i = 0; i < compareAnswer.Count; i++)
        {
            Assert.Equal( "RENE-MARIA: 1",compareAnswer[i]);
        }
    }

}