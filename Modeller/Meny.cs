namespace WestCoastEducation;

public class Meny
{
    public static void HuvudMeny(Register register)
    {
        bool körMeny = true;
        while (körMeny)
        {
            Console.WriteLine("=== Westcoast Education ===");
            Console.WriteLine("1. Lista Kurser");
            Console.WriteLine("2. Lista Studenter");
            Console.WriteLine("3. Lista Personal");
            Console.WriteLine("4. Lägg till Student");
            Console.WriteLine("0. Stäng av");
            string? knappval = Console.ReadLine();

            switch (knappval)
            {
                case "1":
                    register.ListaKurser();
                    break;
                case "2":
                    register.ListaStudenter();
                    break;
                case "3":
                    register.ListaPersonal();
                    break;
                case "4":
                    LäggTillStudent(register);
                    break;
                case "0":
                    körMeny = false;
                    break;
                default:
                    Console.WriteLine("Nähädu, felaktig inmatning, prova igen\n");
                    break;
            }
        }
    }
    private static string LäsInmatning(string fråga)
    {
        Console.Write(fråga);
        return Console.ReadLine() ?? "";
    }
    private static void LäggTillStudent(Register register)
{
    Console.WriteLine("\n--- Lägg till student ---");
    string förnamn = LäsInmatning("Förnamn: ");
    string efternamn = LäsInmatning("Efternamn: ");
    string telefon = LäsInmatning("Telefon: ");
    string personnummer = LäsInmatning("Personnummer: ");
    string adress = LäsInmatning("Adress: ");
    string postnummer = LäsInmatning("Postnummer: ");
    string ort = LäsInmatning("Ort: ");

    var student = new Studerande(förnamn, efternamn, telefon, personnummer, adress, postnummer, ort);
    register.SkapaStudentData(student);
    Console.WriteLine("Studenten är tillagd.\n");
}
}
