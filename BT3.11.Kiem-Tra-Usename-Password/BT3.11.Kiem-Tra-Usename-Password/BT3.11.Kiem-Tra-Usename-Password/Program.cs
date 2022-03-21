using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._11.Kiem_Tra_Usename_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            try
            {
                string usename, password;
                int dem = 0;
                do
                {
                    Console.WriteLine("Nhap Usename: ");
                    usename = Console.ReadLine();
                    Console.WriteLine("Nhap Password: ");
                    password = Console.ReadLine();
                    dem++;

                } while (((usename != "phucloc") || (password != "123123")) && (dem != 3));
                if (dem == 3)
                {
                    Console.WriteLine("Ban nhap qua so lan quy dinh!");
                }
                else
                {
                    Console.WriteLine("Ban da nhap dung thong tin");
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
