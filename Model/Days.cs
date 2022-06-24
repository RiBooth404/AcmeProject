using System;
namespace AcmeProject.Model
{
    [Flags]
    public enum Days
    {
        None = 0b_0000_0000,  // 0
        MO = 0b_0000_0001,  // 1
        TU = 0b_0000_0010,  // 2
        WE = 0b_0000_0100,  // 4
        TH = 0b_0000_1000,  // 8
        FR = 0b_0001_0000,  // 16
        SA = 0b_0010_0000,  // 32
        SU = 0b_0100_0000,  // 64
    }
}