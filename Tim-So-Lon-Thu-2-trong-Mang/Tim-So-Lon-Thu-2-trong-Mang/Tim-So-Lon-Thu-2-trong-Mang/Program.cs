
/*Viết chương trình để nhập một mảng, sau đó tìm phần tử lớn thứ hai rồi in kết quả trên màn hình*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_So_Lon_Thu_2_trong_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n,i,max,max2; 
            Console.WriteLine("Nhap so phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]= ",i);
                a[i] =Convert.ToInt32(Console.ReadLine());
            }

            max = a[0];
            max2 = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
               
            }
            
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > max2 && a[i] < max)
                {
                    max2 = a[i];
                }
            }
            
            Console.WriteLine("Phan tu lon thu 2 la: " + max2);
            Console.ReadKey();
        }
    }
}
