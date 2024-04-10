using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            string file = "..//..//NhanVien.xml";
            dsnv.NhapDSNV(file);
            dsnv.XuatDSNV();
            Console.ReadLine();
        }
    }
}
