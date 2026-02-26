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
}
 public virtual string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}, Habitat: {Habitat}, Diet: {DietType}, Color: {Color}, Weight: {Weight} kg";
    }

    public abstract string TypeName { get; }}
public class Mammal : Animal
{
    public bool HasFur { get; }

    public override string TypeName
    {
        get { return "Mammal"; }
    }

    public Mammal(string name, int age, string habitat, string dietType, string color, double weight, bool hasFur)
        : base(name, age, habitat, dietType, color, weight)
    {
        HasFur = hasFur;
    }

    public override string GetInfo()
    {
        string furText = HasFur ? "yes" : "no";
        return $"Type: {TypeName}, {base.GetInfo()}, Has Fur: {furText}";
    }
}
public class Bird : Animal
{
    public double WingSpan { get; }

    public override string TypeName
    {
        get { return "Bird"; }
    }

    public Bird(string name, int age, string habitat, string dietType, string color, double weight, double wingSpan)
        : base(name, age, habitat, dietType, color, weight)
    {
        WingSpan = wingSpan;
    }

    public override string GetInfo()
    {
        return $"Type: {TypeName}, {base.GetInfo()}, Wingspan: {WingSpan} m";
    }
}
public class Fish : Animal
{
    public string WaterType { get; }

    public override string TypeName
    {
        get { return "Fish"; }
    }

    public Fish(string name, int age, string habitat, string dietType, string color, double weight, string waterType)
        : base(name, age, habitat, dietType, color, weight)
    {
        WaterType = waterType;
    }

    public override string GetInfo()
    {
        return $" Type: {TypeName}, {base.GetInfo()}, Water Type: {WaterType}";
    }
}
public class Reptile : Animal
{
    public bool IsVenomous { get; }

    public override string TypeName
    {
        get { return "Reptile"; }
    }

    public Reptile(string name, int age, string habitat, string dietType, string color, double weight, bool isVenomous)
        : base(name, age, habitat, dietType, color, weight)
    {
        IsVenomous = isVenomous;
    }

    public override string GetInfo()
    {
        string venomText = IsVenomous ? "yes" : "no";
        return $" Type: {TypeName}, {base.GetInfo()}, Venomous: {venomText}";
    }
}
public class Amphibian : Animal
{
    public string SkinMoisture { get; }

    public override string TypeName
    {
        get { return "Amphibian"; }
    }

    public Amphibian(string name, int age, string habitat, string dietType, string color, double weight, string skinMoisture)
        : base(name, age, habitat, dietType, color, weight)
    {
        SkinMoisture = skinMoisture;
    }

    public override string GetInfo()
    {
        return $" Type: {TypeName},{base.GetInfo()}, Skin Moisture: {SkinMoisture}";
    }
}
