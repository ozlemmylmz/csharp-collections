using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList asal = new();
            ArrayList asalOlmayan = new();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}.sayıyı giriniz :", i);
                int sayi = int.Parse(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Lütfen pozitif sayı giriniz : ");
                    i--;
                    continue;
                }

                if (sayi.AsalSayıMı())
                    asal.Add(sayi);

                else
                    asalOlmayan.Add(sayi);

            }
            asal.Sort();
            asal.Reverse();
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            Console.WriteLine("Asal Sayılar");
            foreach (var item in asal)
                Console.Write(item + "-");

            Console.WriteLine(" ");
            Console.WriteLine("Asal Olmayan Sayılar");
            foreach (var item in asalOlmayan)
                Console.Write(item + "-");

            Console.WriteLine("Asal olanların sayısı:"+asal.Count);
            Console.WriteLine("Asal olmayanların sayısı:"+ asalOlmayan.Count);
        }

        public static int[] NTaneSayiAl(int n)
        {
            List<int> sayiListesi = new();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}-Sayi ");
                int sayi = int.Parse(Console.ReadLine());

                sayiListesi.Add(sayi);
            }

            return sayiListesi.ToArray();
        }

    }
    static class Extension
    {
        public static bool AsalSayıMı(this int n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {

                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;

        }
    }
}
