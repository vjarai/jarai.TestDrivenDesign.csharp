using System.Diagnostics;

namespace jarai.tdd5.DependencyInjection.DIY.Logging;

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