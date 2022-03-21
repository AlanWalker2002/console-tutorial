using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._5.Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 1, 5, 7, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            int i = 0;
            do
            {
                Console.WriteLine("Trước khi lặp");
                Console.WriteLine(arr[i]);
                i++;
            } while (i < arr.Length);

            int i = 0;
            while (i < arr.Length)
            {
                Console.WriteLine("Trước khi lặp");
                Console.WriteLine(arr[i]);
                i++;
            }
*/
            Console.WriteLine("Nhap so phan tu cua mang");
            int n =Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            //Nhap mang
                for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phantu thu " + (i + 1));
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("Mang vua nhap la:");
                for(int i = 0;i < n; i++)
            {
                Console.WriteLine(arr[i].ToString() + "");
            }



            Console.ReadKey();
        }
    }
}
