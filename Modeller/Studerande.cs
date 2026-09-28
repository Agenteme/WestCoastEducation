namespace WestCoastEducation;

public class Studerande : Person
{
    public Studerande(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort) :
    base(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort)
    {
        
    }
    protected override string Roll => "Studerande";
    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}