using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachHocVien ds = new DanhSachHocVien();
            ds.Nhap();
            ds.Xuat();
            //ds.TimKiemTheoKhoangDiem();
            //ds.TimKiemTheoHocLuc();
            //ds.TimVaCapNhatTheoMa();
            //ds.Xuat();

            ds.SapXepTheoDiem();
            ds.Xuat();

            ds.HienThiTop5();

            Console.Read(); // dung man hinh
        }
    }
}
