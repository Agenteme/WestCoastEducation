namespace WestCoastEducation;

public class Lärare : Person
{
    public string Kunskapsområde { get; set; }
    public List<Kurs> AnsvarigaKurser { get; set; } = [];
    public Lärare(string förnamn, string efternamn, string telefonnummer, string personnummer, string adress, string postnummer, string ort, string kunskapsområde) :
    base(förnamn, efternamn, telefonnummer, personnummer, adress, postnummer, ort)
    {
        Kunskapsområde = kunskapsområde;
    }
    protected override string Roll => "Lärare";
    public override string ToString()
    {
        return $"{base.ToString()}, Kunskapsområde: {Kunskapsområde}";
    }
}