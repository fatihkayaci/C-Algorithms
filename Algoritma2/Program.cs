
namespace Algoritma2;

class Program
{
    static void Main(string[] args)
    {
        Employee e = new Employee();
        Console.WriteLine("Lütfen Müşteri ID'i Giriniz:");
        e.id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen Müşteri İsim Giriniz:");
        e.Ad=Console.ReadLine();
        Console.WriteLine("Lütfen Müşteri Soy İsim Giriniz:");
        e.SoyAd=Console.ReadLine();    
        Console.WriteLine("Lütfen Müşteri Yaşını Giriniz:");
        e.age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******MÜŞTERİ KİMLİĞİ*******");
        Console.WriteLine("");
        Console.WriteLine(e.id+"-"+e.Ad+" "+e.SoyAd+" "+e.age);
        Console.ReadLine();
    }
}
