using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BasicCsharp.OOP
{
    public abstract class EmployeeModel : BaseEntity
    {
        public string id { get; set; }
        public string full_name { get; set; }
        public string code { get; set; }

        /// <summary>
        /// Lương cơ bản
        /// </summary>
        public decimal salary_standard { get; set; }
        /// <summary>
        /// Vị trí công việc: 1 - Full-time, 2 - Part-time
        /// </summary>
        public EmployeeType type_position { get; set; } = EmployeeType.FullTime;

        public abstract decimal TotalIncome();

    }

    public enum EmployeeType
    {
        [Display(Name = "Full-time")]
        FullTime = 1,
        [Display(Name = "Part-time")]
        PartTime = 2
    }
}
