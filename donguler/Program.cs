using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            // array 
            string[] kurslar = new String[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs","Java","Python","C++","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

        }
    }
}
