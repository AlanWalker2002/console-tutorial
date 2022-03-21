using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_And_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Value = 100;

            Console.WriteLine("Gia tri truoc khi goi ham: " + Value);
            Program program = new Program();
            program.print(ref Value);
            Console.WriteLine("Gia tri sau khi goi ham: " + Value);
            Console.ReadKey();

        }

        public void print(ref int Input)
        {
            Input += Input;
            Console.WriteLine(Input);
        }
    }
}
