namespace WestCoastEducation;

public class Klassrumskurs : Kurs
{
    public Klassrumskurs(int kursnummer, string kurstitel, int kurslängd, Tidsenhet tidsenhet, DateTime startdatum, DateTime slutdatum) :
    base(kursnummer, kurstitel, kurslängd, tidsenhet, startdatum, slutdatum)
    {
        
    }
    protected override string Kurstyp => "Klassrumskurs";
}
