using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCsharp.Lesson5
{
    internal class ArrayAndString
    {
        #region 2.5.4
        public static void SquareMatrix()
        {
            // Khai báo mảng 
            int[][] arrays = { new int[]{1, 2, 3}, new int[]{4, 5, 6}, new int[]{7, 8, 9} };
            // Tính tổng đường chéo 
            
        }
        #endregion

        #region 2.6.4
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi lon:");
            var inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine("Chuoi lon khong hop le.");
                return;
            }

            Console.WriteLine("Nhap chuoi con:");
            var substring = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(substring))
            {
                Console.WriteLine("Chuoi con khong hop le.");
                return;
            }

            DemXuatHien(inputString, substring);
        }

        // Đếm số lần không trùng lặp của chuỗi con trong chuỗi lớn
        public static void DemXuatHien(string chuoiLon, string chuoiCon)
        {
            int count = 0;
            int index = 0;

            while ((index = chuoiLon.IndexOf(chuoiCon, index)) != -1)
            {
                count++;
                index += chuoiCon.Length;
            }
            Console.WriteLine($"Chuoi '{chuoiCon}' xuat hien {count} lan trong chuoi '{chuoiLon}'");
        }
        #endregion
    }
}
