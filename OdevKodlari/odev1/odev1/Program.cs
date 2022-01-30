using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            // İndexof() Metodu kullanarak girilen cümlede aranan harften kaç adet olduğunu bulan program
            Console.WriteLine("Cümle giriniz: ");
            string Indexcumle = Console.ReadLine();
            int baslangicNoktasi = 0;
            Console.WriteLine("Aranacak harf giriniz: ");
            string harf = Console.ReadLine();
            int bulunanHarfSayisi = 0;
            while (Indexcumle.IndexOf(harf, baslangicNoktasi) != -1)
            {
                int bulunanIndex = Indexcumle.IndexOf(harf, baslangicNoktasi);
                Console.Write(bulunanIndex + ",");
                bulunanHarfSayisi++;
                bulunanIndex++;
                baslangicNoktasi = bulunanIndex;
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Girdiginiz cümlede {bulunanHarfSayisi} adet {harf}' harfi bulundu.");
            
             
             
            

            // Contains() Metodu kullanarak girilen cümlede aranan kelimenin oldup olmadığını bulan program.
            Console.WriteLine("Cümle giriniz: ");
            string containsCumle = Console.ReadLine();
            Console.WriteLine("Aranacak kelime giriniz: ");
            string containsKelime = Console.ReadLine();

            if (containsCumle.Contains(containsKelime))
            {
                Console.WriteLine("Aranan kelime bulundu");
            }
            else
            {
                Console.WriteLine("Aranan kelime bulunamadı");
            }

                



        }
    }
}
