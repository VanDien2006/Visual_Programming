using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
6. Viết chương trình cho phép tạo ma trận chứa các số nguyên ngẫu nhiên gồm n
dòng, m cột. Cài đặt hàm thực hiện các chức năng sau:
a. Xuất ma trận
b. Tìm phần tử lớn nhất/nhỏ nhất
c. Tìm dòng có tổng lớn nhất
d. Tính tổng các số không phải là số nguyên tố
e. Xóa dòng thứ k trong ma trận
f. Xóa cột chứa phần tử lớn nhất trong ma trận
*/

namespace Bai06
{
    internal class Program
    {
        static void Nhap(List<List<int>> matrix, int n, int m)
        {
            Random rand = new Random();
            int minVal = -100;
            int maxVal = 100;
            for (int i = 0; i < n; i++)
            {
                List<int> currentRow = new List<int>();
                for (int j = 0; j < m; j++)
                {
                    int randomNumber = rand.Next(minVal, maxVal + 1);
                    currentRow.Add(randomNumber);
                }
                matrix.Add(currentRow);
            }
        }
        static void Xuat(List<List<int>> matrix)
        {
            if(matrix.Count == 0 || matrix[0].Count == 0)
            {
                Console.WriteLine("Ma tran rong!");
                return;
            }
            foreach(List<int> row in matrix)
            {
                foreach(int a in row)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
        static int maxValue(List<List<int>> matrix)
        {
            int max = matrix[0][0];
            foreach(List<int> row in matrix)
            {
                foreach(int a in row)
                {
                    if (max < a)
                        max = a;
                }
            }
            return max;
        }
        static int minValue(List<List<int>> matrix)
        {
            int min = matrix[0][0];
            foreach (List<int> row in matrix)
            {
                foreach (int a in row)
                {
                    if (min > a)
                        min = a;
                }
            }
            return min;
        }
        static int maxRow(List<List<int>> matrix)
        {
            int maxSumIndex = 0;
            int maxSum = int.MinValue;
            for(int i=0; i<matrix.Count; i++)
            {
                int currentSum = 0;
                for(int j=0; j < matrix[i].Count; j++)
                {
                    currentSum += matrix[i][j];
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    maxSumIndex = i;
                }
            }
            return maxSumIndex;
        }
        static bool laSoNguyenTo(int a)
        {
            if (a < 2) return false;
            for(int i=2; i*i<=a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static int tongCacSoKhongLaNguyenTo(List<List<int>> matrix)
        {
            int sum = 0;
            foreach(List<int> row in matrix)
            {
                foreach(int a in row)
                {
                    if (!laSoNguyenTo(a))
                    {
                        sum += a;
                    }
                }
            }
            return sum;
        }
        static void xoaCotChuaPhanTuMax(List<List<int>>matrix)
        {
            int max = maxValue(matrix);
            //Luu chi so cac cot chua gia tri lon nhat
            List<int> index = new List<int>();
            for(int i=0; i<matrix.Count; i++)
            {
                for(int j=0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] == max && !index.Contains(j))
                    {
                        index.Add(j);
                    }
                }
            }
            //Lan luot xoa cac cot theo chi so giam dan (de khong bi loi)
            index.Sort((a, b) => b.CompareTo(a));//sap xep index giam dan 
            foreach(int i in index)//i la chi so cot can xoa
            {
                foreach(List<int> row in matrix)
                {
                    if (i < row.Count)
                    {
                        row.RemoveAt(i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang cua ma tran: ");
            int n, m;
            string n_str, m_str;
            bool check = false;
            do
            {
                if (check == true) Console.Write("so hang khong hop le! Nhap lai: ");
                n_str = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(n_str, out n)) || !(n>0));
            Console.Write("Nhap so cot cua ma tran: ");
            check = false;
            do
            {
                if (check == true) Console.Write("so cot khong hop le! Nhap lai: ");
                m_str = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(m_str, out m)) || !(m > 0));
            List<List<int>> matrix = new List<List<int>>();
            Nhap(matrix, n, m);

            //a.Xuất ma trận
            Xuat(matrix);

            //b.Tìm phần tử lớn nhất / nhỏ nhất
            int maxElement = maxValue(matrix);
            int minElement = minValue(matrix);
            Console.WriteLine("Gia tri lon nhat trong ma tran la: {0}", maxElement);
            Console.WriteLine("Gia tri nho nhat trong ma tran la: {0}", minElement);

            //c.Tìm dòng có tổng lớn nhất
            int index=maxRow(matrix);
            Console.WriteLine("Dong co tong lon nhat la: {0}", index);

            //d.Tính tổng các số không phải là số nguyên tố
            int sum = tongCacSoKhongLaNguyenTo(matrix);
            Console.WriteLine("Tong cac so khong phai la so nguyen to la: {0}", sum);

            //e.Xóa dòng thứ k trong ma trận
            int k; //k la so nguyen bat dau tu 0
            string k_str;
            Console.Write("Nhap so k la dong can xoa trong ma tran: ");
            check = false;
            do
            {
                if (check == true) Console.Write("so k khong hop le! Nhap lai: ");
                k_str = Console.ReadLine();
                check = true;
            }
            while (!(int.TryParse(k_str, out k)) || !(k >= 0));
            if (k >= n)
            {
                Console.WriteLine("Dong thu k khong ton tai trong matrix!");
            }
            else
            {
                matrix.RemoveAt(k);
                n--;
                Console.WriteLine("Ma tran sau khi xoa dong k");
                Xuat(matrix);
            }

            //f.Xóa cột chứa phần tử lớn nhất trong ma trận
            if(matrix.Count > 0 && matrix[0].Count > 0)
            {
                Console.WriteLine("Ma tran sau khi xoa cot chua phan tu lon nhat");
                xoaCotChuaPhanTuMax(matrix);
                Xuat(matrix);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ma tran khong con du lieu de xoa cot!");
            }
            Console.ReadLine();
        }
    }
}
