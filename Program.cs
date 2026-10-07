using System.Security.Cryptography.X509Certificates;

namespace WestCoastEducation;

class Program
{
    static void Main()
    {
        //Lägg till objekt
        var student1 = new Studerande("Anna", "Svensson", "0701234567", "900101-1234", "Storgatan 1", "41263", "Göteborg");
        var lärare1 = new Lärare ("Emma", "Larsson", "0737077196", "561130-0543", "Satgatan 38", "23451", "Arlöv", "Historia");
        var lärareDublett = new Lärare ("Emma", "Larsson", "0737077196", "561130-0543", "Satgatan 38", "23451", "Arlöv", "Historia");
        var utbildningsledare1 = new Utbildningsledare("Hans", "Danielsson", "0703429874", "790515-4335", "The Gata 34", "25435", "Malmö", "Handledarskap", new DateTime(2015, 9, 27));
        var administratör1 = new Administratör("Sven", "Martinsson", "0403738589", "670328-3412", "Rotgatan 2", "25430", "Kläggeröd", "Administration", new DateTime(2024, 4, 12));
        var klassrumskurs1 = new Klassrumskurs(101, "Webbutveckling", 10, Tidsenhet.Veckor, new DateTime(2026, 11, 2), new DateTime(2027, 1, 15), 1);
        var distanskurs1 = new Distanskurs(105, "Historia", 3, Tidsenhet.Dagar, new DateTime(2026, 10, 2), new DateTime(2026, 10, 05), "Zoom");
        
        //Lägg till objket i listor
        var register = new Register();
        register.LäggTillStudent(student1);
        register.LäggTillPersonal(lärare1);
        register.LäggTillPersonal(lärareDublett);
        register.LäggTillPersonal(utbildningsledare1);
        register.LäggTillPersonal(administratör1);
        register.LäggTillKurs(klassrumskurs1);
        register.LäggTillKurs(distanskurs1);

        //Koppla kurs med lärare
        lärare1.TilldelaKurs(distanskurs1);

        //Visa listor
        register.ListaKurser();
        register.ListaStudenter();
        register.ListaPersonal();
    }
}