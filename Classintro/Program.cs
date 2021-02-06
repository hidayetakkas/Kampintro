using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "Engin";
            int yas = 36;
            Kurs kurs1 =new Kurs();
            kurs1.kursAdı = "C#";
            kurs1.egitmen = "Engin Demirog";
            kurs1.izlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdı = "Java";
            kurs2.egitmen = "Kerem";
            kurs2.izlenmeOranı = 56;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdı = "python";
            kurs3.egitmen = "berkay";
            kurs3.izlenmeOranı = 82;

           // Console.WriteLine(kurs1.kursAdı + kurs1.egitmen);
            Kurs[] kurslar = new Kurs[]{kurs1, kurs2, kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdı + " : " + kurs.egitmen);
            }

        }
    }
    class Kurs
    {
        public string kursAdı { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOranı { get; set; }

    }
}
