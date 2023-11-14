using System;

namespace LearningList
{
    class NhanVien{
        // properties
        string maNhanVien, hoTen;
        double heSoLuong;
        int namVaoLam;
        public static int mucLuongToiThieu = 1750000;
        // get - set
        public string MaNV { get {return maNhanVien; } set{maNhanVien = value; } }
        public string HoTen { get {return hoTen; } set {hoTen = value; } }
        public double hsl {
            get {return heSoLuong; }
            set {
                if (value < 0)
                    heSoLuong = 0;
                else
                    heSoLuong = value;
            }
        }
        public int nvl {
            get {return namVaoLam; }
            set {
                if (value < 0)
                    namVaoLam = 0;
                else
                    namVaoLam = value;
            }
        }
        // constructors
        public NhanVien(){
            MaNV = "";
            HoTen = "";
            hsl = 0;
            NVL = 0;
        }
        public NhanVien(string MaNV, string HoTen, double hsl, int nvl){
            this.MaNV = m;
            this.HoTen = ht;
            this.hsl = hsl;
            this.nvl = nvl;
        }
        // Method
        double LuongCoBan(){
            return heSoLuong * mucLuongToiThieu;
        }
        double heSoPhuCapThamNiem(){
            DateTime ngayThang_HienTai = DateTime.Today;
            int namHienTai = ngayThang_HienTai.Year;
            return (namHienTai - namVaoLam)*1.0 / 100;
        }
        double LuongMoiNhanVien(){
            return LuongCoBan() * heSoPhuCapThamNiem();
        }
    }
}