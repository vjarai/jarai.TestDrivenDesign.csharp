namespace jarai.tdd4.DependencyInjection.DIY.Application;

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