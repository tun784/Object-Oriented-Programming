using System;

namespace CaFe
{
    class CaFeHat : CaFe, HoTro
    {
        public override double ThanhTien(){
            return soLuong * donGia;
        }
        public double TinhKinhPhiHoTro(){
            return soLuong * 10;
        }
    }
}