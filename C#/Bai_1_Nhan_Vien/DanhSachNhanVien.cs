using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Bai_1_Nhan_Vien
{
    class DanhSachNhanVien
    {
        // properties
        private List<NhanVien> lst;
        public List<NhanVien> dsnv
        {
            get { return lst; }
            set { lst = value; }
        }
        // constructors
        public DanhSachNhanVien()
        {
            lst = new List<NhanVien>();
        }
        public DanhSachNhanVien(List<NhanVien> dsnv)
        {
            this.dsnv = dsnv;
        }
        // methods
        public void NhapDSNV()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int soLuongNV = int.Parse(Console.ReadLine());
            if (soLuongNV < 1)
                Environment.Exit(0);
            for (int i = 0; i < soLuongNV; i++)
            {
                Console.WriteLine("\tNhap thong tin nhan vien thu {0}", i + 1);
                NhanVien nv = new NhanVien();
                nv.Nhap();
                dsnv.Add(nv);
            }
        }
        public void XuatDSNV()
        {
            int i = 0;
            Console.WriteLine("\tDanh sach nhan vien");
            foreach (NhanVien nv in dsnv)
            {
                Console.WriteLine($"Nhan vien thu {i + 1}");
                nv.Xuat();
                i++;
            }
        }
        // Tính tổng lương nhân viên
        public double TongLuong()
        {
            return lst.Sum(k => k.Luong());
        }
        // Tìm thông tin nhân viên có lương cao nhất
        public double maxLuong()
        {
            return lst.Max(k => k.Luong());
        }
        public DanhSachNhanVien dsnvLuongCaoNhat()
        { // Tìm tất cả nhân viên
            double max = maxLuong();
            DanhSachNhanVien ds1 = new DanhSachNhanVien();
            ds1.lst = lst.Where(k => k.Luong() == max).ToList();
            return ds1;
        }
        public NhanVien NVMaxLuong()
        { // Tìm nhân viên đầu tiên
            double max = maxLuong();
            NhanVien a = lst.FirstOrDefault(k => k.Luong() == max);
            return a;
        }
        public DanhSachNhanVien SapXepNhanVienTheoNamVaoLam()
        {
            DanhSachNhanVien ds2 = new DanhSachNhanVien();
            ds2.lst = lst.OrderBy(k => k.nvl).ToList();
            return ds2;
        }
    }
}
