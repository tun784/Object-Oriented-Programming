using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bai1
{
    public class DanhSachBDS
    {
        List<BatDongSan> dsbds = new List<BatDongSan>();
        public string LoaiBDS;
        public void NhapXML(string file) {
            XmlDocument read = new XmlDocument();
            read.Load(file);
            XmlNodeList nodes = read.SelectNodes("/BDSs/BDS");
            foreach (XmlNode node in nodes)
            {
                LoaiBDS = node["Loai"].InnerText;
                switch (LoaiBDS)
	            {
                    case "DatTrong":{
                        DatTrong bds = new DatTrong();

                        bds.Loai = node["Loai"].InnerText;
                        bds.MaSo = node["Ma"].InnerText;
                        bds.ChieuDai = Convert.ToDouble(node["Dai"].InnerText, CultureInfo.InvariantCulture);
                        bds.ChieuRong = Convert.ToDouble(node["Rong"].InnerText, CultureInfo.InvariantCulture);

                        dsbds.Add(bds);
                    }break;
                    case "NhaO":{
                        NhaO bds = new NhaO();

                        bds.Loai = node["Loai"].InnerText;
                        bds.MaSo = node["Ma"].InnerText;
                        bds.ChieuDai = Convert.ToDouble(node["Dai"].InnerText, CultureInfo.InvariantCulture);
                        bds.ChieuRong = Convert.ToDouble(node["Rong"].InnerText, CultureInfo.InvariantCulture);
                        bds.SoLau = Convert.ToInt32(node["SoLau"].InnerText);

                        dsbds.Add(bds);
                    }break;
                    case "KhachSan":{
                        KhachSan bds = new KhachSan();

                        bds.Loai = node["Loai"].InnerText;
                        bds.MaSo = node["Ma"].InnerText;
                        bds.ChieuDai = Convert.ToDouble(node["Dai"].InnerText, CultureInfo.InvariantCulture);
                        bds.ChieuRong = Convert.ToDouble(node["Rong"].InnerText, CultureInfo.InvariantCulture);
                        bds.SoSao = Convert.ToInt32(node["SoSao"].InnerText);

                        dsbds.Add(bds);
                    }break;
                    case "BietThu":{
                        BietThu bds = new BietThu();

                        bds.Loai = node["Loai"].InnerText;
                        bds.MaSo = node["Ma"].InnerText;
                        bds.ChieuDai = Convert.ToDouble(node["Dai"].InnerText, CultureInfo.InvariantCulture);
                        bds.ChieuRong = Convert.ToDouble(node["Rong"].InnerText, CultureInfo.InvariantCulture);

                        dsbds.Add(bds);
                    }break;
		            default: break;
	            }
            }
        }
        public double TongGiaTri()
        {
            return dsbds.Sum(t => t.GiaBan());
        }
        public void XuatDS(){
            foreach (BatDongSan bds in dsbds){
                bds.Xuat1BDS();
                Console.WriteLine("");
            }
        }
    }
}