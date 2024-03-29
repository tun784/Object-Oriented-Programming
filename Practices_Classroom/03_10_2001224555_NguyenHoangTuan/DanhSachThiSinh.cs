using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _03_10_2001224555_NguyenHoangTuan
{
    public class DanhSachThiSinh
    {
        List<ThiSinh> dsts = new List<ThiSinh>();
        public void nhapXML(string path)
        {
            XmlDocument read = new XmlDocument();
            read.Load(path);
            XmlNodeList nodes = read.SelectNodes("/DSSV/ThiSinh");
            foreach (XmlNode node in nodes)
            {
                ThiSinh ts = new ThiSinh();
                ts.HoTen = node["HT"].InnerText;
                ts.SoBaoDanh = node["SBD"].InnerText;
                ts.NamSinh = Convert.ToInt32(node["NamSinh"].InnerText);
                ts.DiemToan = Convert.ToDouble(node["Toan"].InnerText);
                ts.DiemVan = Convert.ToDouble(node["Van"].InnerText);
                ts.DiemNgoaiNgu = Convert.ToDouble(node["NN"].InnerText);
                dsts.Add(ts);
            }
        }
    }
}
