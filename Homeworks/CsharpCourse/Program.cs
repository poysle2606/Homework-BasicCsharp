using BasicCsharp.OOP;
using Newtonsoft.Json;
using System.IO;
using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Tạo đối tượng employee full time
        List<FullTimeEmployeeModel> fulltimeEmployees = new List<FullTimeEmployeeModel>();
        // Tạo đối tượng employee part time
        List<PartTimeEmployeeModel> parttimeEmployees = new List<PartTimeEmployeeModel>();
        // Tạo đối tượng PayrollManagement
        PayrollManagement payroll = new PayrollManagement();
        // Tạo đối tượng chấm công
        List<TimesheetModel> timesheets = new List<TimesheetModel>();

        #region Khai báo dữ liệu mẫu static
        //// List nhân viên full time
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "1", code = "NV01", full_name = "Nguyễn Văn An", type_position = EmployeeType.FullTime, salary_standard = 13000000, unit_ot = 65000, reward_percent = 10 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "3", code = "NV03", full_name = "Lê Văn Chi", type_position = EmployeeType.FullTime, salary_standard = 15600000, unit_ot = 75000, reward_percent = 5 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "5", code = "NV05", full_name = "Hoàng Minh Em", type_position = EmployeeType.FullTime, salary_standard = 10400000, unit_ot = 50000 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "7", code = "NV07", full_name = "Lê Thu Giang", type_position = EmployeeType.FullTime, salary_standard = 18200000, unit_ot = 90000, reward_percent = 7.5 });
        fulltimeEmployees.Add(new FullTimeEmployeeModel() { id = "9", code = "NV09", full_name = "Ngô Minh Khang", type_position = EmployeeType.FullTime, salary_standard = 11700000, unit_ot = 60000, reward_percent = 2.5 });

        // List nhân viên part time
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "2", code = "NV02", full_name = "Trần Thị Bình", type_position = EmployeeType.PartTime, salary_standard = 50000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "4", code = "NV04", full_name = "Phạm Quốc Dũng", type_position = EmployeeType.PartTime, salary_standard = 55000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "6", code = "NV06", full_name = "Võ Thị Phương", type_position = EmployeeType.PartTime, salary_standard = 48000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "8", code = "NV08", full_name = "Đỗ Thị Hạnh", type_position = EmployeeType.PartTime, salary_standard = 60000 });
        parttimeEmployees.Add(new PartTimeEmployeeModel() { id = "10", code = "NV10", full_name = "Bùi Ngọc Linh", type_position = EmployeeType.PartTime, salary_standard = 45000 });

        timesheets.Add(new TimesheetModel() { employee_id = "1", work_standard = 26, over_time = 8, work_shift = 24 });
        timesheets.Add(new TimesheetModel() { employee_id = "2", work_standard = 26, over_time = 5, work_shift = 10 });
        timesheets.Add(new TimesheetModel() { employee_id = "3", work_standard = 26, over_time = 2, work_shift = 25 });
        timesheets.Add(new TimesheetModel() { employee_id = "4", work_standard = 26, over_time = 4, work_shift = 12 });
        timesheets.Add(new TimesheetModel() { employee_id = "5", work_standard = 26, over_time = 0, work_shift = 22 });
        timesheets.Add(new TimesheetModel() { employee_id = "6", work_standard = 26, over_time = 2, work_shift = 14.5 });
        timesheets.Add(new TimesheetModel() { employee_id = "7", work_standard = 26, over_time = 3.5, work_shift = 26 });
        timesheets.Add(new TimesheetModel() { employee_id = "8", work_standard = 26, over_time = 3, work_shift = 8 });
        timesheets.Add(new TimesheetModel() { employee_id = "9", work_standard = 26, over_time = 6, work_shift = 23.5 });
        timesheets.Add(new TimesheetModel() { employee_id = "10", work_standard = 26, over_time = 3, work_shift = 16 });

        //payroll.employees_fulltime.AddRange(fulltimeEmployees);
        //payroll.employees_parttime.AddRange(parttimeEmployees);
        //payroll.timesheets.AddRange(timesheets);
        #endregion

        #region Khai báo dữ liệu từ file JSON
        // Khai báo đường dẫn tuyệt đối
        string filePathEmployeeFulltime = "C:\\Works\\Teaching_DotNet\\Homework-BasicCsharp\\Homeworks\\CsharpCourse\\employees_fulltime.json";
        string filePathEmployeeParttime = "C:\\Works\\Teaching_DotNet\\Homework-BasicCsharp\\Homeworks\\CsharpCourse\\employees_parttime.json";
        string filePathDataTimesheet = "C:\\Works\\Teaching_DotNet\\Homework-BasicCsharp\\Homeworks\\CsharpCourse\\data_timesheets.json";

        // Chuyển dữ liệu danh sách thành chuỗi JSON
        // Formatting.Indented giúp JSON được ghi ra file có xuống dòng và thụt lề để dễ đọc hơn
        string jsonEmployeeFulltime = JsonConvert.SerializeObject(fulltimeEmployees, Formatting.Indented);
        string jsonEmployeeParttime = JsonConvert.SerializeObject(parttimeEmployees, Formatting.Indented);
        string jsonDataTimesheet = JsonConvert.SerializeObject(timesheets, Formatting.Indented);

        // Ghi dữ liệu vào file JSON, dùng WriteAllText để ghi đè dữ liệu vào file nếu file đã tồn tại
        File.WriteAllText(filePathEmployeeFulltime, jsonEmployeeFulltime);
        File.WriteAllText(filePathEmployeeParttime, jsonEmployeeParttime);
        File.WriteAllText(filePathDataTimesheet, jsonDataTimesheet);

        // Đọc dữ liệu từ file JSON
        var jsonDataEmployeeFulltime = File.ReadAllText(filePathEmployeeFulltime);
        var jsonDataEmployeeParttime = File.ReadAllText(filePathEmployeeParttime);
        var jsonDataDataTimesheet = File.ReadAllText(filePathDataTimesheet);
        var payrollDataFulltime = JsonConvert.DeserializeObject<List<FullTimeEmployeeModel>>(jsonDataEmployeeFulltime);
        var payrollDataParttime = JsonConvert.DeserializeObject<List<PartTimeEmployeeModel>>(jsonDataEmployeeParttime);
        var payrollDataTimesheet = JsonConvert.DeserializeObject<List<TimesheetModel>>(jsonDataDataTimesheet);

        if (payrollDataFulltime == null)
        {
            Console.WriteLine("Không thể đọc dữ liệu full-time từ file JSON.");
            return;
        }

        if (payrollDataParttime == null)
        {
            Console.WriteLine("Không thể đọc dữ liệu part-time từ file JSON.");
            return;
        }

        if (payrollDataTimesheet == null)
        {
            Console.WriteLine("Không thể đọc dữ liệu timesheets từ file JSON.");
            return;
        }

        payroll.employees_parttime.AddRange(payrollDataParttime);
        payroll.timesheets.AddRange(payrollDataTimesheet);
        payroll.employees_fulltime.AddRange(payrollDataFulltime);
        #endregion

        // Kiểm tra dữ liệu được nạp từ payroll
        if (payroll.employees_fulltime.Count == 0)
        {
            Console.WriteLine("Danh sách nhân viên full-time trống.");
            return;
        }

        if (payroll.employees_parttime.Count == 0)
        {
            Console.WriteLine("Danh sách nhân viên part-time trống.");
            return;
        }

        if (payroll.timesheets.Count == 0)
        {
            Console.WriteLine("Danh sách chấm công trống.");
            return;
        }

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