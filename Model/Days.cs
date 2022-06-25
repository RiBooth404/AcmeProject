using System;
namespace AcmeProject.Model
{
    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,  
        MO = 0b_0000_0001, 
        TU = 0b_0000_0010, 
        WE = 0b_0000_0100, 
        TH = 0b_0000_1000, 
        FR = 0b_0001_0000,  
        SA = 0b_0010_0000, 
        SU = 0b_0100_0000,  
    }
}