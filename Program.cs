namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        var student1 = new Studerande("Anna", "Svensson", "0701234567", "900101-1234", "Storgatan 1", "41263", "Göteborg");
        var lärare1 = new Lärare ("Emma", "Larsson", "0737077196", "561130-0543", "Satgatan 38", "23451", "Arlöv", "Historia");
        var utbildningsledare1 = new Utbildningsledare("Hans", "Danielsson", "0703429874", "790515-4335", "The Gata 34", "25435", "Malmö", "Naturkunskap", new DateTime(2015, 9, 27));
        var administratör1 = new Administratör("Sven", "Martinsson", "0403738589", "670328-3412", "Rotgatan 2", "25430", "Kläggeröd", "Franska", new DateTime(2024, 4, 12));
        var klassrumskurs1 = new Klassrumskurs(101, "Webbutveckling", 10, Tidsenhet.Veckor, new DateTime(2026, 11, 2), new DateTime(2027, 1, 15));
        var distanskurs1 = new Distanskurs(101, "SO", 3, Tidsenhet.Dagar, new DateTime(2026, 10, 2), new DateTime(2026, 10, 05));
        Console.WriteLine(student1);
        Console.WriteLine(lärare1);
        Console.WriteLine(utbildningsledare1);
        Console.WriteLine(administratör1);
        Console.WriteLine(klassrumskurs1);
        Console.WriteLine(distanskurs1);
    }
}