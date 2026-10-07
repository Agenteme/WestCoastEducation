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
    
    public void TilldelaKurs(Kurs kurs)
    {
        if (this is Administratör or Utbildningsledare)
        {
            Console.WriteLine("Administratörer och utbildningsledare handhaver inte kurserna, lägg till en lärare istället");
            return;
        }
        if (kurs.AnsvarigLärare != null)
        {
            Console.WriteLine($"Kurs {kurs.Kursnummer} {kurs.Kurstitel} har redan en tilldelad lärare");
            return;
        }
        kurs.AnsvarigLärare = this;
        AnsvarigaKurser.Add(kurs);
    }

    protected override string Roll => "Lärare";
    public override string ToString()
    {
        return $"{base.ToString()}, Kunskapsområde: {Kunskapsområde}";
    }
}