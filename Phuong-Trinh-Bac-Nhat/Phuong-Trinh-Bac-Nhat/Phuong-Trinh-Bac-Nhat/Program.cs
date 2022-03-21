/*Giai pt bac nhat ax+b=0*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_Trinh_Bac_Nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                
                string a, b;
                int ValueA = 0, ValueB = 0;
                bool bCheckA = false;
                bool bCheck = false;

                do
                {
                    do
                    {
                        Console.WriteLine("Nhap a:");
                        a = Console.ReadLine();
                        
                        if (int.TryParse(a, out ValueA) == false)
                        {
                            Console.WriteLine("Gia tri a khong phai la so, Vui long nhap lai!");
                            bCheckA = true;
                            
                        }
                        else
                        {
                            bCheckA=false;
                            Console.WriteLine(a.GetType());
                        }
                    }while (bCheckA==true);
                
                    Console.WriteLine("Nhap b:");
                    b = Console.ReadLine();
                    if (int.TryParse(b, out ValueB) == false)
                    {
                        Console.WriteLine("Gia tri a khong phai la so, Vui long nhap lai!");
                        return;

                    }

                    Console.WriteLine("Phuong trinh vua nhap la: "+ ValueA+"x+ " + b + " =0");
                    
                    if (ValueA == 0)
                    {
                        if (ValueB == 0)
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
                        Console.WriteLine("Phuong trinh co nghiem x = " + (- Convert.ToDouble( ValueB) / ValueA));
                    }

                    Console.WriteLine("Ban co muon tiep tuc ko? Y/N");
                    string answer = Console.ReadLine();
                    if(answer.ToUpper() == "Y")
                    {
                        bCheck = false;
                    }else
                    {
                        bCheck=true;
                    }    
                }while (bCheck==false);
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);            
            }

            Console.ReadKey();
        }
    }
}
