using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz!");
            string n = Console.ReadLine();
            ArrayList sesli = new ArrayList();
            char[] sesliharfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            char[] harfler = new char[n.Length];
            harfler = n.ToCharArray();
            foreach (var item in harfler)
            {
                foreach (char sabit in sesliharfler)
                {
                    if (item == sabit)
                        sesli.Add(item);
                }
            }
            foreach (var item in sesli)
            {
                Console.Write(item + " ");
            }
        }
    }
}
