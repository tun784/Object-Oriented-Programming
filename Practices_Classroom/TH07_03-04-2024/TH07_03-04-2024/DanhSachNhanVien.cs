using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace TH07_03_04_2024
{
    public class DanhSachNhanVien
    {
        List<NhanVien> dsnv = new List<NhanVien>();
        int LoaiNV;
        public void NhapDSNV(string path)
        {
            XmlDocument read = new XmlDocument();
            read.Load(path);
            XmlNodeList nodes = read.SelectNodes("/DSNV/NV");
            foreach (XmlNode node in nodes)
            {
                LoaiNV = Convert.ToInt32(node["LoaiNV"].InnerText);
                switch (LoaiNV)
                {
                    case 1:
                        {
                            NhanVienSanXuat nv = new NhanVienSanXuat();

                            nv.LoaiNV = Convert.ToInt32(node["LoaiNV"].InnerText);
                            nv.MaNhanVien = node["Ma"].InnerText;
                            nv.TenNhanVien = node["Ten"].InnerText;
                            nv.NamSinh = Convert.ToInt32(node["NamSinh"].InnerText);
                            nv.GioiTinh = node["GioiTinh"].InnerText;
                            nv.HeSoLuong = Convert.ToDouble(node["HSL"].InnerText);
                            nv.NamVaoLam = Convert.ToInt32(node["NamVaoLam"].InnerText);
                            nv.SoNgayNghi = Convert.ToInt32(node["SoNgayNghi"].InnerText);

                            dsnv.Add(nv);
                        }break;
                    case 2:
                        {
                            NhanVienKinhDoanh nv = new NhanVienKinhDoanh();

                            nv.LoaiNV = Convert.ToInt32(node["LoaiNV"].InnerText);
                            nv.MaNhanVien = node["Ma"].InnerText;
                            nv.TenNhanVien = node["Ten"].InnerText;
                            nv.NamSinh = Convert.ToInt32(node["NamSinh"].InnerText);
                            nv.GioiTinh = node["GioiTinh"].InnerText;
                            nv.HeSoLuong = Convert.ToDouble(node["HSL"].InnerText);
                            nv.NamVaoLam = Convert.ToInt32(node["NamVaoLam"].InnerText);
                            nv.DoanhSo = Convert.ToInt32(node["DoanhSo"].InnerText);
                            nv.DoanhSoToiThieu = Convert.ToInt32(node["DoanhSoToiThieu"].InnerText);

                            dsnv.Add(nv);
                        }break;
                    case 3:
                        {
                            CanBoQuanLy nv = new CanBoQuanLy();

                            nv.LoaiNV = Convert.ToInt32(node["LoaiNV"].InnerText);
                            nv.MaNhanVien = node["Ma"].InnerText;
                            nv.TenNhanVien = node["Ten"].InnerText;
                            nv.NamSinh = Convert.ToInt32(node["NamSinh"].InnerText);
                            nv.GioiTinh = node["GioiTinh"].InnerText;
                            nv.HeSoLuong = Convert.ToDouble(node["HSL"].InnerText);
                            nv.NamVaoLam = Convert.ToInt32(node["NamVaoLam"].InnerText);
                            nv.ChucVu = node["ChucVu"].InnerText;
                            nv.HeSoChucVu = Convert.ToDouble(node["HeSoChucVu"].InnerText);

                            dsnv.Add(nv);
                        }break;
                    default:
                        break;
                }
            }
        }
        public void XuatDSNV()
        {
            foreach (NhanVien nv in dsnv)
            {
                nv.Xuat();
                Console.WriteLine();
            }
        }
    }
}
