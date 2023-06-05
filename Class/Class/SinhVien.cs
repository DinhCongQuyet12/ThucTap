using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
     class SinhVien
    {
        public string tenSinhVien;
        public int namSinh;
        public string email;


        public void HienThiThongTin()
        {
            Console.WriteLine("Ten Sinh Vien la: " + tenSinhVien);
            Console.WriteLine("Nam Sinh: " + namSinh);
            Console.WriteLine("Email : " + email);
        }
    }
}
