using System;

namespace GachBong
{
    class HDngoaiNhap : HoaDon{
        public string noiSanXuat;
        public int chatLuong;
        public static double thueNhapKhau = 0.05;
        protected string NSX1 == "Italia", NSX2 == "Japan";
        protected int loai1 = 1, loai2 = 2, loai3 = 3;
        public override double GiamGia(){
            if (noiSanXuat == NSX1 || noiSanXuat == NSX2)
                return 0.0;
            else if (chatLuong == loai1)
                return 0.03;
            else if (chatLuong == loai2)
                return 0.02;
            else
                return 0.0;
        }
    }
}