using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._10.Dem_So_Lan_Xuat_Hien_Chuoi_Con
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string str1; //khai bao chuoi ban dau
            string chuoi_con; //khai bao chuoi con can tim
            int strt = 0;
            int cnt = -1;
            int idx = -1;

            Console.Write("\nDem so lan xuat hien cua chuoi con trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap chuoi ban dau: ");
            str1 = Console.ReadLine();
            Console.Write("Nhap chuoi con can tim: ");
            chuoi_con = Console.ReadLine();


            while (strt != -1)
            {
                strt = str1.IndexOf(chuoi_con, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("Chuoi con '{0}' xuat hien " + cnt + " lan.\n", chuoi_con);*/


            try
            {
                Console.WriteLine("Nhap chuoi cha: ");
                string strCha = Console.ReadLine();

                Console.WriteLine("Nhap chuoi con: ");
                string strCon = Console.ReadLine();

                int Count = 0;
                for (int i = 0; i <= strCha.Length - strCon.Length; i++)
                {
                    bool bCheck = false;
                    for (int j = 0; i < strCon.Length ; i++)
                    {                       
                        if (strCha[i + j] != strCon[i])
                        {
                            bCheck = true; break;
                        }
                       
                    }
                    if (bCheck == false) { Count++; }
                }
                Console.WriteLine(Count);
            
                }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
