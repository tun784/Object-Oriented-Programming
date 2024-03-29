using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_39_2001224555_NguyenHoangTuan_2001224551
{
    public class MayTinh
    {
        private string maMayTinh, tenMayTinh, mauSac;
        private int namSanXuat, soLuong;
        private double donGia;

        public string MaMayTinh
        {
            get { return maMayTinh; }
            set {
                if (value.Count() == 4 && value.StartsWith("MT"))
                    maMayTinh = value;
                else
                    maMayTinh = "MH01";
            }
        }

        public string TenMayTinh
        {
            get { return tenMayTinh; }
            set { tenMayTinh = value; }
        }

        public string MauSac
        {
            get { return mauSac; }
            set { mauSac = value; }
        }

        public int NamSanXuat
        {
            get { return namSanXuat; }
            set { namSanXuat = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public MayTinh()
        {
            maMayTinh = "";
            tenMayTinh = "";
            namSanXuat = 2000;
            mauSac = "Den";
            soLuong = 0;
            donGia = 0.0;
        }
        public MayTinh(string ma, string ten, int nsx, string mausac, int sl, double dongia)
        {
            MaMayTinh = ma;
            TenMayTinh = ten;
            NamSanXuat = nsx;
            MauSac = mausac;
            SoLuong = sl;
            DonGia = dongia;
        }

        public double TinhTien()
        {
            return donGia * (double)soLuong;
        }
        public void Xuat1MT()
        {
            Console.WriteLine("Ma may: {0,-5}\tTen: {1,-10}\tNSX: {2,-5}\t Mau: {3, -5}\tSL: {4, -3}\tDon gia: {5, -7}\tTong tien 1 may tinh: {6, -7}", maMayTinh, tenMayTinh, namSanXuat, mauSac, soLuong, donGia, TinhTien());
        }

    }
}
