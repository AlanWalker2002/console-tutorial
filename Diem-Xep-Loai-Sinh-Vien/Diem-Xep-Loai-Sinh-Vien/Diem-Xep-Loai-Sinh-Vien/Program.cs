using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diem_Xep_Loai_Sinh_Vien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;

                double DiemNew = 0;
                bool isCheck = false;
                string DiemTB;

                do
                {
                    Console.WriteLine("Nhập điểm trung bình: ");
                    DiemTB = Console.ReadLine();

                    if(double.TryParse(DiemTB, out DiemNew) == false)
                    {
                        Console.WriteLine("Điểm trung bình: " + DiemTB + " không phải là số.");
                        Console.ReadKey();
                        isCheck = true;
                    } else
                    {
                        if (DiemNew < 0 || DiemNew > 10)
                        {
                            Console.WriteLine("Điểm trung bình nằm ngoài khoảng [0-10]");
                            Console.ReadKey();
                            isCheck = true;
                        }
                    }
                } while (isCheck);

                if (DiemNew >= 9 && DiemNew <= 10)
                {
                    Console.WriteLine("Xep loai xuat sac");
                }
                else if (DiemNew >= 8 && DiemNew < 9)
                {
                    Console.WriteLine("Xep loai gioi");
                }
                else if (DiemNew >= 7 && DiemNew < 8)
                {
                    Console.WriteLine("Xep loai kha");
                }
                else if (DiemNew >= 6.5 && DiemNew < 7)
                {
                    Console.WriteLine("Xep loai trung binh kha");
                }
                else if (DiemNew >= 5 && DiemNew < 6.5)
                {
                    Console.WriteLine("Xep loai trung binh");
                }
                else
                {
                    Console.WriteLine("Xep loai yeu");
                }

                Console.ReadKey();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}
