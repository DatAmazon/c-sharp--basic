using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QLSinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap vao n sinh vien: ");
            //int n = int.Parse(Console.ReadLine());
            //sinhvien[] a = new sinhvien[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Nhap thong tin sv thu " + (i + 1));
            //    a[i] = new sinhvien();
            //    a[i].NhapTT();

            //}

            //sinhvien tb;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (a[i].DiemTB < a[j].DiemTB)
            //        {
            //            tb = a[i];
            //            a[i] = a[j];
            //            a[j] = tb;
            //        }
            //    }
            //}

            //Console.WriteLine("Xap xep theo diem trung binh giam dan");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("\n MaSV: {0} | Ho ten: {1} | Diem TB: {2}", a[i].MaSV, a[i].HoTen, a[i].DiemTB);
            //}

            //Console.WriteLine("-----------------------------------");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("\n MaSV: {0} | Ho ten: {1} | Diem TB: {2}", a[i].MaSV, a[i].HoTen, a[i].DiemTB);
            //}

            Console.WriteLine("So luong sinh vien la: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] a = new SinhVien[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu: "+ (i +1));
                a[i] = new SinhVien();
                a[i].NhapTT();
            }

            SinhVien tb;
            for(int i= 0; i< n; i++)
            {
                for(int j = i+1; j< n; j++)
                {
                    if (a[i].DiemTB < a[j].DiemTB)
                    {
                        tb = a[i];
                        a[i] = a[j];
                        a[j] = tb;
                    }
                }
            }

            Console.WriteLine("Sap xep theo diem trung binh giam dan: ");
            for( int i = 0; i<n; i++)
            {
                Console.WriteLine("Ten " + a[i].HoTen + "/t DiemTB: " + a[i].DiemTB);
            }

            Console.WriteLine("Hien 3 sv co diem cao nhat");
            for( int i = 0; i<3; i++)
            {
                Console.WriteLine("Ten " + a[i].HoTen + "/t DiemTB: " + a[i].DiemTB);
            }


        }


    }
}
