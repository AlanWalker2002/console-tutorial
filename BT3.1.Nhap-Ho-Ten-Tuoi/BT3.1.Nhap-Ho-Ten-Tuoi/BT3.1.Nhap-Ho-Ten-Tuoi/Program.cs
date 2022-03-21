using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._1.Nhap_Ho_Ten_Tuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                string ht, ns;
                Console.WriteLine("Nhap ho ten: ");
                ht = Console.ReadLine();
                Console.WriteLine("Nhap nam sinh: ");
                ns = Console.ReadLine();
                int NamCheck = 0;
                int NamHienTai= DateTime.Now.Year;

                if(int.TryParse(ht, out NamCheck) == false)
                {
                    Console.WriteLine("Nam sinh " + ns + "Ko phai la so");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    if (NamCheck > NamHienTai)
                    {
                        Console.WriteLine("Nam sinh" + NamCheck + "Ko duoc lon hon Nam hien tai!");
                        Console.ReadKey ();
                        return;
                    }
                }

               
                int tuoi = NamHienTai - Convert.ToInt32(ns);
                Console.WriteLine("Ten la: " + ht + ",tuoi: " + tuoi);
                Console.ReadKey();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
           

            Console.ReadKey();
        }
    }
}
