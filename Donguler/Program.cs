using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
            string kurs2 = "Programlama başlangıç için temel kurs";
            string kurs3 = "Java";

            //array -dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Yetiştirme Kampı" ,
            "Programlama başlangıç için temel kurs","Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            Console.WriteLine("For bitti.");

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
