using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            Console.WriteLine($"Hinh chu nhat: Chieu dai: {r1.getLength()}, Chieu rong: {r1.getWidth()}, Dien Tich: {r1.findArea()}, Chu vi: {r1.findPerimeter()}");

            Console.Write("Cho biet chieu dai: ");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Cho biet chieu rong: ");
            double w = double.Parse(Console.ReadLine());

            Rectangle r2 = new Rectangle(l, w);

            Console.WriteLine($"Hinh chu nhat: Chieu dai: {r2.getLength()}, Chieu rong: {r2.getWidth()}, Dien Tich: {r2.findArea()}, Chu vi: {r2.findPerimeter()}");
            Console.ReadLine();

        }
    }
}
