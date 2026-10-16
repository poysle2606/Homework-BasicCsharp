using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.OOP
{
    public class PartTimeEmployeeModel : EmployeeModel, ICaculateSalary
    {
        /// <summary>
        /// Lương part time = (Công ca + Công OT) × Lương cơ bản theo giờ
        /// </summary>
        public decimal CalculateSalary(TimesheetModel timesheet)
        {
            if (timesheet == null)
                throw new ArgumentNullException("Timesheet không được null");
            if (timesheet.work_shift <= 0)
                throw new ArgumentException("Công ca phải lớn hơn 0");
            if (timesheet.over_time < 0)
                throw new ArgumentException("Công OT không được âm");
            if (salary_standard >= 1000000)
                throw new ArgumentException("Lương cơ bản phải nhỏ hơn 1,000,000");

            return (decimal)(timesheet.work_shift + timesheet.over_time) * salary_standard;
        }
    }
}
