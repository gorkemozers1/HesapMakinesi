using System;
using HesapMakinesi;

namespace HesapMakinesi
{
    private class HesapMakinesiBase
    {
        static void Main()
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Hesap Makinesi");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("5. Çıkış");
                Console.Write("Bir işlem seçin: ");
                string secim = Console.ReadLine();

                if (secim == "5")
                {
                    devam = false;
                    continue;
                }

                Console.Write("Birinci sayıyı girin: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double sonuc = 0;

                switch (secim)
                {
                    case "1":
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                    case "2":
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                    case "3":
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                        break;
                    case "4":
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("Sonuç: " + sonuc);
                        }
                        else
                        {
                            Console.WriteLine("Bir sayı 0'a bölünemez!");
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Hesap makinesi kapatılıyor...");
        }
    }
}