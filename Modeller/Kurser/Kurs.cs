namespace WestCoastEducation;

using System.Text.Json.Serialization;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "typ")]
[JsonDerivedType(typeof(Klassrumskurs), "klassrum")]
[JsonDerivedType(typeof(Distanskurs), "distans")]
public abstract class Kurs : IMittInterface
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
    [JsonIgnore]
    public Lärare? AnsvarigLärare { get; set; }
    [JsonIgnore]
    public List <Studerande> KursDeltagare { get; set; } = [];
    private string ListaStudenterIKurs()
    {
        if (KursDeltagare.Count == 0)
        {
            return "Inga anmälda elever till kursen";
        }
        string elever = "";
        foreach (var student in KursDeltagare)
        {
            elever += $"{student.Förnamn} {student.Efternamn}, ";
        }
        return elever.TrimEnd(',', ' ');
    }
    public abstract KursForm Kurstyp { get; }
    public override string ToString()
    {
        return $@"Kurstyp: {Kurstyp}, Kursnummer: {Kursnummer}, Kurstitel: {Kurstitel}, Kurslängd: {Kurslängd} {Tidsenhet.ToString().ToLower()}, 
        Startdatum: {Startdatum:yyyy-MM-dd}, Slutdatum: {Slutdatum:yyyy-MM-dd}, Lärare: {AnsvarigLärare?.Förnamn} {AnsvarigLärare?.Efternamn},
        Elever: {ListaStudenterIKurs()}";
    }
    public string Presentera()
    {
        return ToString();
    }
}