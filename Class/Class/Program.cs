using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo 1 đối tượng theo class có sẵn
            SinhVien sv1 = new SinhVien();
            // Truyen dữ liệu cho các thuộc tính
            sv1.tenSinhVien = "Dinh Cong Quyet";
            sv1.namSinh = 1999;
            sv1.email = "quyetcongdinh@gmail.com";
            // Chạy phương thưc của đối tượng
            sv1.HienThiThongTin();
            Console.ReadKey();

        }
    }
}
