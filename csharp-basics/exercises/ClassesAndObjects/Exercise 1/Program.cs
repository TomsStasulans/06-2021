using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(70.00, 14, "Logitech mouse");
            mouse.PrintProduct();
            Product phone = new Product(999.99, 3, "iPhone 5s");
            phone.PrintProduct();
            Product epson = new Product(440.46, 1, "Epson EB-U05");
            epson.PrintProduct();
            Console.ReadKey();
        }
    }
}
