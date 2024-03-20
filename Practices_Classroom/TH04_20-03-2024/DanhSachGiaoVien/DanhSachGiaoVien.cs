using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace DanhSachGiaoVien
{
    public class DanhSachGiaoVien
    {
        List<GiaoVien> dsgv = new List<GiaoVien>();
        public DanhSachGiaoVien() { }
        public void NhapXML(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList noteList = read.SelectNodes("/DanhSach/GV");
            foreach (XmlNode node in noteList)
            {
                GiaoVien gv = new GiaoVien();
                gv.HoTen = node["HoTen"].InnerText;
                gv.SoNhomHuongDan = int.Parse(node["SoNhom"].InnerText);

                dsgv.Add(gv);
            }
        }
        public void NhapDSGV(int soluong)
        {
            for (int i = 0; i < soluong; i++)
            {
                GiaoVien gv = new GiaoVien();
                gv.Nhap1GV();
                dsgv.Add(gv);
            }
        }
        public void XuatDSGV()
        {
            for (int i = 0; i < dsgv.Count; i++)
            {
                dsgv[i].Xuat1GV();
            }
        }
        public int TongSoNhom()
        {
            return dsgv.Sum(t => t.SoNhomHuongDan);
        }
        public void SapXepTen()
        {
            dsgv = dsgv.OrderBy(t => t.HoTen).ToList();
        }
        public void SapXepTenGiamDan()
        {
            dsgv = dsgv.OrderByDescending(t => t.HoTen).ToList();
        }
        public void SapXepTheoNhom()
        {
            dsgv = dsgv.OrderByDescending(t => t.SoNhomHuongDan).ToList();
        }
        public List<GiaoVien> LocSoNhom()
        {
            return dsgv.Where(t => t.SoNhomHuongDan > 1).ToList();
        }
    }
}
