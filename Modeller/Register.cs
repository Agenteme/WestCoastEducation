namespace WestCoastEducation;

public class Register
{
    public List<Kurs> Kurser { get; set; } = [];
    public List<Studerande> Studenter { get; set; } = [];
    public List<Lärare> Personal { get; set; } = [];

    public void LäggTillKurs(Kurs kurs)
    {
        foreach (var sammakurs in Kurser)
        {
            if (sammakurs.Kursnummer == kurs.Kursnummer)
            {
                Console.WriteLine($"Kursnummer {kurs.Kursnummer} finns redan i registret.");
            }
        }
        Kurser.Add(kurs);
    }

    public void ListaKurser()
    {
        Console.WriteLine("\nKurser:");
        foreach (var kurs in Kurser)
        {
            Console.WriteLine($"{kurs}");
        }
    }
    public void LäggTillStudent(Studerande student)
    {
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

    public void LäggTillPersonal(Lärare personal)
    {
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
}