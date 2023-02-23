using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    internal class SinhVien
    {
        //private string masv;
        //private string hoten;
        //private float diemTB;
        //public string MaSV { get => masv; set => masv = value; }
        //public string HoTen { get => hoten; set =>hoten = value; }
        //public float DiemTB { get => diemTB;set => diemTB = value; }

        //public void NhapTT()
        //{
        //    Console.WriteLine("Nhap ma SV: ");
        //    masv= Console.ReadLine();
        //    Console.WriteLine("Nhap ho ten sv: ");
        //    hoten= Console.ReadLine();
        //    Console.WriteLine("Nhap dien TB: ");
        //    diemTB = float.Parse( Console.ReadLine());
        //    Console.WriteLine("");
        //}

        private string masv;
        private string hoten;
        private float diemTB;

        public string MaSV { get => masv; set => masv = value;}
        public string HoTen { get =>hoten; set=> hoten = value; }
        public float  DiemTB { get => diemTB; set=> diemTB = value; }

        public void NhapTT()
        {
            Console.WriteLine("nhap masv: ");
            masv= Console.ReadLine();
            Console.WriteLine("nhap ten sv: ");
            hoten= Console.ReadLine();
            Console.WriteLine("nhap diem tb: ");
            diemTB= float.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
    }

}
