using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeClass
{
    public class SinhVien
    {
        private string maSinhVien;
        private string  hoVaTen ;
        private DateTime ngaySinh;
        private string lop;
        private double diemTrungBinh;


        public double getDiemTrungBinh()
        {
            return this.diemTrungBinh;
        }


        public SinhVien(string maSV,string hoTen,DateTime ngaySinh,string lop,double diemTB)
        {
            this.maSinhVien = maSV;
            this.hoVaTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.lop = lop;
            this.diemTrungBinh = diemTB;

        }

        public void nhapThongTin()
        {
            //Nhap Ma Sinh Vien
            Console.WriteLine("Nhập Mã Sinh Viên");
            this.maSinhVien=Console.ReadLine();
            Console.WriteLine("Nhập Họ Tên");
            this.hoVaTen = Console.ReadLine();
            Console.WriteLine("Nhập Ngày Sinh");
            this.ngaySinh =Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập Tên Lớp");
            this.lop = Console.ReadLine();
            Console.WriteLine("Nhập Điểm Trung Bình");
            this.diemTrungBinh =Convert.ToDouble (Console.ReadLine());
        }
        

        public void hienThiThongTin()
        {
            Console.WriteLine("Nhập Mã Sinh Viên:" + this.maSinhVien);
           
            Console.WriteLine("Nhập Họ Tên:" + this.hoVaTen);
           
            Console.WriteLine("Nhập Ngày Sinh :" + this.ngaySinh.ToShortDateString());
           
            Console.WriteLine("Nhập Tên Lớp :" + this.lop);
          
            Console.WriteLine("Nhập Điểm Trung Bình :" + this.diemTrungBinh);
          
            Console.WriteLine("Học Lực :" + this.xetHocLuc(this.getDiemTrungBinh()));
        }


        public string xetHocLuc(double diemTrungBinh)
        {
                if (diemTrungBinh < 5)
                {
                return "Yếu";
            }
            else if (diemTrungBinh < 6.5)
            {
                return "Trung Binh";
            }
            else if(diemTrungBinh < 8)
            {
                return "Kha";
            }
            else
            {
                return "Gioi";
            }
        }

        


    }
}
