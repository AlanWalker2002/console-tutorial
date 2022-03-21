/*Giai PT bac 2*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_Trinh_Bac_Hai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, delta;
             
            Console.WriteLine("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem!");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem!");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem x = " + (- c / b));
                }
            }
            else
            {
                delta = (b * b - 4 * a * c);

                if(delta > 0)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet ");
               
                    Console.WriteLine("x1 = " + Math.Round(((-b + Math.Sqrt(delta)) / 2 * a) * 100) / 100);
                    Console.WriteLine("x2 = " + Math.Round(((-b - Math.Sqrt(delta)) / 2 * a) * 100) / 100);
                }
                else if(delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = "+ (-b/2*a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
            }

            Console.ReadKey();
        }
    }
}
