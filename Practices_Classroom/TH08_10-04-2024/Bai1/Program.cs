using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "..//..//BDS.xml";
            DanhSachBDS dsbds = new DanhSachBDS();
            dsbds.NhapXML(file);
            Console.WriteLine("tong gia tri cua tat ca bat dong san: {0} dong", dsbds.TongGiaTri());
            dsbds.XuatDS();
            Console.ReadLine();
        }
    }
}
