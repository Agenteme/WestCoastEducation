namespace WestCoastEducation;

public abstract class Person : IMittInterface
{
    public string Förnamn { get; set; }
    public string Efternamn { get; set; }
    public string Telefonnummer { get; set; }
    public string Personnummer { get; set; }
    public string Adress { get; set; }
    public string Postnummer { get; set; }
    public string Ort { get; set; }

    protected Person(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort)
    {
        Förnamn = förnamn;
        Efternamn = efternamn;
        Telefonnummer = telefonnummer;
        Personnummer = personnummer;
        Adress = adress;
        Postnummer = postnummer;
        Ort = ort;
    }
    protected virtual string Roll => "Person";
    public override string ToString()
    {
        return $"Roll: {Roll}, Förnamn: {Förnamn}, Efternamn: {Efternamn}, Telefon: {Telefonnummer}, Personnummer: {Personnummer}, Adress: {Adress}, Postnummer: {Postnummer}, Ort: {Ort}";
    }
    public string Presentera()
    {
        return ToString();
    }
}