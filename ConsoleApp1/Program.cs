using System;
using System.Collections.Generic;

public abstract class Animal
{
    public string Name;
    public int Age;
    public string Habitat;
    public string DietType;
    public string Color;
    public double Weight;

    protected Animal(string name, int age, string habitat, string dietType, string color, double weight)
    {
        Name = name;
        Age = age;
        Habitat = habitat;
        DietType = dietType;
        Color = color;
        Weight = weight;
    }

    