using System;

namespace diziler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0]="Mavi";
            dizi[3]= 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
        }
    }
}