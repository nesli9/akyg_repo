using System;

public class evrenselkod
{
    public static void Main(string[] args)
    {
        int sonuc = 0;
 
        Console.WriteLine("Toplama İşlemi İçin +");
        Console.WriteLine("Çıkarma İşlemi İçin -");
        Console.WriteLine("Çarpma İşlemi İçin *");
        Console.WriteLine("Bölme İşlemi İçin /");
        Console.Write("Yapmak İstediğiniz işlemi Seçin : ");
        char secim = Convert.ToChar(Console.ReadLine());
 
        Console.Write("1.değeri girin : ");
        int sayi1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("2.değeri girin : ");
        int sayi2 = Convert.ToInt16(Console.ReadLine());
        
        switch (secim)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplama işlemini sonucu : {0}", sonuc);
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Çıkarma işleminin sonucu : {0}", sonuc);
                break;
            case '*':
                
                break;
            case '/':
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Bölme işleminin sonucu : {0}", sonuc);
                
                break;
            default:
                Console.WriteLine("Hatalı Seçim Yaptınız");
                break;
        }
    }
}
