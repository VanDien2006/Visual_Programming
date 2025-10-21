using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class NhaPho: KhuDat
    {
        private int NamXayDung;
        private int SoTang;
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong tin nha pho");
            base.Nhap();
            Console.Write("Nhap nam xay dung: ");
            bool str_namxaydung;
            while (true)
            {
                str_namxaydung = int.TryParse(Console.ReadLine(), out NamXayDung);
                if (str_namxaydung && NamXayDung > 0) break;
                Console.Write("Nam xay dung khong hop le! Nhap lai: ");
            }
            Console.Write("Nhap so tang: ");
            bool str_sotang;
            while (true)
            {
                str_sotang = int.TryParse(Console.ReadLine(), out SoTang);
                if (str_sotang && SoTang > 0) break;
                Console.Write("So tang khong hop le! Nhap lai: ");
            }
        }
        public override void Xuat()
        {
            Console.Write("Nha pho: ");
            base.Xuat();
            Console.WriteLine($", Nam xay dung: {NamXayDung}, So tang: {SoTang}");
        }
        public int GetNamXayDung()
        {
            return NamXayDung;
        }
        public int GetSoTang()
        {
            return SoTang;
        }
    }

}
