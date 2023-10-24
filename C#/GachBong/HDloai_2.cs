using System;

namespace GachBong
{
    class HDloai_2 : HoaDon, HoTro{
        public string loai;
        public string loai01 = "Granite", loai02 = "Ceramic";
        public double khoangCachGiaoHang;
        public double kcgh_1 = 5, kcgh_2 = 15;
        public override double GiamGia(){
            if (khoangCachGiaoHang < kcgh_1)
                return donGia * 0.05;
            else if (khoangCachGiaoHang < kcgh_2)
                return donGia * 0.03;
            else
                return donGia * 0.0;
        }
        public override double HoTroGia(){
            if (loai == loai01)
                return soLuong * 3;
            else
                return soLuong * 5;
        }
    }
}