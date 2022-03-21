using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._12.Bubble_Sort
{
    internal class Program
    {
        static void printArray (int[] a, int index)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Lần "+index + ": ");

            foreach (int i in a) 
            {
                Console.Write(i + " ");
            }

            Console.Write("\n");
        }
        static void bubbleSort (int[] a) {
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                Boolean isSorted = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                   if(a[j] > a[j + 1])
                    {
                        isSorted = false;
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
                }

                printArray(a, i);

                if (isSorted)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] a = { 9, 7, 6, 3, 1, 5 };

            /*int[] b = { 1, 3, 5, 6, 9, 7 };*/

            int n = a.Length;

            Console.WriteLine("Mảng ban đầu: ");

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Mảng trong quá trình sắp xếp: ");

            bubbleSort(a);

            Console.WriteLine("\nMảng đã được sắp xếp: ");

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
