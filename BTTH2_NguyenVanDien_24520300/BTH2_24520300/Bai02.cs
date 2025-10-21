using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class Bai02
    {
        public static void TapTinVaThuMuc(DirectoryInfo path)
        {
            try
            {
                DirectoryInfo[] dirs = path.GetDirectories();
                FileInfo[] files = path.GetFiles();

                foreach (DirectoryInfo dir in dirs)
                {
                    Console.WriteLine($"{dir.CreationTime:dd/MM/yyyy hh:mm tt} {"     <DIR>     "} {dir.Name,-30}");
                    TapTinVaThuMuc(dir);
                }
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"{file.CreationTime:dd/MM/yyyy hh:mm tt} {file.Length,15:N0} {file.Name,-30}");
                }
            }
            catch (UnauthorizedAccessException) { }
        }
        public static long DungLuong(DirectoryInfo path)
        {
            long tongbytes = 0;
            try
            {
                DirectoryInfo[] dirs = path.GetDirectories();
                FileInfo[] files = path.GetFiles();


                foreach (FileInfo file in files)
                {
                    tongbytes += file.Length;
                }
                foreach (DirectoryInfo dir in dirs)
                {
                    tongbytes += DungLuong(dir);
                }
            }
            catch (UnauthorizedAccessException) 
            { 
            
            }
            return tongbytes;
        }
        public static void Run()
        {
            Console.Write("Nhap duong dan thu muc: ");
            string str = Console.ReadLine();
            if (str.Length == 0)
            {
                Console.WriteLine("Duong dan rong!");
                return;
            }

            DirectoryInfo strFile = new DirectoryInfo(str);
            if (!strFile.Exists)
            {
                Console.WriteLine("Khong tim thay thu muc");
                return;
            }
            else
            {
                TapTinVaThuMuc(strFile);
                int SoLuongTapTin = strFile.GetFiles("*", SearchOption.AllDirectories).Length;
                int SoLuongThuMuc = strFile.GetDirectories("*", SearchOption.AllDirectories).Length;

                long DungLuongDaDung = DungLuong(strFile);
                DriveInfo drive = new DriveInfo(strFile.Root.FullName);
                long DungLuongTrong = drive.AvailableFreeSpace;

                Console.WriteLine($"     {SoLuongTapTin} File(s) {DungLuongDaDung:N0} bytes");
                Console.WriteLine($"     {SoLuongThuMuc} Dir(s) {DungLuongTrong:N0} bytes free");
            }
        }
    }
}
