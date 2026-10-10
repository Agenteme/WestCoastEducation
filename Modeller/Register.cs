namespace WestCoastEducation;

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
    public void SkapaStudentData(Studerande student)
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

    public void LäggTillPersonal(Lärare personal)
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
}