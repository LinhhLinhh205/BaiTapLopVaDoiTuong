using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT03
{
    class PhanSo
    {
        private int tuso;
        private int mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;

        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;

        }
        public int getMauso()
        {
            return mauso;
        }
        public void ToiGian()
        {
            int uscln = TimUSCLN(tuso, mauso);
            tuso /= uscln;
            mauso /= uscln;
        }
        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else y -= x;
            }
            return x;
        }
        public PhanSo Tong(PhanSo PS)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * PS.mauso + mauso * PS.tuso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
        public PhanSo Hieu(PhanSo PS)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * PS.mauso - mauso * PS.tuso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
        public PhanSo Tich(PhanSo PS)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * PS.tuso;
            kq.mauso = mauso * PS.mauso;
            return kq;
        }
        public PhanSo Thuong(PhanSo PS)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * PS.mauso;
            kq.mauso = mauso * PS.tuso;
            return kq;
        }
    }
}
    

