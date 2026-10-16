using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.OOP
{
    public class TimesheetModel : BaseEntity
    {
        /// <summary>
        /// ID nhân viên
        /// </summary>
        public string employee_id { get; set; }
        /// <summary>
        /// Công chuẩn
        /// </summary>
        public double work_standard { get; set; }
        /// <summary>
        /// công làm thêm
        /// </summary>
        public double over_time { get; set; }
        /// <summary>
        /// Công ca
        /// </summary>
        public double work_shift { get; set; }
    }
}
