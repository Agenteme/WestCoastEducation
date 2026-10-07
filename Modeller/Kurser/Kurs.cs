namespace WestCoastEducation;

public abstract class Kurs
{
    public int Kursnummer { get; set; }
    public string Kurstitel { get; set; }
    public int Kurslängd { get; set; }
    public Tidsenhet Tidsenhet { get; set; }
    public DateTime Startdatum { get; set; }
    public DateTime Slutdatum { get; set; }

    protected Kurs(int kursnummer, string kurstitel, int kurslängd, Tidsenhet tidsenhet, DateTime startdatum, DateTime slutdatum)
    {
        Kursnummer = kursnummer;
        Kurstitel = kurstitel;
        Kurslängd = kurslängd;
        Tidsenhet = tidsenhet;
        Startdatum = startdatum;
        Slutdatum = slutdatum;
    }
    public Lärare? AnsvarigLärare { get; set; }
    public Studerande? KursDeltagare { get; set; }
    protected virtual string Kurstyp => "Kurs";
    public override string ToString()
    {
        return $@"Kurstyp: {Kurstyp}, Kursnummer: {Kursnummer}, Kurstitel: {Kurstitel}, Kurslängd: {Kurslängd} {Tidsenhet.ToString().ToLower()}, 
        Startdatum: {Startdatum:yyyy-MM-dd}, Slutdatum: {Slutdatum:yyyy-MM-dd}, Lärare: {AnsvarigLärare?.Förnamn} {AnsvarigLärare?.Efternamn}, 
        Elever: {KursDeltagare?.Förnamn} {KursDeltagare?.Efternamn}";
    }
}