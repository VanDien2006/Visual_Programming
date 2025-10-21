using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class Bai04
    {
        public static void Run()
        {
            //1. Viết chương trình nhập vào hai
            //phân số, xuất ra các giá trị là tổng, hiệu, tích và thương của hai phân số này.
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            Console.WriteLine("Nhap phan so a"); a.Nhap();
            Console.WriteLine("Nhap phan so b"); b.Nhap();
            Console.Write("\nKet qua a + b = "); (a + b).Xuat();
            Console.Write("\nKet qua a - b = "); (a - b).Xuat();
            Console.Write("\nKet qua a * b = "); (a * b).Xuat();
            if (b.Tu == 0) 
                Console.WriteLine("\nKhong chia duoc cho phan so co tu bang 0");
            else
            {
                Console.Write("\nKet qua a / b = "); 
                (a / b).Xuat();
            }

            //2. Viết chương trình cho phép nhập vào một dãy các phân số:
            //-Tìm phần số lớn nhất
            //-Sắp xếp các phân số trong dãy tăng dần
            Console.Write("\nNhap so luong phan so: ");
            bool str_n;
            int n;
            while (true)
            {
                str_n = int.TryParse(Console.ReadLine(), out n);
                if (str_n) break;
                Console.Write("Tu so khong hop le! Nhap lai: ");
            }
            List<PhanSo> list = new List<PhanSo>(n);
            Console.WriteLine("Nhap cac phan so cho day phan so");
            for (int i = 0; i < n; i++)
            {
                PhanSo temp = new PhanSo();
                temp.Nhap();
                list.Add(temp);
            }

            Console.WriteLine("\nDanh sach phan so la: ");
            for(int i=0; i<n; i++)
            {
                list[i].Xuat();
                Console.WriteLine();
            }
            
            PhanSo max = list.Max();
            Console.Write($"\nPhan so lon nhat la: "); max.Xuat();

            Console.WriteLine("\nPhan so trong day sau khi sap xep tang dan");
            list.Sort();
            for (int i = 0; i < n; i++)
            {
                list[i].Xuat();
                Console.WriteLine();
            }
        }
    }
}
