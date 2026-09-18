using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.Lesson1
{
    #region 1.2.2
    internal class LessionBegin
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Da cai dat moi truong C# thanh cong!");
        //    Console.ReadKey();
        //}
    }
    #endregion

    #region 1.3.2
    class PhanBietComment
    {
        //static void Main(string[] args)
        //{
        //    // Đây là tên viết thường
        //    string name = "Nguyen Van A";
        //    /* Đây là tên viết hoa 
        //     * định danh khác nhau
        //     */
        //    string NAME = "NGUYEN VAN A";

        //    Console.WriteLine("Lower name: " + name);
        //    Console.WriteLine("Upper name: " + NAME);
        //}
    }
    #endregion

    #region 1.4.2
    class HinhTron
    {
        // Khai báo bán kính
        public static double banKinh { get; set; }

        // Tính diện tích hình tròn
        public static double TinhDienTich()
        {
            return banKinh * banKinh * 3.14;
        }

        // Tính chu vi hình tròn
        public static double TinhChuVi()
        {
            return 2 * banKinh * 3.14;
        }

        // Hàm hiển thị kết quả
        public static void Display()
        {
            /* Hai định danh tên Hợp lệ */
            var dienTich = HinhTron.TinhDienTich();
            var chuVi = HinhTron.TinhChuVi();

            /* Hai định danh tên không hợp lệ
             * var 1dienTich = HinhTron.TinhDienTich();
             * var DIEN_TICH = HinhTron.TinhDienTich();
            */

            Console.WriteLine($"Dien tich: {dienTich}, Chu vi: {chuVi}");
        }
    }

    class TinhDienTich
    {
        //static void Main(string[] args)
        //{
        //    var banKinh = double.Parse(Console.ReadLine());
        //    HinhTron.BanKinh = banKinh;
        //    Console.WriteLine("Ban kinh hinh tron: " + HinhTron.BanKinh);
        //    HinhTron.Display();
        //    Console.ReadKey();
        //}
    }
    #endregion
}
