using System

namespace LearningList
{
    abstract class TinhTienPhong
    {
        string maSoPhong;
        int soNguoiO; //Số người ở
        protected double soDien;
        protected double soNuoc;
        // get - set
        public string maso { get { return maSoPhong; } set{ maSoPhong = value; } }
        public int sNguoi { get{ return soNguoiO; } set{ soNguoiO = value; } }
        public double sDien { get{ return soDien; } set{ soDien = value;} }
        public double sNuoc { get{ return soNuoc; } set{ soNuoc = value; } }
        // Phương thức khởi tạo
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
        // Phương thức trừu tượng
        public abstract int Tien();
    }
    class PhongA : TinhTienPhong
    {
        int SoNguoiThan;
        // get - set
        public int nguoithan { get{ return SoNguoiThan; } set{ SoNguoiThan = value; } }
        // Phương thức khởi tạo
        public PhongA() : base(){
            SoNguoiThan = 0;
        }
        public PhongA(string maso, int songuoio, double sodien, double sonuoc, int songuoithan) : base(maso, songuoio, sodien, sonuoc){
            this.SoNguoiThan = songuoithan;
        }
        // Phương thức xử lý
        public override double Tien(){
            return 1400 + 2*soDien + 8*soNuoc + 50*SoNguoiThan;
        }
    }
    class PhongB : TinhTienPhong
    {
        double giatUi;
        int soMay;
        // get - set
        public double giatui { get{ return giatUi; } set{ giatUi = value; } }
        public int somay { get{ return soMay; } set{ soMay = value; } }
        //Phương thức khởi tạo
        public PhongB() : base(){
            giatUi = 0.0;
            soMay = 0;
        }
        public PhongA(string maso, int songuoio, double sodien, double sonuoc, double giatUi, int soMay) : base(maso, songuoio, sodien, sonuoc){
            this.giatUi = giatUi;
            this.soMay = soMay;
        }
        // Phương thức xử lý
        public override int Tien(){
            return 2000 + 2*soDien + 8*soNuoc + giatUi*5 + soMay*100;
        }
    }
}