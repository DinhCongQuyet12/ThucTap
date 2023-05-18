using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case
            //  Switch(expr)
            //  {    
            //   case expr1:
            //        Câu lệnh thi hành nếu expr=expr1;
            //   break;
            //   case expr2:
            //        Câu lệnh thi hành nếu expr=expr2;
            //   break;
            //    ..........
            //    default:
            //      ....
            //     break; 
            //  }
            int a;
            a = 5;
            switch (a)
            {
                case 1:
                    Console.WriteLine("Gia Tri cua a=1");
                break;
            }
            switch (a)
            {
                case 2:
                    Console.WriteLine("Gia Tri cua a=2");
                break;
            }
            switch (a)
            {
                case 3:
                    Console.WriteLine("Gia Tri cua a=3");
               break;

                default:
                    Console.WriteLine("Hay thu so khac");
                    break;
            }
            Console.ReadLine();
        }
    }
}
