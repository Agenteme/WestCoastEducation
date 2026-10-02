namespace WestCoastEducation;

public class Administratör : Utbildningsledare
{
    public Administratör(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort, string kunskapsområde, DateTime anställningsdatum) :
    base(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort, kunskapsområde, anställningsdatum)
    {
        
    }
    protected override string Roll => "Administratör";
}