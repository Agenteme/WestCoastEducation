namespace WestCoastEducation;

public class Utbildningsledare : Lärare
{
    public DateTime Anställningsdatum { get; set; }
    public Utbildningsledare(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort, string kunskapsområde, DateTime anställningsdatum) :
    base(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort, kunskapsområde)
    {
        Anställningsdatum = anställningsdatum;
    }
    protected override string Roll => "Utbildningsledare";
    public override string ToString()
    {
        return $"{base.ToString()}, Anställningsdatum: {Anställningsdatum:yyyy-MM-dd}";
    }
}