using System;
using System.Xml.Linq;

// Define the Pet class
class Pet
{
    // Properties
    public string Type { get; private set; }
    public string Name { get; private set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    // Constructor
    public Pet(string type, string name)
    {
        Type = type;
        Name = name;
        Hunger = 5; // Initial hunger level
        Happiness = 5; // Initial happiness level
        Health = 5; // Initial health level
    }

    // Method to feed the pet
    public void Feed()
    {
        Hunger = Math.Max(0, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} has been fed. Hunger decreased, health increased.");
    }

// Method to play with the pet
public void Play()
{
    Happiness = Math.Min(10, Happiness + 2);
    Hunger = Math.Min(10, Hunger + 1);
    Console.WriteLine($"{Name} is happy! Happiness increased, hunger increased.");
}

// Method to let the pet rest
public void Rest()
{
    Health = Math.Min(10, Health + 2);
    Happiness = Math.Max(0, Happiness - 1);
    Console.WriteLine($"{Name} is resting. Health increased, happiness decreased.");
}
}