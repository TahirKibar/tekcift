using System;

class Program
{
    static void Main()
    {
        Console.Write("0 ile 10 arasında bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        switch (sayi)
        {
            case 0: Console.WriteLine("SIFIR"); break;
            case 1: Console.WriteLine("BİR"); break;
            case 2: Console.WriteLine("İKİ"); break;
            case 3: Console.WriteLine("ÜÇ"); break;
            case 4: Console.WriteLine("DÖRT"); break;
            case 5: Console.WriteLine("BEŞ"); break;
            case 6: Console.WriteLine("ALTI"); break;
            case 7: Console.WriteLine("YEDİ"); break;
            case 8: Console.WriteLine("SEKİZ"); break;
            case 9: Console.WriteLine("DOKUZ"); break;
            case 10: Console.WriteLine("ON"); break;
            default: Console.WriteLine("Geçersiz sayı!"); break;
        }
    }
}

