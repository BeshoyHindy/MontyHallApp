// See https://aka.ms/new-console-template for more information

using MontyHallApp;

while (true)
{
    var numberOfSimulations = GetSimulationCount();
    var changeDoor = GetChangeDoorPreference();

    var simulator = new MontyHallSimulator();
    simulator.RunSimulations(numberOfSimulations, changeDoor);
}

static int GetSimulationCount()
{
    while (true)
    {
        Console.Write("Enter the number of simulations: ");
        if (int.TryParse(Console.ReadLine(), out var numberOfSimulations) && numberOfSimulations > 0)
        {
            return numberOfSimulations;
        }
        Console.WriteLine("Please enter a valid number greater than 0.");
    }
}

static bool GetChangeDoorPreference()
{
    while (true)
    {
        Console.Write("Change door? [yes/no]: ");
        var input = Console.ReadLine()?.ToLower();
        if (input == "yes") return true;
        if (input == "no") return false;

        Console.WriteLine("Please answer with 'yes' or 'no'");
    }
}

