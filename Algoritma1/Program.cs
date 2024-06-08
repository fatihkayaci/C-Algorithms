namespace Algoritma1;

class Program
{
    static void Main(string[] args)
    {
        Employee e = new Employee();
        Console.WriteLine("Lütfen Müşteri ID'i Giriniz:");
        e.id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen Müşteri Full Name Giriniz:");
        e.fullName=Console.ReadLine();
        Console.WriteLine("Lütfen Müşteri Yaşını Giriniz:");
        e.age=Convert.ToInt32(Console.ReadLine());
        
        Console.ReadLine();
    }
}
