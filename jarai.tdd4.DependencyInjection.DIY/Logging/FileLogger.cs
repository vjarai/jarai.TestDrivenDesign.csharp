using System.Diagnostics;

namespace jarai.tdd4.DependencyInjection.DIY.Logging
{
    public class FileLogger : ILogger
    {
        public void Write(string msg)
        {

        }

        public FileLogger()
        {
            Debug.WriteLine("Logger Instanz erstellt.");
        }
    }
}