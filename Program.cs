internal class Program
{enum Islemler{
         Toplama=1,
         Cikarma=2,
         Carpma=3,
         Bolme=4
        }
    private static void Main(string[] args)
    {
        Console.WriteLine("Dort islem sihirbazına hosgeldiniz:");
        Console.WriteLine("İslem numaraları:");
        Console.WriteLine("1-Toplama\n2-Cikarma\n3-Carpma\n4-Bolme\n");
        

        Console.WriteLine("Lutfen islem numarasını giriniz:");
        var secim = (Islemler)Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Birinci sayiyi giriniz:");
        var n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ikinci sayiyi giriniz:");
        var n2 = Convert.ToInt32(Console.ReadLine());



        switch (secim) {
            case Islemler.Toplama: Console.WriteLine($"{n1} + {n2} = {n1+n2}");break;
            case Islemler.Cikarma: Console.WriteLine($"{n1} - {n2} = {n1 - n2}");break;
            case Islemler.Carpma:  Console.WriteLine($"{n1} * {n2} = {n1 * n2}"); break;
            case Islemler.Bolme: Console.WriteLine($"{n1} / {n2} = {n1 / n2}"); break;
            default: Console.WriteLine("\aHatali giris!");break;
        }



    }
}