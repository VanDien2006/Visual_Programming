using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH2_24520300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            bool IsAnInteger;
            while (true)
            {
                Console.WriteLine("==============MENU==============");
                Console.WriteLine("1. Bai 1");
                Console.WriteLine("2. Bai 2");
                Console.WriteLine("3. Bai 3");
                Console.WriteLine("4. Bai 4");
                Console.WriteLine("5. Bai 5");
                Console.WriteLine("6. Thoat");
                Console.WriteLine("================================");
                Console.Write("Moi nguoi nhap lua chon (1-6): ");
                
                while (true)
                {
                    IsAnInteger = int.TryParse(Console.ReadLine(), out Number);
                    if(IsAnInteger && 1<= Number && Number <= 6)
                    {
                        break;
                    }
                    Console.Write("Lua chon khong hop le! Vui long nhap lai: ");
                }

                switch (Number)
                {
                    case 1: Bai01.Run(); break;
                    case 2: Bai02.Run(); break;
                    case 3: Bai03.Run(); break;
                    case 4: Bai04.Run(); break;
                    case 5: Bai05.Run(); break;
                    default:
                        Console.WriteLine("Cam on quy khach da dung phan mem.");
                        return;
                }
                Console.WriteLine("\nNhan Enter de quay lai menu...");
                Console.ReadLine();
            }
        }
    }
}
