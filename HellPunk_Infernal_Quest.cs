using System;

class HellpunksInfernalQuest
{
    static void Main()
    {
        Console.WriteLine("Welcome to Hellpunk's Infernal Quest!");
        Console.WriteLine("You, Hellpunk, the demon of rock, find yourself inside Mammon's castle...");

        int health = 100;  // Health of the demon
        int guitarPower = 0;  // Power level of Hellpunk's guitar

        while (health > 0)
        {
            // Displaying available actions
            Console.WriteLine("\nChoose your infernal action:");
            Console.WriteLine("1. Rock out in Mammon's chambers");
            Console.WriteLine("2. Rest in the fiery pit");
            Console.WriteLine("3. Confront Mammon's minions");
            Console.WriteLine("4. Search for the stolen guitar in Mammon's treasury");
            Console.WriteLine("5. Check your demonic powers");
            Console.WriteLine("6. Quit");

            // Reading the player's choice
            string userInput = Console.ReadLine();

            // Responding to the player's choice
            switch (userInput)
            {
                case "1":
                    RockOutInChambers(ref health, ref guitarPower);
                    break;
                case "2":
                    RestInFieryPit(ref health);
                    break;
                case "3":
                    ConfrontMammonsMinions(ref health, ref guitarPower);
                    break;
                case "4":
                    SearchForStolenGuitar(ref health, ref guitarPower);
                    break;
                case "5":
                    CheckDemonicPowers(ref guitarPower);
                    break;
                case "6":
                    Console.WriteLine("Thanks for rocking out! Goodbye.");
                    return;
                default:
                    Console.WriteLine("Invalid demonic choice. Try again.");
                    break;  // Added break statement here
            }
        }

        Console.WriteLine("Game Over! Hellpunk's infernal journey ends here.");
    }

    // Action: Rock out in Mammon's chambers
    static void RockOutInChambers(ref int health, ref int guitarPower)
    {
        Console.WriteLine("You unleash the power of your demonic guitar in Mammon's chambers...");

        // Simulate gaining power and possibly losing health
        guitarPower += 15;
        health -= 10;

        DisplayDemonicStatus(health, guitarPower);
    }

    // Action: Rest in the fiery pit
    static void RestInFieryPit(ref int health)
    {
        Console.WriteLine("You find solace and rejuvenate in the fiery pit...");

        // Simulate healing during rest
        health += 20;

        DisplayDemonicStatus(health, 0);  // Corrected the DisplayDemonicStatus call
    }

    // Action: Confront Mammon's minions
    static void ConfrontMammonsMinions(ref int health, ref int guitarPower)
    {
        Console.WriteLine("You boldly confront Mammon's minions...");

        // Simulate the battle outcome
        guitarPower += 10;

        DisplayDemonicStatus(health, guitarPower);
    }

    // Action: Search for the stolen guitar in Mammon's treasury
    static void SearchForStolenGuitar(ref int health, ref int guitarPower)
    {
        Console.WriteLine("You sneak into Mammon's treasury in search of your stolen guitar...");

        // Simulate finding the guitar and gaining power
        guitarPower += 25;

        DisplayDemonicStatus(health, guitarPower);
    }

    // Action: Check demonic powers
    static void CheckDemonicPowers(ref int guitarPower)
    {
        Console.WriteLine("You check your demonic powers...");

        // Displaying the power level of Hellpunk's guitar
        Console.WriteLine($"Current Guitar Power Level: {guitarPower}");
    }

    // Displaying demonic status
    static void DisplayDemonicStatus(int health, int guitarPower)
    {
        Console.WriteLine($"Your demonic health: {health}");
        Console.WriteLine($"Your demonic guitar power: {guitarPower}");

        if (health <= 0)
        {
            Console.WriteLine("Game Over! Hellpunk's infernal journey ends here.");
        }
    }
}
