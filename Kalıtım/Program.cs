using Kalıtım;

namespace Algoritma3;

class Program
{
    static void Main(string[] args)
    {
        Papagan p = new Papagan();
        p.tur = "papağan";
        p.hiz = 50;
        p.isim = "sultan";
        p.renk = "sarı-yeşil";
        p.ses = "cik";
        p.agirlik = 1650;

        Console.WriteLine(p.tur);
        Console.WriteLine(p.isim);
        Console.WriteLine(p.hiz);
        Console.WriteLine(p.renk);
        Console.WriteLine(p.ses);
        Console.WriteLine(p.agirlik);
        Console.ReadLine();
    }
}
