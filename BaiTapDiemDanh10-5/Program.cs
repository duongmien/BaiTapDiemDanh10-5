using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapDiemDanh10_5
{
    class Program
    {
      
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

        public static void Timsolanxuathien(int [] so_234, int [] dem_234)
        {
            for (int i = 0; i < 10; i++)
                so_234[i] = 1;


            for (int i = 0; i < 10 - 1; i++)
                for ( int j = i + 1; j < 10; j++)
                    if (so_234[i] == so_234[j])
                        dem_234[i]++;

            int max_234 = dem_234[0];
            int name_234 = so_234[0];

            for (int i = 1; i < 10; i++)
                if (max_234 < dem_234[i])
                {
                    max_234 = dem_234[i];
                    name_234 = so_234[i];
                }

            Console.WriteLine("\nPhan tu xuat hien nhieu nhat:"+ name_234 +"voi so lan:"+max_234);

        }

        public static void sapXepGiamDan(int[] st_234)
        {
            int tg;
            for (int i = 0; i < 10; i++)
                for (int j = i + 1; j < 10; j++)
                    if (st_234[i] < st_234[j])
                    {
                        tg = st_234[i];
                        st_234[i] = st_234[j];
                        st_234[j] = tg;
                    }
            Console.Write("\nSap xep giam dan: ");
            xuat(st_234);
        }
        public static void sapXepTangDan(int[] st_234)
        {
            int tg;
            for (int i = 0; i < 10; i++)
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
            int[] so_234 = new int[10];
            int[] dem_234 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nhap so thu " + (i + 1));
                so_234[i] = int.Parse(Console.ReadLine());
            }
            minMax(so_234);
            Console.WriteLine();
            sapXepGiamDan(so_234);
            sapXepTangDan(so_234);
            Timsolanxuathien(so_234,dem_234);
            Console.ReadLine();
        }
    }
}
