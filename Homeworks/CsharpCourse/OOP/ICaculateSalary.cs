using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.OOP
{
    internal interface ICaculateSalary
    {
        decimal CalculateSalary(TimesheetModel timesheet);
    }
}
