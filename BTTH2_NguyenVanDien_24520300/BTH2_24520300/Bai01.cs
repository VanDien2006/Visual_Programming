using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class Bai01
    {
        public static void Run()
        {
            //Nhap thang va nam
            int month, year;
            bool IsMonth, IsYear;

            Console.Write("Nhap thang: ");
            while (true)
            {
                IsMonth = int.TryParse(Console.ReadLine(), out month);
                if (IsMonth && 1 <= month && month <= 12) break;
                Console.Write("Thang khong hop le! Vui long nhap lai: ");
            }

            Console.Write("Nhap nam: ");
            while (true)
            {
                IsYear = int.TryParse(Console.ReadLine(), out year);
                if (IsYear && 1 <= year) break;
                Console.Write("Nam khong hop le! Vui long nhap lai: ");
            }

            //Thong tin thang
            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime firstDay = new DateTime(year, month, 1);
            int startDay = (int)firstDay.DayOfWeek; //DayOfWeek: thu trong tuan, Sun=0, Mon=1,...
            //In lich cua thang 
            Console.WriteLine();
            Console.WriteLine($"Month: {month}/{year}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            Console.WriteLine("---------------------------");
            //In khoang trang truoc ngay dau tien cua thang
            for (int i=0; i<startDay; i++)
            {
                Console.Write("    ");
            }

            //In cac ngay trong thang
            for(int day=1; day<=daysInMonth; day++)
            {
                Console.Write($"{day,2}  ");
                if ((startDay + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n---------------------------");
        }
    }
}
