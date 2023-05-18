using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Truy Cap Phan Tu Mang
            int[] Mang = { 1, 3, 5, 19 };
            int a = Mang[2];
            Console.WriteLine(a);
            Console.ReadLine();
            //Duyet Mang

            int[] myArray = { 1, 3, 5, 19, 10, 90, 40, 40 };
            int Max = myArray.Length - 1;
            for (int i = 0; i <= Max; i++)
            {
                Console.WriteLine(myArray[i]);
                Console.ReadLine();
            };
            // Sap Xep Mang
            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
            Array.Sort(arr);
    


        }
    }
}
