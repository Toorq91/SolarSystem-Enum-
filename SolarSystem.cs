        /*
         Enums = special "class" that contains a set of named integer constants.
         Use enums when you have values that you know will not change.
         To get the integer value from an item, you must explicitly convert to an int

         name = integer 
        //*/
        //Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
        //Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
class Program
{
    static void Main(string[] args)
    {
        var name1 = PlanetNameAndSize(out var radius1, out var volume1, 
            out var name2, out var radius2, out var volume2, 
            out var name3, out var radius3, out var volume3, 
            out var name4, out var radius4, out var volume4, 
            out var name5, out var radius5, out var volume5, 
            out var name6, out var radius6, out var volume6, 
            out var name7, out var radius7, out var volume7, 
            out var name8, out var radius8, out var volume8, 
            out var name9, out var radius9, out var volume9);

        Console.WriteLine("planet: " + name1 + ". radius: " + radius1 + "km. Volume: " + volume1 + "km^3");
        Console.WriteLine("planet: " + name2 + ". radius: " + radius2 + "km. Volume: " + volume2 + "km^3");
        Console.WriteLine("planet: " + name3 + ". radius: " + radius3 + "km. Volume: " + volume3 + "km^3");
        Console.WriteLine("planet: " + name4 + ". radius: " + radius4 + "km. Volume: " + volume4 + "km^3");
        Console.WriteLine("planet: " + name5 + ". radius: " + radius5 + "km. Volume: " + volume5 + "km^3");
        Console.WriteLine("planet: " + name6 + ". radius: " + radius6 + "km. Volume: " + volume6 + "km^3");
        Console.WriteLine("planet: " + name7 + ". radius: " + radius7 + "km. Volume: " + volume7 + "km^3");
        Console.WriteLine("planet: " + name8 + ". radius: " + radius8 + "km. Volume: " + volume8 + "km^3");
        Console.WriteLine("planet: " + name9 + ". radius: " + radius9 + "km. Volume: " + volume9 + "km^3");

        Console.ReadKey();
    }

    private static string PlanetNameAndSize(out int radius1, out double volume1,
        out string name2, out int radius2, out double volume2,
        out string name3, out int radius3, out double volume3,
        out string name4, out int radius4, out double volume4, 
        out string name5, out int radius5, out double volume5,
        out string name6, out int radius6, out double volume6, 
        out string name7, out int radius7, out double volume7, 
        out string name8, out int radius8, out double volume8, 
        out string name9, out int radius9, out double volume9)
    {
        var name1 = Planets.Mercury.ToString();
        radius1 = (int)PlanetRadius.Mercury;
        volume1 = Volume(PlanetRadius.Mercury);
        name2 = Planets.Venus.ToString();
        radius2 = (int)PlanetRadius.Venus;
        volume2 = Volume(PlanetRadius.Venus);
        name3 = Planets.Earth.ToString();
        radius3 = (int)PlanetRadius.Earth;
        volume3 = Volume(PlanetRadius.Earth);
        name4 = Planets.Mars.ToString();
        radius4 = (int)PlanetRadius.Mars;
        volume4 = Volume(PlanetRadius.Mars);
        name5 = Planets.Jupiter.ToString();
        radius5 = (int)PlanetRadius.Jupiter;
        volume5 = Volume(PlanetRadius.Jupiter);
        name6 = Planets.Saturn.ToString();
        radius6 = (int)PlanetRadius.Saturn;
        volume6 = Volume(PlanetRadius.Saturn);
        name7 = Planets.Uranus.ToString();
        radius7 = (int)PlanetRadius.Uranus;
        volume7 = Volume(PlanetRadius.Uranus);
        name8 = Planets.Neptune.ToString();
        radius8 = (int)PlanetRadius.Neptune;
        volume8 = Volume(PlanetRadius.Neptune);
        name9 = Planets.Pluto.ToString();
        radius9 = (int)PlanetRadius.Pluto;
        volume9 = Volume(PlanetRadius.Pluto);
        return name1;
    }

    public static double Volume(PlanetRadius radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }

    enum Planets
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

    internal enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}