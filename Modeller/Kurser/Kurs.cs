namespace WestCoastEducation;

public abstract class Kurs
{
    public int Kursnummer { get; set; }
    public string Kurstitel { get; set; }
    public int Kurslängd { get; set; }
    public Tidsenhet Enhet { get; set; }
    public DateTime Startdatum { get; set; }
    public DateTime Slutdatum { get; set; }

    protected Kurs(int kursnummer, string kurstitel, int kurslängd, DateTime startdatum, DateTime slutdatum)
    {
        Kursnummer = kursnummer;
        Kurstitel = kurstitel;
        Kurslängd = kurslängd;
        Startdatum = startdatum;
        Slutdatum = slutdatum;
    }
}