using System;

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

    // Method to display pet's status
    public void DisplayStatus()
    {
        Console.WriteLine($"Pet Status:\nName: {Name}\nType: {Type}\nHunger: {Hunger}/10\nHappiness: {Happiness}/10\nHealth: {Health}/10");
    }
}
// Main class
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Virtual Pet Game!");

        // Pet creation
        Console.Write("Choose a pet type (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();
        Console.Write("Enter the pet's name: ");
        string petName = Console.ReadLine();

        Pet pet = new Pet(petType, petName);
        Console.WriteLine($"Welcome, {pet.Name} the {pet.Type}!");
        // Main interaction loop
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Let the pet rest");
            Console.WriteLine("4. Check pet's status");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }

            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.Rest();
                    break;
                case 4:
                    pet.DisplayStatus();
                    break;
                case 5:
                    exit = true;
                    break;
            }
        }

        Console.WriteLine("Thank you for playing!");
    }
}