using System;
namespace Bai_1_Nhan_Vien
{
    class Program
    {
        static void Main(){
            // Một nhân viên
            NhanVien NV_a = new NhanVien("402", "Tran Tinh", 2.34, 2010);
            System.Console.WriteLine("Luong cua nguoi nay la: {0}", NV_a.Luong());
            // Danh sách nhân viên
            System.Console.WriteLine("\nThao tac tren danh sach nhan vien!");
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.NhapDSNV();
            ds.XuatDSNV();

            // Tổng lương
            System.Console.WriteLine("\nTong luong tat ca cac nhan vien trong cong ty la: {0}", ds.TongLuong());
            // Tìm 1 nhân viên có lương cao nhất
            NhanVien NVmax = ds.NVMaxLuong();
            NVmax.Xuat();
            // Danh sách nhân viên có lương cao nhất
            DanhSachNhanVien DSmax = ds.dsnvLuongCaoNhat();
            DSmax.XuatDSNV();
            // Sắp xếp danh sách theo năm vào làm
            DanhSachNhanVien DStangdan = ds.SapXepNhanVienTheoNamVaoLam();
            DStangdan.XuatDSNV();
        }
    }
}