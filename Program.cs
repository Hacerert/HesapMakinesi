using System;
class HesapMakinesi
{
    public static void Main(string[] args)
    {
        int sonuc1, sayi3 = 0, sayi4 = 0, sayi;
        double sonuc2 = 0, sayi1 = 0, sayi2 = 0;
        Console.Write("Yapmak istediğiniz işlemi giriniz:");
        Console.WriteLine("Toplama için" + "1");
        Console.WriteLine("Çıkarma için" + "2");
        Console.WriteLine("Çarpma için" + "3");
        Console.WriteLine("Bölme için" + "4");
        Console.WriteLine("Mod Almak için" + "5");
        Console.WriteLine("Çıkış için" + "0");
        string islem = Console.ReadLine();
        if (islem != "1" && islem != "2" && islem != "3" && islem != "4" && islem != "5" && islem != "0")
        {
            Console.WriteLine("Lütfen geçerli işlem seçiniz!!!");
            return;
        }
        if (islem == "1" || islem == "2" || islem == "3" || islem == "4")
        {
            Console.Write("1.sayiyi giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sayiyi giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());
        }
        if (islem == "5")
        {
            Console.WriteLine("Birinci sayiyi giriniz:");
            sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayiyi giriniz:");
            sayi4 = Convert.ToInt32(Console.ReadLine());
        }
        switch (islem)
        {
            case "1"://Toplama
                sonuc2 = sayi1 + sayi2;
                Console.WriteLine("Toplama Sonucu:" + sonuc2);
                break;
            case "2"://Çıkarma
                sonuc2 = sayi1 - sayi2;
                Console.WriteLine("Çıkarma Sonucu:" + sonuc2);
                break;
            case "3"://Çarpma
                sonuc2 = sayi1 * sayi2;
                Console.WriteLine("Çarpma sonucu:" + sonuc2);
                break;
            case "4"://Bölme
                sonuc2 = sayi1 / sayi2;
                Console.WriteLine("Bölme sonucu:" + sonuc2);
                break;
            case "5"://Mod alma
                sonuc1 = sayi3 % sayi4;
                Console.WriteLine("Mod alma sonucu:" + sonuc1);
                break;
        }
        do
        {
            Console.WriteLine("Bir sayı girin:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi != 0)
            {
                Console.WriteLine("Girilen sayi" + sayi);
            }
        } while (sayi != 0);
        Console.WriteLine("Program sona erdi.");
        try
        {
            if (islem == "4")
            {
                sonuc2 = sayi1 / sayi2;
                Console.WriteLine("Sayi 0a bölünemez");
            }
        }
        catch
        {
            Console.WriteLine("Sayısal bilgileri düzgün giriniz:");

        }
    }
}
