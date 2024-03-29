using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03_39_2001224555_NguyenHoangTuan_2001224551
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachMayTinh DSMT = new DanhSachMayTinh();
            int o;
            Console.WriteLine("1. Nhap danh sach tu file XML.");
            Console.WriteLine("2. Xuat danh sach.");
            Console.WriteLine("3. Liet ke cac may tinh co so luong lon hon 10.");
            Console.WriteLine("4. Tinh tong tien trong danh sach.");
            Console.WriteLine("5. Tinh tong so may tinh co nam san xuat la 2023.");

            do
            {
                Console.Write("Chon bai: ");
                o = int.Parse(Console.ReadLine());
                switch (o)
                {
                    case 1:
                        {
                            DSMT.docXML("MayTinh.xml");
                            Console.WriteLine("Da doc file XML");
                        } break;
                    case 2:
                        {
                            Console.WriteLine("Xuat ds may tinh: ");
                            DSMT.XuatDSMT();
                        } break;
                    case 3:
                        {
                            Console.WriteLine("Liet ke cac may tinh co so luong > 10: ");
                            DSMT.XuatDSMT2(DSMT.LietKe());
                        } break;
                    case 4:
                        {
                            DSMT.XuatTongTien();
                        } break;
                    case 5:
                        {
                            DSMT.XuatTongSoMay();
                        } break;
                    default:
                        break;
                }
            } while (true);
            Console.ReadLine();
        }
    }
}
