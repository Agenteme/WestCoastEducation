namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        var student1 = new Studerande("Anna", "Svensson", "0701234567", "900101-1234", "Storgatan 1", "41263", "Göteborg");
        var lärare1 = new Lärare ("Emma", "Larsson", "0737077196", "561130-0543", "Satgatan 38", "23451", "Arlöv", "Historia");
        var utbildningsledare1 = new Utbildningsledare("Hans", "Danielsson", "0703429874", "790515-4335", "The Gata 34", "25435", "Malmö", "Naturkunskap", new DateTime(2015, 9, 27));
        Console.WriteLine(student1);
        Console.WriteLine(lärare1);
        Console.WriteLine(utbildningsledare1);

    }
}