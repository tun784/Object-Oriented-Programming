using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachGiaoVien
{
    public class GiaoVien
    {
        string hoTen;
        int soNhomHuongDan;
        public int SoNhomHuongDan
        {
            get { return soNhomHuongDan; }
            set { soNhomHuongDan = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public GiaoVien()
        {

        }

        public void Nhap1GV()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so nhom huong dan: ");
            soNhomHuongDan = int.Parse(Console.ReadLine());
        }
        public void Xuat1GV()
        {
            Console.WriteLine("Ho ten: {0} - So Nhom huong dan: {1}", hoTen, soNhomHuongDan);
        }
    }
}
