﻿namespace jarai.tdd4.DependencyInjection.DIY.Application;

public class ViewModel
{
    public ViewModel(Lagerverwaltung lagerverwaltung, Buchhaltung buchhaltung)
    {
        Lagerverwaltung = lagerverwaltung;
        Buchhaltung = buchhaltung;
    }

    public Buchhaltung Buchhaltung { get; set; }

    public Lagerverwaltung Lagerverwaltung { get; set; }
}