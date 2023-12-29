using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class Program
    {
        static void CauA()
        {
            PhanSo a = new PhanSo();

            Console.WriteLine("---Nhap so thu nhat---");
            Console.Write("Nhap tu so thu nhat:");
            int tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so thu nhat:");
            int mauso = int.Parse(Console.ReadLine());

            a.setTuso(tuso);
            a.setMauso(mauso);
            a.ToiGian();

            Console.WriteLine("---Nhap so thu hai---");
            Console.Write("Nhap tu so thu nhat:");
            tuso = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so thu nhat:");
            mauso = int.Parse(Console.ReadLine());

            PhanSo b = new PhanSo(tuso, mauso);


            PhanSo tong = a.Tong(b);
            Console.WriteLine($"Tong 2 phan so {a.getTuso()} /{a.getMauso()},{b.getTuso()}/{b.getMauso()}={tong.getTuso()}/{tong.getMauso()}");

            PhanSo hieu = a.Hieu(b);
            Console.WriteLine($"Hieu 2 phan so {a.getTuso()} /{a.getMauso()},{b.getTuso()}/{b.getMauso()}={hieu.getTuso()}/{hieu.getMauso()}");

            PhanSo tich = a.Tich(b);
            Console.WriteLine($"Tich 2 phan so {a.getTuso()} /{a.getMauso()},{b.getTuso()}/{b.getMauso()}={tich.getTuso()}/{tich.getMauso()}");

            PhanSo thuong = a.Thuong(b);
            Console.WriteLine($"Thuong 2 phan so {a.getTuso()} /{a.getMauso()},{b.getTuso()}/{b.getMauso()}={thuong.getTuso()}/{thuong.getMauso()}");

        }
        static void CauB()
        {
            Console.WriteLine("---Tinh toan day phan so---");
            Console.Write("Nhap so nguyen duong:");
            int n = int.Parse(Console.ReadLine());

            PhanSo s = new PhanSo(0, 1);
            for (int i = 1; i <= n; i++)
                s = s.Tong(new PhanSo(1, i));
            s.ToiGian();
            Console.WriteLine($"Ket qua day phan so: 1+1/2+1/3+...+1/n={s.getTuso()}/{s.getMauso()}");

        }
        static void Main(string[] args)
        {

            CauA();
            CauB();

            Console.ReadLine();
        }
    }
}
