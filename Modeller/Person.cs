namespace WestCoastEducation;

public abstract class Person
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
        Personnummer = personnummer;
        Telefonnummer = telefonnummer;
        Adress = adress;
        Postnummer = postnummer;
        Ort = ort;
    }
    public override string ToString()
    {
        return $"Förnamn: {Förnamn} Efternamn: {Efternamn} Personnummer: ({Personnummer}), Adress: {Adress}, Postnummer: {Postnummer} Ort: {Ort}, Telefon: {Telefonnummer}";
    }
}