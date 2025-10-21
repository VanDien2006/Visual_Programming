using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class Bai03
    {
        public static void NhapMaTran(List<List<int>> matrix, int n, int m)
        {
            Console.WriteLine("Nhap ma tran: ");
            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Nhap hang so {i}");
                List<int> currentRow = new List<int>();
                for(int j=0; j<m; j++)
                {
                    Console.Write($"Nhap [{i},{j}] = ");
                    int temp = int.Parse(Console.ReadLine());
                    currentRow.Add(temp);
                }
                matrix.Add(currentRow);
                Console.WriteLine();
            }
        }
        public static void XuatMaTran(List<List<int>> matrix)
        {
            Console.WriteLine("Ma tran: ");
            if (matrix.Count == 0 || matrix[0].Count == 0)
            {
                Console.WriteLine("Ma tran rong!");
                return;
            }
            foreach (List<int> row in matrix)
            {
                foreach (int a in row)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
        public static void TimKiemPhanTu(List<List<int>> matrix, int x)
        {
            List<(int, int)> Index = new List<(int, int)>();
            for(int i=0; i<matrix.Count; i++)
            {
                for(int j=0; j < matrix[i].Count; j++)
                {
                    if (matrix[i][j] == x)
                    {
                        Index.Add((i, j));
                    }
                }
            }
            if (Index.Count == 0)
            {
                Console.Write($"Khong tim thay {x} trong ma tran!");
            }
            else
            {
                Console.WriteLine($"Cac vi tri tim thay {x}: ");
                foreach(var(i, j) in Index)
                {
                    Console.Write($"[{i},{j}] ");
                }
            }
            Console.WriteLine();
        }
        public static bool laSoNguyenTo(int a)
        {
            if (a < 2) return false;
            for(int i=2; i*i<=a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        public static void XuatSoNguyenTo(List<List<int>> matrix)
        {
            Console.Write("\nCac so nguyen to trong ma tran: ");
            bool check = false;
            foreach(List<int> row in matrix)
            {
                foreach(int i in row)
                {
                    if (laSoNguyenTo(i))
                    {
                        check = true;
                        Console.Write(i + " ");
                    }
                }
            }
            if (check == false)
            {
                Console.Write("khong co!");
            }
            Console.WriteLine();
        }
        public static void DongCoSoLuongSoNguyenToNhieuNhat(List<List<int>> matrix)
        {
            List<int> Index = new List<int>();//Luu cac dong co so luong so nguyen to lon nhat
            int sum = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                int TongSoLuongSoNguyenTo = 0;
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    if (laSoNguyenTo(matrix[i][j]))
                    {
                        TongSoLuongSoNguyenTo++;
                    }
                }
                if (sum == TongSoLuongSoNguyenTo)
                {
                    Index.Add(i);
                }
                else if (sum < TongSoLuongSoNguyenTo)
                {
                    Index.Clear();
                    Index.Add(i);
                    sum = TongSoLuongSoNguyenTo;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine("Khong co dong nao co so nguyen to!");
            }
            else
            {
                Console.Write("\nDong co so nguyen to nhieu nhat trong ma tran: ");
                foreach(var a in Index)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Run()
        {
            //a.Nhập / xuất ma trận hai chiều các số nguyên
            int n, m;
            Console.Write("Nhap so hang cua ma tran: ");
            while (true)
            {
                bool str_n = int.TryParse(Console.ReadLine(), out n);
                if (str_n && n > 0) break;
                Console.Write("So hang cua ma tran khong hop le! Nhap lai: "); ;
            }
            Console.Write("Nhap so cot cua ma tran: ");
            while (true)
            {
                bool str_m = int.TryParse(Console.ReadLine(), out m);
                if (str_m && m > 0) break;
                Console.Write("So cot cua ma tran khong hop le! Nhap lai: "); ;
            }

            List<List<int>> matrix = new List<List<int>>();
            NhapMaTran(matrix, n, m);
            XuatMaTran(matrix);

            //b.Tìm kiếm một phần tử trong ma trận
            Console.Write("Nhap so nguyen x can tim kiem: ");
            int x;
            while (true)
            {
                bool str_x = int.TryParse(Console.ReadLine(), out x);
                if (str_x && x > 0) break;
                Console.Write("So nguyen x khong hop le! Nhap lai: "); ;
            }
            TimKiemPhanTu(matrix, x);

            //c.Xuất các phần tử là số nguyên tố
            XuatSoNguyenTo(matrix);

            //d.Cho biết dòng nào có nhiều số nguyên tố nhất
            DongCoSoLuongSoNguyenToNhieuNhat(matrix);

        }
    }
}
