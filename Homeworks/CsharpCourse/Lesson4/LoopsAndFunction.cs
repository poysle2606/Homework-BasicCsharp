using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.Lesson4
{
    internal class LoopsAndFunction
    {
        #region 2.1.4
        //public static void Main(string[] args)
        //{
        //    TamGiac();
        //}

        // Hàm 
        public static void TamGiac()
        {
            // Khai báo biến tổng
            int total = 0;
            // Vòng lặp ngoài để in ra các dòng
            for (int i = 1; i <= 5; i++)
            {
                // Khai báo biến tổng trong dòng
                int totalInLine = 0;
                // Vòng lặp trong để in ra các số trong dòng
                for (int j = 1; j <= i; j++)
                {
                    // In ra số j
                    Console.Write(j);
                    // Cộng dồn tổng trong dòng
                    totalInLine += j;

                    // Nếu tổng trong dòng lớn hơn 7 thì dừng vòng lặp trong
                    if (totalInLine > 7)
                        break;
                }
                Console.WriteLine("Tong dong: " + totalInLine);
                // Cộng dồn tổng
                total += totalInLine;
            }
            Console.WriteLine("Tong: " + total);
        }
        #endregion

        #region 2.2.2
        //public static void Main(string[] args)
        //{
        //     Xử dung vòng do while để thực hiện các thao tác với tài khoản
        //    do
        //    {
        //        Console.WriteLine("Bam 1 de nap tien. 2 de rut tien. 3 de xem so du.");
        //        int choice = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        //        if (choice == 1)
        //        {
        //            Console.WriteLine("Nap tien: ");
        //            double soTienNap = double.TryParse(Console.ReadLine(), out double resultNap) ? resultNap : 0;
        //            TaiKhoan.NapTien(soTienNap);
        //        }
        //        else if (choice == 2)
        //        {
        //            Console.WriteLine("Rut tien: ");
        //            double soTienRut = double.TryParse(Console.ReadLine(), out double resultRut) ? resultRut : 0;
        //            TaiKhoan.RutTien(soTienRut);
        //        }
        //        else if (choice == 3)
        //        {
        //            TaiKhoan.XemSoDu();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Lua chon khong hop le.");
        //        }
        //    }
        //    while (true);
        //}

        class TaiKhoan
        {
            // Khai báo số dư tài khoản
            private static double soDu { get; set; }

            // Số tiền nạp vào tài khoản phải lớn hơn 0, nếu không thì in ra thông báo lỗi
            public static bool NapTien(double soTien)
            {
                if (soTien <= 0)
                {
                    Console.WriteLine("So tien nap phai lon hon 0");
                    return false;
                }
                    
                if (soTien > 0)
                {
                    TaiKhoan.soDu += soTien;
                    return true;
                }
                return false;
            }

            // Số tiền rút ra phải lớn hơn 0 và nhỏ hơn hoặc bằng số dư tài khoản, nếu không thì in ra thông báo lỗi
            public static bool RutTien(double soTien)
            {
                if (soTien <= 0)
                {
                    Console.WriteLine("So tien rut phai lon hon 0");
                    return false;
                }

                if (soTien > TaiKhoan.soDu)
                {
                    Console.WriteLine("So tien rut phai nho hon hoac bang so du");
                    return false;
                }

                TaiKhoan.soDu -= soTien;
                return true;
            }

            public static void XemSoDu()
            {
                Console.WriteLine("So du hien tai: " + TaiKhoan.soDu);
            }

        }
        #endregion

        #region 2.3.3
        //public static void Main(string[] args)
        //{
        //    for (int i = 2; i <= 20; i++)
        //    {
        //        if (LaSoNguyenTo(i))
        //        {
        //            int luyThua = LuyThua(i, 2);
        //            Console.WriteLine($"So nguyen to {i} co luy thua 2 = {luyThua}");
        //        }
        //    }
        //}

        // Lũy thừa là phép toán nhân một số với chính nó nhiều lần. Ví dụ: 2^3 = 2 * 2 * 2 = 8
        public static int LuyThua (int x, int y)
        {
            // Khai báo biến kết quả 1 vì bất kỳ số nào lũy thừa 0 đều bằng 1
            int result = 1;
            // Vòng lặp để nhân x với chính nó y lần
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        // Số nguyên tố là số tự nhiên lớn hơn 1 và chỉ chia hết cho 1 và chính nó.
        public static bool LaSoNguyenTo(int n)
        {
            // i < n * n là số nguyên tố ??? Thuật toán kiểm tra 1 số có phải là số nguyên tố


            // Nếu n nhỏ hơn 2 thì không phải số nguyên tố
            if (n < 2)
            {
                return false;
            }

            // Kiểm tra các số từ 2 đến n-1 xem có chia hết cho n không
            for (int i = 2; i < n; i++)
            {
                // Nếu n chia hết cho i thì n không phải số nguyên tố
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
