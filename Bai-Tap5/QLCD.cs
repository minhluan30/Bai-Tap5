using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap5
{
    class QLCD
    {
        private CD[] ds;
        private int n;

        public QLCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QLCD(int sophantu)
        {
            ds = new CD[100];
            n = 0;
        }
        public void ThemCD(CD cd)
        {
            if (n > ds.Length)
            {
                Console.WriteLine("danh sach da day.");
            }
            else
            {
                if (!kiemtratrungCD(cd.MaCD))
                    ds[n++]= cd;
                else
                {
                    Console.WriteLine("Trung ma CD");
                }
            }
        }
        private bool kiemtratrungCD(int macd)
        {
            for (int i = 0; i < n; i++) 
            {
                if (ds[i].MaCD == macd)
                {
                    return true;
                }
            }
            return false;
        }
        public double tinhgiatb()
        {
            int tonggia = 0;
            for(int i = 0; i < n; i++)
            {
                tonggia += ds[i].Dongia;
            }
            return (double)tonggia / n;
        }
        public void Xuat()
        {
            Console.WriteLine("{0, 10} {1, 30} {2, 30} {3,10} {4, 15}", "MaCD", "Tua CD", "Ca si", "So bai hat", "Gia thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].Tostring());
            }
        }
        public void Sapxepgiamthemgiathanh()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i +1;j <n; j++)
                {
                    if (ds[i].Dongia < ds[i].Dongia)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
        public void SapxeptangtheotuaCD()
        {
            CD tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].TuaCD.CompareTo(ds[j].TuaCD) > 0)
                    {
                        tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }
        }
    }
}
