
/*Viết chương trình tìm ký tự xuất hiện nhiều nhất trong chuỗi*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._9.Tim_Ky_Tu_Xuat_Hien_Nhieu_Nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string str;
            int[] tan_suat = new int[255];
            int i, max;
            int ascii;

            Console.WriteLine("Nhap 1 chuoi:");
            str = Console.ReadLine();

            for(i = 0; i < 255; i++)
            {
                tan_suat[i] = 0; *//*Thiet lap tuan suat xuat hien cua cac ky tu ve 0*//*
            }

            *//* Doc tan suat cua moi ky tu *//*
            i = 0;
            while (i < str.Length)
            {
                ascii = (int)str[i];
                tan_suat[ascii] += 1;

                i++;
            }

            *//*Tim ky tu xuat hien nhieu nhat *//*
            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (tan_suat[i] > tan_suat[max])
                        max = i;
                }
            }
            Console.Write("Ky tu xuat hien nhieu nhat '{0}' va xuat hien {1} lan.\n\n", (char)max, tan_suat[max]);*/


            try {
                Console.WriteLine("Nhap choi: ");
                string strRoot =Console.ReadLine();

                //256 ky tu trong bang ma ASCII
                int[] arr = new int[256];
                for (int i = 0; i < 256; i++)
                {
                    //strRoot:a
                    for(int j = 0; j < strRoot.Length; j++)
                    {
                        if((int)strRoot[j] == i)
                        {
                            arr[i]++;
                        }
                    }
                }

                
              for(int i=0; i < arr.Length; i++)
                {
                    if(arr[i].ToString() != "0")
                    {
                        Console.WriteLine(char.ConvertFromUtf32(i) + " : " + arr[i] + " ");
                    }
                }

                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }






            Console.ReadKey();
        }
    }
}
