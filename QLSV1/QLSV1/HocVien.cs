using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class HocVien
    {
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public float Diem { get; set; }
        public string Email { get; set; }

        public HocVien() { }

        public HocVien(string ma, string hoten, float diem, string email)
        {
            this.Ma = ma;
            this.HoTen = hoten;
            this.Diem = diem;
            this.Email = email;
        }

        public string GetHocLuc()
        {
            string hocluc = "Xuat xac";
            if (Diem >= 8)
            {
                hocluc = "Hoc luc gioi";
            }
            else if (Diem >= 6.5 && Diem < 8)
            {
                hocluc = "Hoc luc kha";
            }
            else
            {
                hocluc = "Hoc luc yeu";
            }
            return hocluc;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin hoc vien: ");
            Console.Write("Ma: ");
            Ma = Console.ReadLine();
            Console.Write("Ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Diem: ");
            Diem = float.Parse(Console.ReadLine());
            Console.Write("Email: ");
            Email = Console.ReadLine();

        }
        public void Xuat()
        {
            Console.WriteLine($"Ma: {Ma} - Ten: {HoTen} - Email: {Email} -Diem: {Diem} - Hoc luc: {GetHocLuc()}");
        }

    }
}
