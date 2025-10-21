using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class ChungCu: KhuDat
    {
        private int Tang;
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin chung cu");
            base.Nhap();
            Console.Write("Nhap tang: ");
            bool str_tang;
            while (true)
            {
                str_tang = int.TryParse(Console.ReadLine(), out Tang);
                if (str_tang && Tang > 0) break;
                Console.Write("Tang khong hop le! Nhap lai: ");
            }
        }
        public override void Xuat()
        {
            Console.Write("Chung cu: ");
            base.Xuat();
            Console.WriteLine($", Tang: {Tang}");
        }
        public int GetTang()
        {
            return Tang;
        }
    }
}
