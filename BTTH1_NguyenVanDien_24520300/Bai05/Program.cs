using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.viết chương trình nhập vào ngày tháng năm, cho biết thứ trong tuần.
namespace Bai05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date;
            string str_date="dd/MM/yyyy";
            string temp;
            Console.Write("Nhap ngay (dd/mm/yyyy): ");
            while (true)
            {
                temp = Console.ReadLine();
                if (DateTime.TryParseExact(temp, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    break;
                }
                Console.Write("Dinh dang khong hop le! Nhap lai: ");
            }
            Console.WriteLine("Thu trong tuan cua ngay {0} la: {1}", date.ToString("dd/MM/yyyy"), date.DayOfWeek);
            Console.ReadLine();
        }
    }
}
