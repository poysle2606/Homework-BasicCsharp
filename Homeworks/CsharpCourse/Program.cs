using BasicCsharp.OOP;

public static class Program
{
    public static void Main(string[] args)
    {
        // Tạo đối tượng employee full time
        List<FullTimeEmployeeModel> fulltimeEmployees = new List<FullTimeEmployeeModel>();
        // List nhân viên full time
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "1", code = "NV01", full_name = "Nguyễn Văn An", type_position = EmployeeType.FullTime, salary_standard = 13000000, unit_ot = 65000, reward_percent = 10 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "3", code = "NV03", full_name = "Lê Văn Chi", type_position = EmployeeType.FullTime, salary_standard = 15600000, unit_ot = 75000, reward_percent = 5 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "5", code = "NV05", full_name = "Hoàng Minh Em", type_position = EmployeeType.FullTime, salary_standard = 10400000, unit_ot = 50000 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "7", code = "NV07", full_name = "Lê Thu Giang", type_position = EmployeeType.FullTime, salary_standard = 18200000, unit_ot = 90000, reward_percent = 7.5 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "9", code = "NV09", full_name = "Ngô Minh Khang", type_position = EmployeeType.FullTime, salary_standard = 11700000, unit_ot = 60000, reward_percent = 2.5 });

        // List nhân viên part time
        List<PartTimeEmployeeModel> parttimeEmployees = new List<PartTimeEmployeeModel>();
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "2", code = "NV02", full_name = "Trần Thị Bình", type_position = EmployeeType.PartTime, salary_standard = 50000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "4", code = "NV04", full_name = "Phạm Quốc Dũng", type_position = EmployeeType.PartTime, salary_standard = 55000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "6", code = "NV06", full_name = "Võ Thị Phương", type_position = EmployeeType.PartTime, salary_standard = 48000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "8", code = "NV08", full_name = "Đỗ Thị Hạnh", type_position = EmployeeType.PartTime, salary_standard = 60000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "10", code = "NV10", full_name = "Bùi Ngọc Linh", type_position = EmployeeType.PartTime, salary_standard = 45000 });

        // Tạo đối tượng PayrollManagement
        PayrollManagement payroll = new PayrollManagement();
        payroll.employees_fulltime.AddRange(fulltimeEmployees);
        payroll.employees_parttime.AddRange(parttimeEmployees);

        // Tạo đối tượng chấm công
        List<TimesheetModel> timesheets = new List<TimesheetModel>();
        timesheets.Add(new TimesheetModel() { employee_id = "1", work_standard = 26, over_time = 8, work_shift= 24 });
        timesheets.Add(new TimesheetModel() { employee_id = "2", work_standard = 26, over_time = 5, work_shift= 10 });
        timesheets.Add(new TimesheetModel() { employee_id = "3", work_standard = 26, over_time = 2, work_shift= 25 });
        timesheets.Add(new TimesheetModel() { employee_id = "4", work_standard = 26, over_time = 4, work_shift= 12 });
        timesheets.Add(new TimesheetModel() { employee_id = "5", work_standard = 26, over_time = 0, work_shift= 22 });
        timesheets.Add(new TimesheetModel() { employee_id = "6", work_standard = 26, over_time = 2, work_shift= 14.5 });
        timesheets.Add(new TimesheetModel() { employee_id = "7", work_standard = 26, over_time = 3.5, work_shift= 26 });
        timesheets.Add(new TimesheetModel() { employee_id = "8", work_standard = 26, over_time = 3, work_shift= 8 });
        timesheets.Add(new TimesheetModel() { employee_id = "9", work_standard = 26, over_time = 6, work_shift= 23.5 });
        timesheets.Add(new TimesheetModel() { employee_id = "10", work_standard = 26, over_time = 3, work_shift= 16 });
        payroll.timesheets.AddRange(timesheets);

        // Khai báo biến tổng quỹ lương
        decimal totalPayroll = 0;
        // Khai báo tổng số nhân viên fulltime & parttime
        int totalFulltimeEmployees = payroll.employees_fulltime.Count;
        int totalParttimeEmployees = payroll.employees_parttime.Count;
        // Khai báo tổng thu nhập fulltime & parttime
        decimal totalFulltimeIncome = 0;
        decimal totalParttimeIncome = 0;

        // Thêm thông tin chấm công vào từng nhân viên

        foreach (var employee in payroll.employees_fulltime)
        {
            var timesheet = payroll.timesheets.FirstOrDefault(t =>
              t.employee_id == employee.id);

            if (timesheet == null)
            {
                Console.WriteLine(
                  $"Không tìm thấy chấm công cho nhân viên Full-time: {employee.code}");
                return;
            }

            var salary = employee.CalculateSalary(timesheet);
            var bonus = employee.RewardSalary(timesheet);
            var totalIncome = salary + bonus;

            totalFulltimeIncome += totalIncome;
            totalPayroll += totalIncome;

            Console.WriteLine($"\n===== NHÂN VIÊN FULL-TIME: {employee.code} =====");
            Console.WriteLine($"Họ tên             : {employee.full_name}");
            Console.WriteLine($"Lương theo công    : {salary:N0} đ");
            Console.WriteLine($"Tiền thưởng        : {bonus:N0} đ");
            Console.WriteLine($"Tổng thu nhập      : {totalIncome:N0} đ");
        }

        foreach (var employee in payroll.employees_parttime)
        {
            var timesheet = payroll.timesheets.FirstOrDefault(t =>
              t.employee_id == employee.id);

            if (timesheet == null)
            {
                Console.WriteLine(
                  $"Không tìm thấy chấm công cho nhân viên Part-time: {employee.code}");
                return;
            }

            var salary = employee.CalculateSalary(timesheet);

            totalParttimeIncome += salary;
            totalPayroll += salary;

            Console.WriteLine($"\n===== NHÂN VIÊN PART-TIME: {employee.code} =====");
            Console.WriteLine($"Họ tên             : {employee.full_name}");
            Console.WriteLine($"Lương theo công    : {salary:N0} đ");
            Console.WriteLine($"Tiền thưởng        : {0:N0} đ");
            Console.WriteLine($"Tổng thu nhập      : {salary:N0} đ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("==============================================");
        Console.WriteLine("             TỔNG KẾT BẢNG LƯƠNG");
        Console.WriteLine("==============================================");
        Console.WriteLine($"Số nhân viên Full-time   : {totalFulltimeEmployees}");
        Console.WriteLine($"Số nhân viên Part-time   : {totalParttimeEmployees}");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"Tổng thu nhập Full-time  : {totalFulltimeIncome:N0} đ");
        Console.WriteLine($"Tổng thu nhập Part-time  : {totalParttimeIncome:N0} đ");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine($"TỔNG QUỸ LƯƠNG           : {totalPayroll:N0} đ");
        Console.WriteLine("==============================================");

    }
}