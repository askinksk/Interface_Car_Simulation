internal class Program
{
    private static void Main(string[] args)
    {
       Araba araba = new Araba();
        araba.Calistir();
        araba.VitesDegistir(2);
        araba.Sur();
        araba.ParkEt();
        araba.Durdur();
        Console.ReadKey();
    }
}
public interface IArabaSur
{
    void Calistir();
    void Sur();
    void VitesDegistir(int vites);
    void ParkEt();
    void Durdur();
}

public class Araba : IArabaSur
{
    public void Calistir()
    {
        Console.WriteLine("Araç çalıştırıldı");
    }
    public void VitesDegistir(int vites)
    {
        Console.WriteLine(vites.ToString() + ". vitese geçildi");
    }
    public void Sur()
    {
        Console.WriteLine("Fazla hız yapmadan sürmeye devam et");
    }
    public void ParkEt()
    {
        Console.WriteLine("Geldik.  Dikkatlice park et");
    }
    public void Durdur()
    {
        Console.WriteLine("Motoru durdur.");
    }

    

    

    
}