using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_13_03_2024
{
    class NuocGiaiKhat
    {
        string tenhang, donvitinh;
        int soluong;
        float dongia;
        public string Tenhang
        {
          get { return tenhang; }
          set { tenhang = value; }
        }
        public string Donvitinh
        {
          get { return donvitinh; }
          set { donvitinh = value; }
        }
        public int Soluong
        {
          get { return soluong; }
          set { soluong = value; }
        }
        public float Dongia
        {
          get { return dongia; }
          set { dongia = value; }
        }
        public static double VAT = 0.1;
        public NuocGiaiKhat()
        {
            tenhang = "xxx";
            donvitinh = "xxx";
            soluong = 0;
            dongia = 0;
        }
    }
}
