using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(" 1 "," Đinh Công Quyết ", new DateTime(2021,12,22)," 10 ", 7.5);
            sv.hienThiThongTin();
            Console.ReadLine();
        }
    }
}
