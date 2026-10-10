namespace WestCoastEducation;

public class Studerande : Person
{
    public List<Kurs> BokadeKurser { get; set; } = [];
    public Studerande(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort) :
    base(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort)
    {
        
    }
    public void BokaKurs(Kurs kursAttBoka)
    {
        foreach (var Kurs in BokadeKurser)
        {
            if (Kurs.Kursnummer == kursAttBoka.Kursnummer)
            {
                Console.WriteLine($"Elev är redan bokad på {kursAttBoka.Kursnummer}.");
                return;
            }
        }
        kursAttBoka.KursDeltagare.Add(this);
        BokadeKurser.Add(kursAttBoka);
    }
    protected override string Roll => "Studerande";
}