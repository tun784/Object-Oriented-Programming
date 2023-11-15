using System;

namespace NhanVien
{
    class NhanVien{
        //Thuộc tính
        string MaSo = "------", HoTen = "------", PhongBan = "------";
        double HeSoLuong = 0.0;
        int NamVaoLam = 0;
        public static int MucLuongToiThieu = 1210;
        public string Maso { get{ return MaSo; } set{ MaSo = value; } }
        public string Hoten { get{ return HoTen; } set{ HoTen = value; } }
        public string Phongban { get{ return PhongBan; } set{ PhongBan = value; } }
        public double Hesoluong { get{ return HeSoLuong; } set{ HeSoLuong = value; } }
        public int Namvaolam{ get{ return NamVaoLam; } set{ NamVaoLam = value; } }
        // Constructors
        public NhanVien(){
            Maso = "------";
            Hoten = "------";
            Phongban = "------";
            Hesoluong = 0.0;
            Namvaolam = 0;
        }
        public NhanVien(string Maso, string Hoten, string Phongban, double Hesoluong, int Namvaolam){
            this.Maso = Maso;
            this.Hoten = Hoten;
            this.Phongban = Phongban;
            this.Hesoluong = Hesoluong;
            this.Namvaolam = Namvaolam;
        }
        // Method
        public string XepLoai(){
            if (NamVaoLam > 25)
                return "A";
            else if (NamVaoLam > 22)
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
            return MucLuongToiThieu * HeSoLuong * HeSoThiDua;
        }
    }
}