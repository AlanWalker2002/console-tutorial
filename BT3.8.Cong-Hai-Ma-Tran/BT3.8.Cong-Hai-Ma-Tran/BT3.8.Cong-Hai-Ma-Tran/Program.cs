
/*Viết chương trình để cộng hai ma trận và sau đó in ma trận kết quả trên màn hình*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._8.Cong_Hai_Ma_Tran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] a = new int[100, 100];
            int[,] b = new int[100, 100];
            int[,] tong_2_ma_tran = new int[100, 100];
            int n, i,j;
            Console.WriteLine("Nhap vao kich co cua ma tran: ");
            n= Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Nhap cac phan tu vao trong ma tran thu 1\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]= ",i,j);
                    a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Nhap cac phan tu vao trong ma tran thu 2\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("b[{0},{1}]= ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    tong_2_ma_tran[i, j] = a[i, j] + b[i, j];
                }
            }

            Console.WriteLine("Tong 2 ma tran la ");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("S[{0},{1}]= " + tong_2_ma_tran[i, j],i,j);
                }
            }*/



            int[,] a = new int[100, 100];
            int[,] b = new int[100, 100];
            int[,] tong_2_ma_tran = new int[100, 100];
            int n, i, j,h1,h2,c1,c2;
            Console.Write("\nNhap so hang va so cot cua ma tran thu nhat:\n");
            Console.Write("Nhap so hang: ");
            h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNhap so hang va so cot cua ma tran thu hai:\n");
            Console.Write("Nhap so hang: ");
            h2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (h1 != h2 || c1 != c2)
            {
                Console.WriteLine("Kich thuoc hai ma tran khong bang nhau, ui long nhap lai!!!");
            }
            else
            {
                Console.WriteLine("Nhap cac phan tu vao trong ma tran thu 1\n");
                for (i = 0; i < h1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.WriteLine("a[{0},{1}]= ", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Nhap cac phan tu vao trong ma tran thu 2\n");
                for (i = 0; i < h2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.WriteLine("b[{0},{1}]= ", i, j);
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (i = 0; i < h1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        tong_2_ma_tran[i, j] = a[i, j] + b[i, j];
                    }
                }

                Console.WriteLine("Tong 2 ma tran la ");
                for (i = 0; i < h1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.WriteLine("S[{0},{1}]= " + tong_2_ma_tran[i, j], i, j);
                    }
                }
            }





            Console.ReadKey();  
        }
    }
}
