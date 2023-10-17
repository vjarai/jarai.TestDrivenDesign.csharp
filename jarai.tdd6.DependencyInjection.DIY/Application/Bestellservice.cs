using jarai.tdd6.DependencyInjection.DIY.Logging;

namespace jarai.tdd6.DependencyInjection.DIY.Application;

public class Bestellservice
{
    public Bestellservice(ILogger logger)
    {
        Logger = logger;
    }

    public ILogger Logger { get; set; }
}