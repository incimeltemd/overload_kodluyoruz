internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //metot overloading

        Metotlar ornek = new Metotlar();
        ornek.Topla(5, 7, 9, out int toplam);
        Console.WriteLine(toplam);
    }
       
}



class Metotlar
{

    public void Topla (int a, int b, out int toplam)
    {
        toplam = a + b;
    }
    public void Topla(int x, int y, int z,out int toplam)
    {
        toplam=x+y+z;
    }
}