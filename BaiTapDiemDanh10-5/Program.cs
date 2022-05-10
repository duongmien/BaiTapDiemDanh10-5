using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapDiemDanh10_5
{
    class Program
    {
        public static void nhapSo()
        {
            int[] so_234 = new int[10];
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Nhap so thu " + (i + 1));
                so_234[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void minMax(int[] st_234)
        {
            int min_234 = st_234[0], max_234 = st_234[0];
            foreach (int a_234 in st_234)
            {
                if (a_234 > max_234)
                    max_234 = a_234;
                if (a_234 < min_234)
                    min_234 = a_234;
            }
            Console.WriteLine("Max la: " + max_234 + "\nMin la: " + min_234);
        }

        public static void count(int[] st_234)
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }

        public static void sapXep(int[] st_234)
        {
            int tg;
            for (int i = 0; i < 9; i++)
                for (int j = i + 1; j < 10; j++)
                    if (st_234[i] < st_234[j])
                    {
                        tg = st_234[i];
                        st_234[i] = st_234[j];
                        st_234[j] = tg;
                    }
            Console.Write("Sap xep giam dan: ");
            xuat(st_234);

            for (int i = 0; i < 9; i++)
                for (int j = i + 1; j < 10; j++)
                    if (st_234[i] > st_234[j])
                    {
                        tg = st_234[i];
                        st_234[i] = st_234[j];
                        st_234[j] = tg;
                    }
            Console.Write("\nSap xep tang dan: ");
            xuat(st_234);
        }
        public static void xuat(int[] st_234)
        {
            foreach (int a_234 in st_234)
            {
                Console.Write(a_234 + " ");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
