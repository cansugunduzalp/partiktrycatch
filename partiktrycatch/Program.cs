using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz:");

        try
        {
            // Kullanıcının girdiği değeri alıyoruz
            string input = Console.ReadLine();

            // Kullanıcının girdiği değeri sayıya dönüştürmeye çalışıyoruz
            int sayi = int.Parse(input);

            // Sayının karesini hesaplayıp ekrana yazdırıyoruz
            int kare = sayi * sayi;
            Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
        }
        catch (FormatException)
        {
            // Eğer kullanıcı geçersiz bir giriş yaparsa
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
