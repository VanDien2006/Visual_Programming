using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class KhuDat
    {
        protected string DiaDiem;
        protected int GiaBan;
        protected double DienTich;
        public virtual void Nhap()
        {
            Console.Write("Nhap dia diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            bool str_giaban;
            while (true)
            {
                str_giaban = int.TryParse(Console.ReadLine(), out GiaBan);
                if (str_giaban && GiaBan>0) break;
                Console.Write("Gia ban khong hop le! Nhap lai: ");
            }
            Console.Write("Nhap dien tich: ");
            bool str_dientich;
            while (true)
            {
                str_dientich = double.TryParse(Console.ReadLine(), out DienTich);
                if (str_dientich && DienTich>0) break;
                Console.Write("Dien tich khong hop le! Nhap lai: ");
            }
        }
        public virtual void Xuat()
        {
            Console.Write($"{DiaDiem}: {GiaBan} VND, {DienTich} m^2");
        }
        public string GetDiaDiem()
        {
            return DiaDiem;
        }
        public int GetGiaBan()
        {
            return GiaBan;
        }
        public double GetDienTich()
        {
            return DienTich;
        }
    }
}
