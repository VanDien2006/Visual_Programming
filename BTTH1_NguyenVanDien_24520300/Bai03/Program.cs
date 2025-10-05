using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Viết chương trình nhập ngày tháng năm, cho biết ngày tháng năm đó có hợp lệ
//không?

namespace Bai03
{
    internal class Program
    {
        static int ngayTrongThang(int Month, int Year)
        {
            switch (Month)
            {
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2:
                    if (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)) return 29;
                    else return 28;
                default:
                    return 31;
            }
        }

        static bool laNgayThangNam(int Day, int Month, int Year)
        {
            if (Year < 0 || Month < 1 || Month > 12 || Day<1) return false;
            return Day <= ngayTrongThang(Month, Year);
        }
        static void Main(string[] args)
        {
            int Day, Month, Year;
            string str_day, str_month, str_year;

            Console.Write("Nhap ngay la mot so nguyen: ");
            bool check = false;
            do
            {
                if (check == true)
                {
                    Console.Write("Ngay khong hop le! Nhap lai: ");
                }
                str_day = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(str_day, out Day))) ;

            Console.Write("Nhap thang la mot so nguyen: ");
            check = false;
            do
            {
                if (check == true)
                {
                    Console.Write("Thang khong hop le! Nhap lai: ");
                }
                str_month = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(str_month, out Month))) ;

            Console.Write("Nhap nam la mot so nguyen: ");
            check = false;
            do
            {
                if (check == true)
                {
                    Console.Write("Nam khong hop le! Nhap lai: ");
                }
                str_year = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(str_year, out Year))) ;

            Console.Write("\n -- Ngay thang nam vua nhap: ");
            if(laNgayThangNam(Day, Month, Year))
            {
                Console.WriteLine("hop le! -- \n");
            }
            else
            {
                Console.WriteLine("khong hop le -- \n");
            }
            Console.ReadLine();
        }
    }
}
