using System;

namespace CaFe
{
    class CaFeXayNC : CaFe, HoTro
    {
        public double CongXay(){
            double congxay = 100 * soLuong;
            if (soLuong >= 100)
                congxay = 95 * soLuong;
            return congxay;
        }
        public override double ThanhTien(){
            return soLuong * donGia + CongXay();
        }
        public double TinhKinhPhiHoTro(){
            return soLuong * 12;
        }
    }
}