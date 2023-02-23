using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_xuanthulab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VuKhi sungluc;//khai báo sungluc datatype là VuKhi, value is null
            sungluc = new VuKhi();// tạo trong bộ nhớ obj sungluc bằng toán tử new, VuKhi() method constructor k có tham số
            Console.WriteLine(sungluc.dosatthuong);

            sungluc.ThietLapSatThuong(5);
            //sungluc.TanCong();


            VuKhi sungmay = new VuKhi("Sung may", 15);
            sungluc.TanCong();
            sungmay.TanCong();
        }
    }
}
