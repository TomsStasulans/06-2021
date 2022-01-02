using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(70.00, 14, "Logitech mouse");
            Console.WriteLine(mouse.PrintProduct());
            Product phone = new Product(999.99, 3, "iPhone 5s");
            Console.WriteLine(phone.PrintProduct());
            Product epson = new Product(440.46, 1, "Epson EB-U05");
            Console.WriteLine(epson.PrintProduct());
            Console.ReadKey();
        }
    }
}
