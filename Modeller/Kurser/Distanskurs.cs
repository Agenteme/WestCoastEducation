namespace WestCoastEducation;

public class Distanskurs : Kurs
{
    public Distanskurs(int kursnummer, string kurstitel, int kurslängd, Tidsenhet tidsenhet, DateTime startdatum, DateTime slutdatum) :
    base(kursnummer, kurstitel, kurslängd, tidsenhet, startdatum, slutdatum)
    {
        
    }
    protected override string Kurstyp => "Distanskurs";
}
