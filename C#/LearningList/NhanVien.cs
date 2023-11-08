using System

namespace LearningList
{
    class NhanVien{
        //Thuộc tính
        string ms, ten, pb;
        double hsl;
        int nvl;
        public static int MLTT = 1210;
        public string MaSo { get{ return ms; } set{ ms = value; } }
        public string HoTen { get{ return ten; } set{ ten = value; } }
        public int HeSoLuong { get{ return hsl; } set{ hsl = value; } }
        public string PhongBan { get{ return pb; } set{ pb = value; } }
        public int NgayLamViec { get{ return nvl; } set{ nvl = value; } }
        //Phước thức xử lý
        public string XepLoai(){
            if (nvl > 25)
                return "A";
            else if (nvl > 22)
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
            return MLTT * hsl * HeSoThiDua;
        }
    }
}