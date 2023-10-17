﻿namespace jarai.tdd5.DependencyInjection.DIY.Application;

public class Lagerverwaltung
{
    public Lagerverwaltung(Bestellservice bestellservice, Versandservice versandservice)
    {
        Bestellservice = bestellservice;
        Versandservice = versandservice;
    }

    public Bestellservice Bestellservice { get; set; }

    public Versandservice Versandservice { get; set; }
}