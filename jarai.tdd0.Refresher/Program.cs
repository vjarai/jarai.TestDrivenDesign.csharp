namespace jarai.tdd0.Refresher;

internal class Program
{
    private static void Main(string[] args)
    {
        var meinPkw = new Pkw();
        var meinCabrio = new Cabrio();

        Pkw meinFahrzeug;

        Console.WriteLine("Welches Fahrzeug möchten Sie fahren? (Pkw/Cabrio)");

        if(Console.ReadLine() == "Cabrio")
        {
            meinFahrzeug = meinCabrio;
        }
        else
        {
            meinFahrzeug = meinPkw;
        }
        
        meinFahrzeug.Fahren();

    }
}