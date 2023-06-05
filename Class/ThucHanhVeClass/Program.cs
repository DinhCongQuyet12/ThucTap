using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyThuyetVeClass.Data;

namespace LyThuyetVeClass
{
     class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien(" NV01 ","Đinh Công Quyết") ;
  
           



            Console.WriteLine("Mã Nhân Viên :  "    + nv1.maNhanVien);
            Console.WriteLine("Họ Và Tên   :  "      + nv1.hoVaTen);
           
            Console.ReadLine();
        }
        }
}
