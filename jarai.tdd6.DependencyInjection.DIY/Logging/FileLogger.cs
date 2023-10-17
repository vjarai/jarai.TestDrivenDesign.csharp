using System.Diagnostics;

namespace jarai.tdd6.DependencyInjection.DIY.Logging;

public class FileLogger : ILogger
{
    public FileLogger()
    {
        Debug.WriteLine("Logger Instanz erstellt.");
    }

    public void Write(string msg)
    {
    }
}