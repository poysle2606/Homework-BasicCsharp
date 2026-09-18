using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.Lesson2
{
    #region 1.5.3
    internal class VariableLession
    {
        // Tràn số nguyên
        public static void TranSo()
        {
            int max = 2147483647;
            max = max + 1;
            // số nguyên tràn số, giá trị của max sẽ trở về -2147483648
            // bởi vì kiểu int có giới hạn từ -2147483648 đến 2147483647
            Console.WriteLine("Max int: " + max);
        }

        // Ép kiểu số lớn sang số nhỏ
        public static void EpKieuSoLonSangNho()
        {
            int soLon = 300;
            byte b = (byte)soLon;
            // Giá trị của b sẽ là 44, vì byte chỉ có thể lưu trữ giá trị từ 0 đến 255, Sẽ lấy phần dư của phép chia 300 cho 256, tức là 300 % 256 = 44
            Console.WriteLine("Gia tri cua b: " + b);
        }
    }
    #endregion

    #region 1.6.3
    internal class CamBayEpKieu
    {
        // Ép kiểu số âm sang số nguyên
        public static void EpKieuSoAmSangSoNguyen()
        {
            double soAm = -5.9;
            int soNguyen = (int)soAm;
            Console.WriteLine("Gia tri cua soNguyen: " + soNguyen);
        }

        public static void EpKieuSoLonSangNho()
        {
            int soLon = 300;
            byte b = (byte)soLon;
            // Giá trị của b sẽ là 44, vì byte chỉ có thể lưu trữ giá trị từ 0 đến 255, Sẽ lấy phần dư của phép chia 300 cho 256, tức là 300 % 256 = 44
            Console.WriteLine("Gia tri cua b: " + b);
        }
    }
    #endregion

    #region 1.7.3
    internal class SwapValues()
    {
        public static void Swap()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("trước khi đổi: a = " + a + ", b = " + b);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("sau khi đổi: a = " + a + ", b = " + b);
        }
    }
    #endregion
}
