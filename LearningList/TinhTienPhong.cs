using System

namespace LearningList
{
    abstract class TinhTienPhong
    {
        string maSoPhong;
        int soNguoiO; //Số người ở
        protected double soDien;
        protected double soNuoc;

        public TinhTienPhong(){
            maSoPhong = "0000";
            soNguoiO = 0;
            soDien = 0.0;
            soNguoiO = 0.0;
        }
        public TinhTienPhong(string maso, int songuoio, double sodien, double sonuoc){
            this.maSoPhong = maso;
            this.soNguoiO = songuoio;
            this.soDien = sodien;
            this.soNuoc = sonuoc;
        }
        public abstract int Tien();
    }

    class PhongA : TinhTienPhong
    {
        int SoNguoiThan;

        public PhongA(string maso, int songuoio, double sodien, double sonuoc, int songuoithan) : base(maso, songuoio, sodien, sonuoc){
            this.SoNguoiThan = songuoithan;
        }
        public override double Tien(){
            return 1400 + 2*soDien + 8*soNuoc + 50*SoNguoiThan;
        }
    }
    
    class PhongB : TinhTienPhong
    {
        double giatUi;
        int soMay;

        public override int Tien(){
            return 2000 + 2*soDien + 8*soNuoc + giatUi*5 + soMay*100;
        }
    }
}