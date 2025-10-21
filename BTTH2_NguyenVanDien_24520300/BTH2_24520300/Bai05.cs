using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class Bai05
    {
        public static void Run()
        {
            Console.Write("Nhap so luong khu dat: ");
            int n; bool str_n;
            while (true)
            {
                str_n = int.TryParse(Console.ReadLine(), out n);
                if (str_n && n > 0) break;
                Console.Write("So luong khu dat khong hop le! Nhap lai: ");
            }
            List<KhuDat> ds = new List<KhuDat>();

            //1. Nhập danh sách các thông tin(Khu đất, Nhà phố, Chung Cư) cần quản lý.
            NhapDanhSach(ds, n);

            //2. Xuất danh sách các thông tin(Khu đất, Nhà phố, Chung Cư) cần quản lý.
            Console.WriteLine("\nCac khu dat la: ");
            XuatDanhSach(ds);

            //3. Xuất tổng giá bán cho 3 loại (Khu đất, Nhà phố, Chung Cư) của công ty
            //Đại Phú.
            Console.WriteLine("\nTong gia ban theo loai la: ");
            TongGiaBanTheoLoai(ds);

            //4. Xuất danh sách các khu đất có diện tích > 100m2 hoặc là nhà phố mà có
            //diện tích > 60m2 và năm xây dựng >= 2019(nếu có).
            Console.WriteLine("\nCac khu dat thoa man dieu kien loc la: ");
            XuatTheoYeuCau(ds);

            //5. Nhập vào các thông tin cần tìm kiếm(địa điểm, giá, diện tích).Xuất thông
            //tin danh sách tất cả các nhà phố hoặc chung cư phù hợp yêu cầu.
            TimKiem(ds);

        }
        static void NhapDanhSach(List<KhuDat> ds, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Cac loai khu dat:");
                Console.WriteLine("1. NhaPho");
                Console.WriteLine("2. ChungCu");
                Console.WriteLine("--------------------------");
                Console.Write("Nhap lua chon: ");
                int LuaChon;
                bool str_luachon;
                while (true)
                {
                    str_luachon = int.TryParse(Console.ReadLine(), out LuaChon);
                    if (str_luachon && (LuaChon == 1 || LuaChon == 2)) break;
                    Console.Write("Lua chon khong hop le! Nhap lai: ");
                }
                if (LuaChon == 1)
                    ds.Add(new NhaPho());
                else if (LuaChon == 2)
                    ds.Add(new ChungCu());
                ds[i].Nhap();
            }
        }
        static void XuatDanhSach(List<KhuDat> ds)
        {
            for(int i=0; i<ds.Count; i++)
            {
                ds[i].Xuat();
            }
        }
        static void TongGiaBanTheoLoai(List<KhuDat> ds)
        {
            int SumKhuDat = 0;
            int SumNhaPho = 0;
            int SumChungCu = 0;

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] is NhaPho)
                    SumNhaPho += ds[i].GetGiaBan();
                else
                    SumChungCu += ds[i].GetGiaBan();
            }
            SumKhuDat = SumNhaPho + SumChungCu;
            Console.WriteLine($"Tong gia ban ca hai loai khu dat: {SumKhuDat}");
            Console.WriteLine($"Tong gia ban nha pho: {SumNhaPho}");
            Console.WriteLine($"Tong gia ban chung cu: {SumChungCu}");
        }
        static void XuatTheoYeuCau(List<KhuDat> ds)
        {
            bool check = true;
            for(int i=0; i<ds.Count; i++)
            {
                if (ds[i].GetDienTich()>100)
                {
                    check = false;
                    ds[i].Xuat();
                }
                else if(ds[i] is NhaPho)
                {
                    var temp = (NhaPho)ds[i];
                    if (temp.GetDienTich() > 60 && temp.GetNamXayDung() >= 2019)
                    {
                        check = false;
                        ds[i].Xuat();//temp.Xuat();
                    }
                }
            }
            if (check == true)
            {
                Console.WriteLine("Khong co khu dat thoa man dieu kien!");
            }
        }
        static void TimKiem(List<KhuDat> ds)
        {
            Console.Write("Nhap chuoi dia diem can tim: ");
            string diadiem = Console.ReadLine();

            Console.Write("Nhap gia toi thieu: ");
            int gia; bool str_gia;
            while (true)
            {
                str_gia = int.TryParse(Console.ReadLine(), out gia);
                if (str_gia && gia > 0) break;
                Console.Write("Gia toi thieu khong hop le! Nhap lai: ");
            }

            Console.Write("Nhap dien tich toi da: ");
            double dientich; bool str_dientich;
            while (true)
            {
                str_dientich = double.TryParse(Console.ReadLine(), out dientich);
                if (str_dientich && dientich > 0) break;
                Console.Write("Dien tich toi da khong hop le! Nhap lai: ");
            }

            Console.WriteLine("Cac khu dat thoa man dieu kien tim kiem la: ");
            bool check = false;
            for (int i = 0; i < ds.Count; i++)
            {
                
                if ((ds[i].GetDiaDiem().ToLower() == diadiem.ToLower()) && ds[i].GetGiaBan() <= gia && ds[i].GetDienTich() >= dientich)
                {
                    check = true;
                    ds[i].Xuat();
                }
            }
            if (check == false)
            {
                Console.WriteLine("Khong tim thay khu dat thoa man!");
            }
        }
    }
}
