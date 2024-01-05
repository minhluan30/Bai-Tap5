using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap5
{
  class program
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadLine();
        }
        static void menu()
        {
            QLCD quanlyCD = new QLCD();
            int chon = 0;
            do
            {
                Console.WriteLine("-----Chuong trinh quan cao-----");
                Console.WriteLine("1. ThemCD: ");
                Console.WriteLine("2. Tinh gia thanh trung binh: ");
                Console.WriteLine("3. Sap xep CD giam dan them gia thanh: ");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD: ");
                Console.WriteLine("5. Xuat danh CD: ");
                Console.WriteLine("0. Thoat chuong trinh: ");
                Console.WriteLine("--------------------");
                Console.Write("Ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();

                        Console.Write("nhap ma cd: ");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("nhap tua cd: ");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("nhap ca si: ");
                        cd.Casi = Console.ReadLine();
                        Console.Write("nhap so bai hat: ");
                        cd.Sobaihat = int.Parse(Console.ReadLine());
                        Console.Write("nhap gia thanh: ");
                        cd.Dongia = int.Parse(Console.ReadLine());

                        quanlyCD.ThemCD(cd);
                        break;

                    case 2:
                        double kp = quanlyCD.tinhgiatb();
                        Console.WriteLine("gia thanh trung binh : {0:#,##0.00}", kp);
                        break;

                    case 3:
                        quanlyCD.Sapxepgiamthemgiathanh();
                        Console.WriteLine("da sap xep theo gia thanh giam dan");
                        break;

                    case 4:
                        quanlyCD.SapxeptangtheotuaCD();
                        Console.WriteLine("da sap xep theo tua CD");
                        break;

                    case 5:
                        quanlyCD.Xuat();
                        break;
                }
            } while (chon != 0);
        }
    }
}
