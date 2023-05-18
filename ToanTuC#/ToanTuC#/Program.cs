using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTuC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 6;
            int b = 4;
            Console.WriteLine("a + b =  {0}", a + b);
            Console.WriteLine("a - b =  {0}", a - b);
            Console.WriteLine("a * b =  {0}", a * b);
            Console.WriteLine("a / b =  {0}", a / b);

            //console.readline();
            //gan
            int c;
            c = 3;
            c += 1;
            Console.WriteLine(c);
            Console.ReadLine();
            //so sánh, logic
            bool kq;
            bool d = true;
            bool g = false;
            kq = !(d && g);
            kq = d || g;
            Console.WriteLine(kq);
            Console.ReadLine();

            bool kq1;
            int e = 4;
            int f = 6;
            kq1 = e == f;
            Console.WriteLine("a == b ==> {0}", kq1 );

            Console.ReadLine();


        }   
    }
}
