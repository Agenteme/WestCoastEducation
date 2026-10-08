namespace WestCoastEducation;

public class Studerande : Person
{
    public List<Kurs> BokadeKurser { get; set; } = [];
    public Studerande(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort) :
    base(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort)
    {
        
    }
    public void BokaKurs(Kurs kurs)
    {
        foreach (var sammaKurs in BokadeKurser)
        {
            if (sammaKurs.Kursnummer == kurs.Kursnummer)
            {
                Console.WriteLine($"Elev är redan bokad på {kurs.Kursnummer}.");
                return;
            }
        }
        kurs.KursDeltagare.Add(this);
        BokadeKurser.Add(kurs);
    }
    protected override string Roll => "Studerande";
}