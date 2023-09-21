using System;

namespace LearningList
{
    abstract class MonHoc
    {
        public string maMon;
        public string tenMon;
        public int soTinChi;

        //Phương thức khởi tạo
        public MonHoc(){
            maMon = "0000";
            tenMon = "Unknown";
            soTinChi = 0;
        }
        public MonHoc(string m, string ten, int stc){
            this.maMon = m;
            this.tenMon = ten;
            this.soTinChi = stc;
        }
        //Phương thức xử lý
        public abstract double DiemKQ();
        public char DiemChu(){
            if (DiemKQ() > 8.5)
                return 'A';
            else
            {
                return 'c';
            }
        }
    }

    class MonHocLyThuyet : MonHoc{
        //Thuộc tính
        public double diemTieuLuan;
        public double diemCuoiKy;

        //phương thức khởi tạo
        public MonHocLyThuyet() : base(){}
        public MonHocLyThuyet(string m, string ten, int stc, double d1, double d2) : base(m, ten, stc){
            diemTieuLuan = d1;
            diemCuoiKy = d2;
        }
        public override double DiemKQ(){
            return diemTieuLuan*0.3 + diemCuoiKy*0.7;
        }
    }
}