using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 20;
            int sayi2 = 30;
            sayi1 = sayi2;
            //sayı1 ???  30


            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            //sayılar1[0]  ??  999
        }
    }
}
