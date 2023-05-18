using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenh_CauTrucReNhanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
            if (điều kiện logic)
            {
            ...khoi lenh if
            }
            else{
                khôi lệnh else

                }


            */
            //int a;
            //Console.WriteLine("Nhap so nguyen a");
            //a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Ket Qua");
            //    Console.WriteLine($"So {a} la so chan");
            //}
            //else
            //{
            //    Console.WriteLine("Ket Qua");
            //    Console.WriteLine($"Sp {a} la so le");
            //} 

               
            //    Console.ReadLine();

            float dtb;
            Console.WriteLine("Nhap diem trung binh");
            dtb = float.Parse(Console.ReadLine());
            if (dtb <= 5)
            {
                Console.WriteLine("Hoc Luc Yeu");
            }
            else if (dtb >= 5 && dtb < 6.5)
            {
                Console.WriteLine("Hoc Luc Tb");
            }   
             else if (dtb < 8) 
            {
                Console.WriteLine("Hoc Luc Kha");
            }
             else if (dtb >= 8) 
            {
                Console.WriteLine("Hoc Luc Gioi");
            }
            else
            {
                Console.WriteLine("Nhap Sai So");
            }

            Console.ReadLine();
        }
      

    }
            
}
    



