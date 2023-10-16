﻿using jarai.tdd4.DependencyInjection.DIY.Logging;

namespace jarai.tdd4.DependencyInjection.DIY.Application;

public class Versandservice
{
    public Versandservice(ILogger logger)
    {
        Logger = logger;
    }

    public ILogger Logger { get; set; }
}