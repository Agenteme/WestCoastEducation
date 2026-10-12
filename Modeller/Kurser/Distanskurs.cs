namespace WestCoastEducation;

public class Distanskurs : Kurs
{
    public string Plattform { get; set; }
    public Distanskurs(int kursnummer, string kurstitel, int kurslängd, Tidsenhet tidsenhet, DateTime startdatum, DateTime slutdatum, string plattform) :
    base(kursnummer, kurstitel, kurslängd, tidsenhet, startdatum, slutdatum)
    {
        Plattform = plattform;
    }
    public override KursForm Kurstyp => KursForm.Distans;
    public override string ToString()
    {
        return $"{base.ToString()}, Plattform: {Plattform}";
    }
}
