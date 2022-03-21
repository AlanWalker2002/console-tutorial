using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string err = "";

            Console.OutputEncoding = Encoding.UTF8;
            Program _program = new Program();
            var result = _program.Calculator(10, 0, ref err);
            if (err != "")
            {
                Console.WriteLine("Error: " + err);

            }
            else
            {
                Console.WriteLine("Ket qua thuc hien" + result);

            }
            Console.ReadKey();
        }

        public double Calculator(int a, int b, ref string Error)
        {
            try
            {
                var result = a / b;
                return result;

            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1;
            }
        }
    }
}
