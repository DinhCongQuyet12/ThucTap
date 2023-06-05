
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeLinq
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // them 5 oto vao danh sach
            List<OTo> danhSachOTo = new List<OTo>();
            // Tao ra 1 doi tuong oto moi
            OTo oTo1 = new OTo(1, "OTO1");
           
            oTo1.giaNiemYet = 100;
            List<ThongTinThue> dsThue = new List<ThongTinThue>();
            ThongTinThue thue1 = new ThongTinThue() { loaiThue = 1, tenThue = "Thue Tieu Thu Dac Biet", giaTriXe = oTo1.giaNiemYet, mucDong = 5 };
            ThongTinThue thue2 = new ThongTinThue() { loaiThue = 2, tenThue = "Thue Nhap Khau", giaTriXe = oTo1.giaNiemYet, mucDong = 5 };
            dsThue.Add(thue1) ;
            dsThue.Add(thue2);
            oTo1.danhSachThue = dsThue;
            // them 1 o to
            danhSachOTo.Add(oTo1);


            // tao ra 1 doi tuong oto moi
            OTo oto2 = new OTo(2, "oto2");

            oto2.giaNiemYet = 1000;
            oto2.danhSachThue = dsThue;
            // them 1 o to
            danhSachOTo.Add(oto2);

            // tao ra 1 doi tuong oto moi
            OTo oto3 = new OTo(3, "oto3");

            oto3.giaNiemYet = 10000;
            oto3.danhSachThue = dsThue;
            // them 1 o to
            danhSachOTo.Add(oto3);


            // tao ra 1 doi tuong oto moi
            OTo oto4 = new OTo(4, "oto4");

            oto4.giaNiemYet = 100000;
            oto4.danhSachThue = dsThue;
            // them 1 o to
            danhSachOTo.Add(oto4);


            // tao ra 1 doi t
            // uong oto moi
            OTo oto5 = new OTo(5, "OTo5");

            oto5.giaNiemYet = 1000000;
            oto5.danhSachThue = dsThue;
            // them 1 o to
            danhSachOTo.Add(oto5);

            foreach (var i in danhSachOTo)
            {
                Console.WriteLine("Thong Tin O To:  " + i.iD);
                Console.WriteLine("So Khung : " + i.soKhung);
                Console.WriteLine("Gia Niem Yet : " + i.giaNiemYet);
                foreach (var thue in i.danhSachThue)
                {
                    Console.WriteLine("Thue Loai " + thue.loaiThue);
                   

                }
                Console.WriteLine("Tong tien thue phai nop" + i.thuePhaiNop());
                Console.ReadLine();
            }
            Console.WriteLine("Tong tien xe là" + danhSachOTo.Sum (i => i.giaNiemYet));
            Console.WriteLine("So tien thue cao nhat" + danhSachOTo.Max(i => i.thuePhaiNop()));
            Console.Read();
        }
        
    }
}
