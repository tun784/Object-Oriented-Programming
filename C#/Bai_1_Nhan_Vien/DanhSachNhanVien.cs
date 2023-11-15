using System;
namespace Bai_1_Nhan_Vien
{
    class DanhSachNhanVien
    {
        // properties
        private List<NhanVien> lst;
        public List<NhanVien> dsnv {
            get { return lst; }
            set { lst = value; }
        }
        // constructors
        public DanhSachNhanVien() {
            lst = new List<NhanVien>();
        }
        public DanhSachNhanVien(List<NhanVien> dsnv) {
            this.dsnv = dsnv;
        }
        // methods
        public void NhapDSNV(){
            System.Console.Write("Nhap so luong nhan vien: ");
            int soLuongNV = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < soLuongNV; i++) {
                System.Console.WriteLine("\tNhap thong tin nhan vien");
                NhanVien nv = new NhanVien();
                nv.Nhap();
                dsnv.Add(nv);
            }
        }
        public void XuatDSNV(){
            System.Console.WriteLine("\tDanh sach nhan vien:");
            foreach (NhanVien nv in dsnv){
                nv.Xuat();
            }
        }
        // Tính tổng lương nhân viên
        public double TongLuong(){
            return lst.Sum(k => k.Luong());
        }
        // Tìm thông tin nhân viên có lương cao nhất
        public double maxLuong(){
            return lst.Max(k => k.Luong());
        }
        public DanhSachNhanVien dsnvLuongCaoNhat() { // Tìm tất cả nhân viên
            double max = maxLuong();
            DanhSachNhanVien ds1 = new DanhSachNhanVien();
            ds1.lst = lst.Where(k => k.Luong() == max).ToList();
            return ds1;
        }
        public NhanVien NVMaxLuong(){ // Tìm nhân viên đầu tiên
            double max = maxLuong();
            NhanVien a = lst.FirstOrDefault(k => k.Luong() == max);
            return a;
        }
        public DanhSachNhanVien SapXepNhanVienTheoNamVaoLam(){
            DanhSachNhanVien ds2 = new DanhSachNhanVien();
            ds2.lst = lst.OrderBy(k => k.nvl).ToList();
            return ds2;
        }
    }
}