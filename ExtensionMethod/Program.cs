using System.Runtime.CompilerServices;

namespace ExtensionMethod;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(7.Karesi());

        Console.WriteLine(3.Uzeri(4));
    }

}

public static class Sayi
{
    public static int Karesi(this int sayi)
    {
        return sayi * sayi;
    }
    public static int Uzeri(this int sayi, int sayi2)
    {
        return (int)Math.Pow(sayi, sayi2);
    }
}