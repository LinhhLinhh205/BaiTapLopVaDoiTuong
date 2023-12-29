using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ID A:");
            string id = Console.ReadLine();
            Console.Write("Nhap name A:");
            string name = Console.ReadLine();
            Console.Write("Nhap balance A:");
            int balance = int.Parse(Console.ReadLine());

            Account A = new Account(id, name, balance);

            Console.Write("Nhap ID B:");
            id = Console.ReadLine();
            Console.Write("Nhap name B:");
            name = Console.ReadLine();
            Console.Write("Nhap balance B:");
            balance = int.Parse(Console.ReadLine());
            Account B = new Account(id, name, balance);
            int sotien = 0;
            Console.Write("Nhap so tien nap:");
            sotien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nap tien thanh cong");
            A.credit(sotien);

            Console.Write("Nhap so tien can rut:");
            sotien = int.Parse(Console.ReadLine());
            Console.WriteLine("Rut tien thanh cong");
            A.debit(sotien);

            Console.Write("Nhap so tien can chuyen khoan:");
            sotien = int.Parse(Console.ReadLine());
            A.tranferTo(B, sotien);

            Console.ReadLine();


        }
    }
}
