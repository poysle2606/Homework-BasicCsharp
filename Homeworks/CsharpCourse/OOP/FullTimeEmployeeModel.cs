using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.OOP
{
    public class FullTimeEmployeeModel : EmployeeModel, ICaculateSalary
    {

        /// <summary>
        /// Đơn giá OT
        /// </summary>
        public double unit_ot { get; set; }

        /// <summary>
        /// Tỷ lệ thưởng
        /// </summary>
        public double reward_percent { get; set; }

        /// <summary>
        /// Lương full time = (Lương cơ bản / Công chuẩn) × Công ca + Công OT × Đơn giá OT
        /// </summary>
        public decimal CalculateSalary(TimesheetModel timesheet)
        {
            if (timesheet == null)
                throw new ArgumentNullException("Timesheet không được null");
            if (unit_ot <= 0)
                throw new ArgumentException("Đơn giá OT phải lớn hơn 0");
            if (timesheet.work_shift <= 0)
                throw new ArgumentException("Công ca phải lớn hơn 0");
            if (timesheet.over_time < 0)
                throw new ArgumentException("Công OT không được âm");
            if (timesheet.work_standard <= 0)
                throw new ArgumentException("Công chuẩn phải lớn hơn 0");
            if (salary_standard <= 1000000)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 1,000,000");

            return (salary_standard / (decimal)timesheet.work_standard) * (decimal)timesheet.work_shift + (decimal)timesheet.over_time * (decimal)unit_ot;
        }

        /// <summary>
        /// Thưởng = Lương cơ bản × Tỷ lệ thưởng
        /// </summary>
        /// <param name="timesheet"></param>
        public decimal RewardSalary (TimesheetModel timesheet)
        {
            return salary_standard * (decimal)reward_percent;
        }

        /// <summary>
        /// Tổng thu nhập = Lương theo công + Thưởng
        /// </summary>
        public override decimal TotalIncome()
        {
            return CalculateSalary(new TimesheetModel()) + RewardSalary(new TimesheetModel());
        }
    }
}
