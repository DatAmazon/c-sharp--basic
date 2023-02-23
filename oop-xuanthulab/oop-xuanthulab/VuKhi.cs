using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_xuanthulab
{
    internal class VuKhi
    {
        //dữ liệu
        string name = "sung luc";
        public int dosatthuong = 0;

        //thuoc tinh
        public int satThuong
        {
            get { return 10; }
            set { }
        }


        public VuKhi()
        {
            Console.WriteLine("hello constructor");
            dosatthuong = 2;
        }

        public VuKhi(string name, int dst)
        {
            this.name = name;
            this.dosatthuong = dst;
        }

        public void ThietLapSatThuong(int dst)
        {
            dosatthuong = dst;
        }

        public void TanCong()
        {
            Console.WriteLine(this.name + ": \t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
