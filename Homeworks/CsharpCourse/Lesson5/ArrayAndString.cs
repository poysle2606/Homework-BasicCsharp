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
            int[,] arrays = new int[3,3] { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

            // Khai báo biến
            int n = 3;
            int tongCheoChinh = 0;
            int tongCheoPhu = 0;

            // Tính tổng đường chéo
            for (int i = 0; i < n; i++)
            {
                tongCheoChinh += arrays[i, i];
            }    
            
        }

        //public static void Main(string[] args)
        //{
        //    HasPoint();
        //}

        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y) => (this.x, this.y) = (x,y);
        }

        public static void HasPoint()
        {
            Point a = new Point(2, 3);
            Point b = a;
            b.x = 5;
            Console.WriteLine("toa do: " + b.x);
        }

        #endregion

        #region 2.6.4
        //public static void Mains(string[] args)
        //{
        //    Console.WriteLine("Nhap chuoi lon:");
        //    var inputString = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(inputString))
        //    {
        //        Console.WriteLine("Chuoi lon khong hop le.");
        //        return;
        //    }

        //    Console.WriteLine("Nhap chuoi con:");
        //    var substring = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(substring))
        //    {
        //        Console.WriteLine("Chuoi con khong hop le.");
        //        return;
        //    }

        //    DemXuatHien(inputString, substring);
        //}

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
