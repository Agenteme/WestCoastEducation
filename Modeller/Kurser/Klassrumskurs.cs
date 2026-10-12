namespace WestCoastEducation;

public class Klassrumskurs : Kurs
{
    public int Salsnummer { get; set; }
    public Klassrumskurs(int kursnummer, string kurstitel, int kurslängd, Tidsenhet tidsenhet, DateTime startdatum, DateTime slutdatum, int salsnummer) :
    base(kursnummer, kurstitel, kurslängd, tidsenhet, startdatum, slutdatum)
    {
        Salsnummer = salsnummer;
    }
    public override KursForm Kurstyp => KursForm.Klassrum;
    public override string ToString()
    {
        return $"{base.ToString()}, Salsnummer: {Salsnummer}";
    }
}
