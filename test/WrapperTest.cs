using System.Collections.Generic;
using AcmeProject.Model;
using AcmeProject.Services;
using Xunit;
public class WrapperTest
{
    [Fact]
    public void PassingOneEmployeeTextToObjectTest()
    {
        string input = "RENE=MO10:00-12:00,SA14:00-18:00,SU20:00- 21:00";
        Dictionary<Days, int[]> dExample = new Dictionary<Days, int[]>();
        dExample.Add(Days.MO, new int[] { 1000, 1200 });
        dExample.Add(Days.SA, new int[] { 1400, 1800 });
        dExample.Add(Days.SU, new int[] { 2000, 2100 });
        Employee example = new Employee()
        {
            Name = "RENE",
            Days = (byte)(Days.MO | Days.SA | Days.SU),
            WorkingSchedule = dExample
        };
        Employee inputEmployee = Wrapper.TextToEmployee(input);
        Assert.Equal( example.ToString(),inputEmployee.ToString());

    }
    [Fact]
    public void PassingEmployeeListTextToObjectListTest()
    {
        string[] input = new string[] { "RENE=MO10:00-12:00,SA14:00-18:00,SU20:00- 21:00", "MARIA=SA16:00-18:00,SU21:30- 22:30" };
        Dictionary<Days, int[]> dExample = new Dictionary<Days, int[]>();
        dExample.Add(Days.MO, new int[] { 1000, 1200 });
        dExample.Add(Days.SA, new int[] { 1400, 1800 });
        dExample.Add(Days.SU, new int[] { 2000, 2100 });
        Dictionary<Days, int[]> dExample2 = new Dictionary<Days, int[]>();
        dExample2.Add(Days.SA, new int[] { 1600, 1800 });
        dExample2.Add(Days.SU, new int[] { 2130, 2230 });
        Employee example = new Employee()
        {
            Name = "RENE",
            Days = (byte)(Days.MO | Days.SA | Days.SU),
            WorkingSchedule = dExample
        };
        Employee example2 = new Employee()
        {
            Name = "MARIA",
            Days = (byte)(Days.SA | Days.SU),
            WorkingSchedule = dExample2
        };

        List<Employee> exampleList = new List<Employee>() { example, example2 };
        List<Employee> inputEmployee = Wrapper.TextToEmployee(input);
        for (int i = 0; i < exampleList.Count; i++)
        {
            Assert.Equal(exampleList[i].ToString(), inputEmployee[i].ToString());
        }
    }

    [Fact]
    public void PassingEmployeeTextFileToObjectListTest()
    {
        string input = "test/Datasets/EmployeeTest.txt";
        Dictionary<Days, int[]> dExample = new Dictionary<Days, int[]>();
        dExample.Add(Days.MO, new int[] { 1000, 1200 });
        dExample.Add(Days.SA, new int[] { 1400, 1800 });
        dExample.Add(Days.SU, new int[] { 2000, 2100 });
        Dictionary<Days, int[]> dExample2 = new Dictionary<Days, int[]>();
        dExample2.Add(Days.SA, new int[] { 1600, 1800 });
        dExample2.Add(Days.SU, new int[] { 2130, 2230 });
        Employee example = new Employee()
        {
            Name = "RENE",
            Days = (byte)(Days.MO | Days.SA | Days.SU),
            WorkingSchedule = dExample
        };
        Employee example2 = new Employee()
        {
            Name = "MARIA",
            Days = (byte)(Days.SA | Days.SU),
            WorkingSchedule = dExample2
        };

        List<Employee> exampleList = new List<Employee>() { example, example2 };
        List<Employee> inputEmployee = Wrapper.TextFileToEmployee(input);
        for (int i = 0; i < exampleList.Count; i++)
        {
            Assert.Equal(exampleList[i].ToString(), inputEmployee[i].ToString());
        }
    }
    
}
