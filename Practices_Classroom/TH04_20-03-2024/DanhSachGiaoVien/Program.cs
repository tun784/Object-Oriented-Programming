using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachGiaoVien
{
    class Program
    {
        static void Main(string[] args)
        {
            int sl;
            DanhSachGiaoVien ds = new DanhSachGiaoVien();
            //Console.Write("So luong giao vien: ");
            //sl = int.Parse(Console.ReadLine());
            //ds.NhapDSGV(sl);

            string file = "GiaoVien.xml";
            ds.NhapXML(file);
            ds.XuatDSGV();

            Console.WriteLine("Tong so nhom: {0}",ds.TongSoNhom());

            Console.WriteLine("");
            Console.WriteLine("Danh sach theo ten");
            ds.SapXepTen();
            ds.XuatDSGV();
            Console.WriteLine("");
            Console.WriteLine("Danh sach theo nhom");
            ds.SapXepTheoNhom();
            ds.XuatDSGV();
            Console.WriteLine("");
            Console.WriteLine("Danh sach sau khi loc");
            ds.LocSoNhom();
            ds.XuatDSGV();

            Console.ReadLine();
        }
    }
}
