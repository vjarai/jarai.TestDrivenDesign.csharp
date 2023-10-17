﻿namespace jarai.tdd6.DependencyInjection.DIY.Application;

public class UserInterface
{
    public UserInterface(ViewModel viewModel)
    {
        ViewModel = viewModel;
    }

    public ViewModel ViewModel { get; set; }
}