using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace DanhSachThiSinh
{
    class DanhSachThiSinh
    {
        List<ThiSinh> dsts = new List<ThiSinh>();
        public DanhSachThiSinh() { }
        public void NhapXML(string file)
        {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList noteList = read.SelectNodes("/DanhSach/TS");
            foreach (XmlNode node in noteList)
            {
                ThiSinh ts = new ThiSinh();

                dsts.Add(ts);
            }
        }
    }
}
