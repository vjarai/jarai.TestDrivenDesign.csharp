﻿namespace jarai.tdd6.AutoFixture;

public class Car
{
    public Person Owner { get; set; }

    public void AssignOwner(Person owner)
    {
        Owner = owner;
    }
}