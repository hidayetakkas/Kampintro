using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 =new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOranı = 56;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOranı = 82;

           // Console.WriteLine(kurs1.kursAdı + kurs1.egitmen);
            Kurs[] kurslar = new Kurs[]{kurs1, kurs2, kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmen);
            }

        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }

    }
}
