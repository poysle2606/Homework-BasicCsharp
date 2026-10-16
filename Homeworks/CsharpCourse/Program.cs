using BasicCsharp.OOP;

public static class Program
{
    public static void Main(string[] args)
    {
        // Tạo đối tượng employee full time
        List<FullTimeEmployeeModel> employees = new List<FullTimeEmployeeModel>();
        employees.Add(new FullTimeEmployeeModel() { id = "1", code = "EMP001", full_name = "John Doe" }); 

        // Tạo đối tượng PayrollManagement
        PayrollManagement payroll = new PayrollManagement();

    }
}