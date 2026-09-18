using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.Lesson3
{
    internal class OperatorLession
    {
        //public static void Main(string[] args)
        //{
        //    MayTinhDonGian();
        //}
        #region 1.9.4
        public static void ToanTuDieuKien()
        {
            // Nhập dữ liệu đầu vào
            string input = Console.ReadLine();
            int number = Int32.TryParse(input, out int result) ? result : 0;
            var rs = number > 0 ? "duong" : "am";
            // Ket qua
            Console.WriteLine("So vua nhap la: " + rs);
        }
        #endregion

        #region 1.10.4
        public static void MayTinhDonGian()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            string input1 = Console.ReadLine();
            int number1 = Int32.TryParse(input1, out int result1) ? result1 : 0;
            Console.WriteLine("Nhap so thu hai: ");
            string input2 = Console.ReadLine();
            int number2 = Int32.TryParse(input2, out int result2) ? result2 : 0;
            Console.WriteLine("Chon phep tinh (+, -, *, /): ");
            string phepTinh = Console.ReadLine();
            double ketQua = 0;
            switch (phepTinh)
            {
                case "+":
                    ketQua = number1 + number2;
                    break;
                case "-":
                    ketQua = number1 - number2;
                    break;
                case "*":
                    ketQua = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                        ketQua = (double)number1 / number2;
                    else
                        Console.WriteLine("Khong the chia cho 0!");
                    break;
                default:
                    Console.WriteLine("Phep tinh khong hop le!");
                    break;
            }
            Console.WriteLine("Ket qua: " + ketQua);
        }
        #endregion
    }
}
