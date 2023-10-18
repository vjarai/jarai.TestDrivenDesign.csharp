namespace jarai.tdd6.DependencyInjection.DIY.Application;

/// <summary>
/// Das "Komposition Root Object" der kompletten Anwendung
/// </summary>
public class Applikation
{
    public Applikation(UserInterface userInterface)
    {
        UserInterface = userInterface;
    }

    public UserInterface UserInterface { get; set; }

    public void Run()
    {
        Console.WriteLine("Applikation started...");
    }
}