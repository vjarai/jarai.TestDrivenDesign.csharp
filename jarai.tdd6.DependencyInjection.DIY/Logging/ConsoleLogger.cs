using System.Diagnostics;

namespace jarai.tdd6.DependencyInjection.DIY.Logging;

public class ConsoleLogger : ILogger
{
    public ConsoleLogger()
    {
        Debug.WriteLine("Logger Instanz erstellt.");
    }

    public void Write(string msg)
    {
        Debug.WriteLine(msg);
    }
}