using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class PhanSo: IComparable<PhanSo>
    {
        public int Tu, Mau;
        public PhanSo(int tu=0, int mau = 1)
        {
            if (mau == 0)
                throw new ArgumentException("Mau so khong duoc bang 0");
            this.Tu = tu;
            this.Mau = mau;
            RutGon();
        }
        int gcd(int a, int b)
        {
            int temp;
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        void RutGon()
        {
            int ucln = gcd(Tu, Mau);
            Tu /= ucln;
            Mau /= ucln;
        }
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            bool str_tu;
            while (true)
            {
                str_tu = int.TryParse(Console.ReadLine(), out Tu);
                if (str_tu) break;
                Console.Write("Tu so khong hop le! Nhap lai: ");
            }
            Console.Write("Nhap mau so: ");
            bool str_mau;
            while (true)
            {
                str_mau = int.TryParse(Console.ReadLine(), out Mau);
                if (str_mau) break;
                Console.Write("Mau so khong hop le! Nhap lai: ");
            }
        }
        public void Xuat()
        {
            this.RutGon();
            if (Tu == 0) Console.Write($"0 ");
            else if (Mau == -1) Console.Write(-Tu);
            else if (Mau == 1) Console.Write(Tu);
            else if (Mau < 0) Console.Write($"{-Tu}/{-Mau}");
            else Console.Write($"{Tu}/{Mau}");
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
            => new PhanSo(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo operator -(PhanSo a, PhanSo b)
            => new PhanSo(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        public static PhanSo operator *(PhanSo a, PhanSo b)
            => new PhanSo(a.Tu * b.Tu, a.Mau * b.Mau);
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.Tu * b.Mau, a.Mau * b.Tu);
        }

        public int CompareTo(PhanSo other)
        {
            double v1 = (double)Tu / Mau;
            double v2 = (double)other.Tu / other.Mau;
            return v1.CompareTo(v2);
        }
    }
}
