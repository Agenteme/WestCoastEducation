namespace WestCoastEducation;
using System.Text.Json;
public class Register
{
    public List<Kurs> Kurser { get; set; } = [];
    public List<Studerande> Studenter { get; set; } = [];
    public List<Lärare> Personal { get; set; } = [];

    public void LäggTillKurs(Kurs kursAttLäggaTill)
    {
        foreach (var Kurs in Kurser)
        {
            if (Kurs.Kursnummer == kursAttLäggaTill.Kursnummer)
            {
                Console.WriteLine($"Kursnummer {kursAttLäggaTill.Kursnummer} finns redan i registret.");
                return;
            }
        }
        Kurser.Add(kursAttLäggaTill);
    }

    public void ListaKurser()
    {
        Console.WriteLine("\nKurser:");
        foreach (var kurs in Kurser)
        {
            Console.WriteLine($"{kurs}");
        }
    }
    public void SkapaStudentdata(Studerande student)
    {
        foreach(var sammaStudent in Studenter)
        {
            if (sammaStudent.Personnummer == student.Personnummer)
            {
                Console.WriteLine($"Elev med personnummer{student.Personnummer} är redan inskriven på skolan");
                return;
            }
        }
        Studenter.Add(student);
    }
    public void ListaStudenter()
    {
        Console.WriteLine("\nStuderande:");
        foreach (var student in Studenter)
        {
            Console.WriteLine($"{student}");
        }
    }

    public void SkapaPersonaldata(Lärare personal)
    {
        foreach(var sammaPersonal in Personal)
        {
            if (sammaPersonal.Personnummer == personal.Personnummer)
            {
                Console.WriteLine($"Lärare med personnummer {personal.Personnummer} är redan anställd på skolan");
                return;
            }
        }
        Personal.Add(personal);
    }
    public void ListaPersonal()
    {
        Console.WriteLine("\nPersonal:");
        foreach (var personal in Personal)
        {
            Console.WriteLine($"{personal}");
        }
    }
    
    //Json-metoder-grejs
    public void SparaKurserTillJson(string sökväg)
    {
        var inställningar = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(Kurser, inställningar);
        File.WriteAllText(sökväg, json);
        Console.WriteLine($"{Kurser.Count} kurser sparade till {sökväg}");
    }

    public void LäsKurserFrånJson(string sökväg)
    {
        if (!File.Exists(sökväg))
        {
            Console.WriteLine("Filen finns inte.");
            return;
        }
            string json = File.ReadAllText(sökväg);
            var inlästaKurser = JsonSerializer.Deserialize<List<Kurs>>(json);
        if (inlästaKurser == null)
        {
            Console.WriteLine("Kunde inte läsa filen.");
            return;
        }

        foreach (var kurs in inlästaKurser)
        {
            LäggTillKurs(kurs);
        }
    }
}