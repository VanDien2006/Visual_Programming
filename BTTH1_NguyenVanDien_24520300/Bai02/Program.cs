using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. Viết chương trình nhập số nguyên dương n, tính tổng các số nguyên tố < n và
xuất kết quả ra màn hình.
*/
namespace Bai02
{
    internal class Program
    {
        static bool soNguyenTo(int n)
        {
            if (n < 2) return false;
            for(int i=2; i*i<=n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static int TongCacSoNguyenToBeHonn(int n)
        {
            int sum = 0;
            for(int i=2; i<n; i++)
            {
                if (soNguyenTo(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen duong n: ");
            bool check = false;
            string input;
            do
            {
                if (check == true) Console.Write("Gia tri cua n khong hop le! Nhap lai: ");
                input = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(input, out n)) || !(n > 0));
            int sum = TongCacSoNguyenToBeHonn(n);
            Console.WriteLine("Tong cac so nguyen to be hon n la: {0}", sum);
            Console.ReadLine();
        }
    }
}
