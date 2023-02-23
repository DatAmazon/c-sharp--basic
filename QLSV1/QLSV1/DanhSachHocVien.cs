using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class DanhSachHocVien
    {
        private List<HocVien> list = new List<HocVien>();
        public void Nhap()
        {
            do
            {
                HocVien hv = new HocVien();
                hv.Nhap();

                list.Add(hv);
                Console.WriteLine("Ban co muon nhap nua khong? (y/n): ");
                string st = Console.ReadLine();
                if (st.Equals("n", StringComparison.OrdinalIgnoreCase))// so sanh khong phan biet chu hoa chu thuong
                {
                    break;
                }

            }
            while (true);
        }
        public void Xuat()
        {
            foreach (var item in list)
            {
                item.Xuat();
            }
        }

        public void TimKiemTheoKhoangDiem()
        {
            float min, max;
            Console.WriteLine("Nhap khoang nho nhat: ");
            min = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap khoang lon nhat: ");
            max = float.Parse(Console.ReadLine());

            Console.WriteLine($"Thong tin cac hoc vien nam co diem nam trong khoang {min} va {max} la: ");
            foreach (var item in list)
            {
                if (item.Diem >= min && item.Diem <= max)
                {
                    item.Xuat();
                }
            }

        }
        public void TimKiemTheoHocLuc()
        {
            Console.WriteLine("Nhap luc hoc can tim");
            string hocLuc = Console.ReadLine();

            foreach (var item in list)
            {
                if (item.GetHocLuc().Equals(hocLuc, StringComparison.OrdinalIgnoreCase))
                {
                    item.Xuat();
                }
            }
        }

        public void TimVaCapNhatTheoMa()
        {
            Console.WriteLine("Nhap ma can tim: ");
            string ma = Console.ReadLine();

            foreach (var item in list)
            {
                if (item.Ma == ma)
                {
                    item.Nhap();
                    break;
                }
            }
        }

        public void SapXepTheoDiem()
        {
            list.Sort((a, b) => (int)(a.Diem - b.Diem));
        }

        public void HienThiTop5()
        {
            list.Sort((a, b) => (int)(a.Diem - b.Diem));
            for (int i = 0; i < 5 && i < list.Count; i++)
            {
                list[i].Xuat();
            }
        }
    }
}
