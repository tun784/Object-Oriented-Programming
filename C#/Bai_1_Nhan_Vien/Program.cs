using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_1_Nhan_Vien
{
    class Program
    {
        static void Main()
        {
            // Một nhân viên
            //NhanVien NV_a = new NhanVien("402", "Tran Tinh", 2.34, 2010);
            //Console.WriteLine("Luong cua nguoi nay la: {0}", NV_a.Luong());
            // Danh sách nhân viên
            Console.WriteLine("\nThao tac tren danh sach nhan vien!");
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.NhapDSNV();
            Console.WriteLine("\nKET THUC PHAN NHAP LIEU");
            Console.WriteLine("\nXuat danh sach nhan vien");
            ds.XuatDSNV();
            // Tổng lương
            Console.WriteLine("\nTong luong tat ca cac nhan vien trong cong ty la: {0} dong", ds.TongLuong());
            // Tìm 1 nhân viên có lương cao nhất
            Console.WriteLine("\nTim 1 nhan vien co luong cao nhat");
            NhanVien NVmax = ds.NVMaxLuong();
            NVmax.Xuat();
            // Danh sách nhân viên có lương cao nhất
            //Console.WriteLine("\nDanh sach nhan vien co luong cao nhat");
            //DanhSachNhanVien DSmax = ds.dsnvLuongCaoNhat();
            //DSmax.XuatDSNV();
            // Sắp xếp danh sách theo thứ tự tăng dần của năm vào làm
            Console.WriteLine("\nSap xep danh sach theo thu tu tang dan cua nam vao lam");
            DanhSachNhanVien DStangdan = ds.SapXepNhanVienTheoNamVaoLam();
            DStangdan.XuatDSNV();

            Console.ReadLine();
        }
    }
}
