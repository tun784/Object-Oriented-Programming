using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_39_2001224555_NguyenHoangTuan_2001224551
{
    public class DanhSachMayTinh
    {
        List<MayTinh> dsmt = new List<MayTinh>();
        public void docXML(string file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNodeList nodes = doc.SelectNodes("/Maytinhs/Maytinh");
            foreach (XmlNode node in nodes)
            {
                MayTinh mt = new MayTinh();

                mt.MaMayTinh = node["Ma"].InnerText;
                mt.TenMayTinh = node["Ten"].InnerText;
                mt.NamSanXuat = Convert.ToInt32(node["NamSX"].InnerText);
                mt.MauSac = node["MauSac"].InnerText;
                mt.SoLuong = Convert.ToInt32(node["SoLuong"].InnerText);
                mt.DonGia = Convert.ToDouble(node["DonGia"].InnerText);

                dsmt.Add(mt);
            }
        }

        public List<MayTinh> LietKe()
        {
            List<MayTinh> dsmt2 = new List<MayTinh>();
            dsmt2 = dsmt.Where(t => t.SoLuong > 10).ToList();
            return dsmt2;
        }
        public double TongTien()
        {
            return dsmt.Sum(t => t.TinhTien());
        }
        public int tongMT()
        {
            return dsmt.Count(t => t.NamSanXuat == 2023);
        }

        public void XuatDSMT()
        {
            foreach (MayTinh mt in dsmt)
            {
                mt.Xuat1MT();
            }
        }
        public void XuatDSMT2(List<MayTinh> dsmt2)
        {
            foreach (MayTinh mt in dsmt2)
            {
                mt.Xuat1MT();
            }
        }
        public void XuatTongTien()
        {
            Console.WriteLine("Tong tien tat ca cac may tinh: {0}", TongTien());
        }
        public void XuatTongSoMay()
        {
            Console.WriteLine("Tong so may tinh san xuat vao nam 2023: {0}", tongMT());

        }
    }
}
