using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.OOP
{
    public class PayrollManagement
    {
        // Danh sách nhân viên
        public List<FullTimeEmployeeModel> employees_fulltime { get; set; } = new();
        public List<PartTimeEmployeeModel> employees_parttime { get; set; } = new();
        // Danh sách bảng chấm công
        public List<TimesheetModel> timesheets { get; set; } = new();

        // Thêm nhân viên vào danh sách
        public void AddEmployee(EmployeeModel employee, double unitOt, double rewardPercent)
        {
            if (employee.type_position == EmployeeType.FullTime && employees_fulltime.Any(x => x.code == employee.code))
                throw new ArgumentException($"Mã nhân viên {employee.code} đã tồn tại.");

            if (employee.type_position == EmployeeType.PartTime && employees_parttime.Any(x => x.code == employee.code))
                throw new ArgumentException($"Mã nhân viên {employee.code} đã tồn tại.");

            if (employee.salary_standard <= 0)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 0.");

            if (employee.type_position is EmployeeType.FullTime &&
                (unitOt < 0 || rewardPercent < 0))
                throw new ArgumentException(
                  "Đơn giá OT và tỷ lệ thưởng không được âm.");

            if (employee.type_position == EmployeeType.FullTime)
                employees_fulltime.Add((FullTimeEmployeeModel)employee);
            else if (employee.type_position == EmployeeType.PartTime)
                employees_parttime.Add((PartTimeEmployeeModel)employee);
        }

        // Thêm bảng chấm công cho nhân viên
        public void AddTimesheet(TimesheetModel timesheet)
        {
            // Tìm nhân viên theo mã nhân viên
            var employeeFulltime = employees_fulltime.FirstOrDefault(x => x.code == timesheet.employee_id);
            var employeeParttime = employees_parttime.FirstOrDefault(x => x.code == timesheet.employee_id);
            if (employeeFulltime == null && employeeParttime == null)
                throw new ArgumentException($"Nhân viên không tồn tại.");

            if (timesheets.Any(x => x.employee_id == timesheet.employee_id))
                throw new ArgumentException($"Bảng chấm công cho nhân viên {employeeFulltime?.full_name ?? employeeParttime?.full_name} đã tồn tại.");
            if (timesheet.work_shift < 0 || timesheet.over_time < 0 || timesheet.work_standard < 0)
                throw new ArgumentException($"Nhân viên {employeeFulltime?.full_name ?? employeeParttime?.full_name}: Các giá trị công ca, công OT và công chuẩn phải lớn hơn 0.");
            if (timesheet.work_standard == 0)
                throw new ArgumentException($"Nhân viên {employeeFulltime?.full_name ?? employeeParttime?.full_name}: Công chuẩn phải lớn hơn 0.");

            timesheets.Add(timesheet);
        }

    }
}
