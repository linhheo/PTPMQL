using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaiptbac1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap he so a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so b:");
            int b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                else
                        Console.WriteLine("Phuong trinh vo nghiem");
            } 
            else
            {
                int ketqua = -b / a;
                Console.WriteLine("Phuong trinh co nghiem la: {0}", ketqua.ToString());
            }
            Console.ReadKey();
        }
    }
}

