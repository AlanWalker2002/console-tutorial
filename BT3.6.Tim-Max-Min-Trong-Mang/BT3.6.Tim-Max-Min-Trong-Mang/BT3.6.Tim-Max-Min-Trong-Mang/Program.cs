using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._6.Tim_Max_Min_Trong_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, n, max, min;

            Console.WriteLine("Nhap so phan tu cua mang:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cac Phan tu cua mang vua nhap la:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("arr[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = arr[0];
            min = arr[0];

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    arr[i] = min;
                }
            }

            Console.WriteLine("Phan tu lon nhat la " + max);
            Console.WriteLine("Phan tu nho nhat la " + min);

            Console.ReadKey();
        } 
    }
}
