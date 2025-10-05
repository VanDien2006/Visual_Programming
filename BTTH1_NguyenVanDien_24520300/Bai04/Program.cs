using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.Viết chương trình nhập vào tháng và năm. In ra số ngày của tháng đó.

namespace Bai04
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
        static void Nhap(out int Month, out int Year)
        {
            string str_month, str_year;
           
            bool check = true;
            Console.Write("Nhap thang: ");
            do
            {
                if (check == false)
                {
                    Console.Write("Thang khong hop le! Nhap lai: ");
                }
                str_month = Console.ReadLine();
                check = false;
            }
            while (!(int.TryParse(str_month, out Month)) || !(Month >= 1) || !(Month <= 12));

            check = true;
            Console.Write("Nhap nam: ");
            do
            {
                if (check == false)
                {
                    Console.Write("Nam khong hop le! Nhap lai: ");
                }
                str_year = Console.ReadLine();
                check = false;
            }
            while (!(int.TryParse(str_year, out Year)) || !(Year >= 1));
        }
   
        static void Main(string[] args)
        {
            int Month, Year;
            Nhap(out Month, out Year);
            Console.WriteLine("So ngay cua thang {0} nam {1} la: {2}", Month, Year, ngayTrongThang(Month, Year) );
            Console.ReadLine();
        }
    }
}
