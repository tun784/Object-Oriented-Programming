using System;

namespace NhanVien
{
    class NhanVien{
        // Properties
        string Ma_So = "------", Ho_Ten = "------", Phong_Ban = "------";
        double He_So_Luong = 0.0;
        int Nam_Vao_Lam = 0;
        public static int MucLuongToiThieu = 1210;
        public string MaSo { get{ return Ma_So; } set{ Ma_So = value; } }
        public string HoTen { get{ return Ho_Ten; } set{ Ho_Ten = value; } }
        public string PhongBan { get{ return Phong_Ban; } set{ Phong_Ban = value; } }
        public double HeSoLuong { get{ return He_So_Luong; } set{ He_So_Luong = value; } }
        public int NamVaoLam{ get{ return Nam_Vao_Lam; } set{ Nam_Vao_Lam = value; } }
        // Constructors
        public NhanVien(){
            MaSo = "------";
            HoTen = "------";
            PhongBan = "------";
            HeSoLuong = 0.0;
            NamVaoLam = 0;
        }
        public NhanVien(string MaSo, string HoTen, string PhongBan, double HeSoLuong, int NamVaoLam){
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.PhongBan = PhongBan;
            this.HeSoLuong = HeSoLuong;
            this.NamVaoLam = NamVaoLam;
        }
        // Methods
        public string XepLoai(){
            if (Nam_Vao_Lam > 25)
                return "A";
            else if (Nam_Vao_Lam > 22)
                return "B";
            else
                return "C";
        }
        public virtual double ThuNhap(){
            double HeSoThiDua = 0.0;
            if (XepLoai() == "A")
                HeSoThiDua = 1.00;
            else if (XepLoai() == "B")
                HeSoThiDua = 0.75;
            else
                HeSoThiDua = 0.50;
            return MucLuongToiThieu * He_So_Luong * HeSoThiDua;
        }
    }
}