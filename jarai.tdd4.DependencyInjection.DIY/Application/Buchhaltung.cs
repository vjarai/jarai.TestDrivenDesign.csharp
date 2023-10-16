using jarai.tdd4.DependencyInjection.DIY.Logging;

namespace jarai.tdd4.DependencyInjection.DIY.Application
{
    public class Buchhaltung
    {
        private readonly KontoFactory _factory;

        public Buchhaltung(ILogger logger, KontoFactory factory)
        {
            _factory = factory;
            Logger = logger;

            Konto = _factory.CreateKonto();
        }

        public object Konto { get; set; }

        public ILogger Logger { get; set; }
    }
}