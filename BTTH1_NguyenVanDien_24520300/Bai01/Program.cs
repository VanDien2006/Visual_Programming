using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Viết chương trình cho phép tạo mảng một chiều gồm n số nguyên ngẫu nhiên.
Cài đặt hàm thực hiện các chức năng sau:
a. Tính tổng các số lẻ trong mảng
b. Đếm số nguyên tố trong mảng
c. Tìm số chính phương nhỏ nhất (nếu không có hàm trả về -1)
*/
namespace Bai01
{
    internal class Program
    {
        static void Nhap(int n, List<int> myList)
        {
            Random ngauNhien = new Random();
            for (int i=0; i<n; i++)
            {
                int number = ngauNhien.Next(-100, 100);
                myList.Add(number);
            }
        }
        static int TongSoLe(List<int> myList)
        {
            int sum = 0;
            foreach (int number in myList)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
        static bool soNguyenTo(int number)
        {
            if (number < 2) return false;
            for(int i=2; i*i<=number; i++)
            {
                if (number%i == 0) return false;
            }
            return true;
        }
        static int SoLuongSoNguyenTo(List<int> myList)
        {
            int count = 0;
            foreach(int number in myList)
            {
                if (soNguyenTo(number))
                {
                    count++;
                }
            }
            return count;
        }
        static int SoChinhPhuongNhoNhat(List<int> myList)
        {
            int result = -1;
            foreach(int number in myList)
            {
                if (number < 0) continue;
                int sqrtNumber = (int)Math.Sqrt(number);
                if (Math.Pow(sqrtNumber, 2) == number)
                {
                    if (result == -1) 
                    { 
                        result = number;
                    }
                    else
                    {
                        if(number < result)
                        {
                            result = number;
                        }
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cho mang: ");
            int n;
            bool check = false;
            string input;
            do
            {
                if (check == true)
                {
                    Console.Write("So luong phan tu cua mang khong hop le! Nhap lai: ");
                }
                input = Console.ReadLine();
                check = true;
            }
            while (!int.TryParse(input, out n) || !(n>0));

            List<int> myList = new List<int>(n);
            Nhap(n, myList);
           
            //a. Tinh tong so le trong mang
            int sum = TongSoLe(myList);
            Console.WriteLine("Tong so le trong mang: {0}", sum);
            //b. Dem so nguyen to trong mang
            int count= SoLuongSoNguyenTo(myList);
            Console.WriteLine("So luong so nguyen to trong mang: " + count);
            //c. So chinh phuong nho nhat
            int x = SoChinhPhuongNhoNhat(myList);
            Console.WriteLine("So chinh phuong nho nhat: " + x);
            Console.ReadLine();
        }
    }
}
