namespace MontyHallApp;

class MontyHallSimulator
{
    private const int DoorCount = 3;
    private readonly Random _random = new Random();

    public bool Simulate(bool changeDoor)
    {
        var carDoor = _random.Next(DoorCount);
        var playerChoice = _random.Next(DoorCount);
        int openDoor;
        do
        {
            openDoor = _random.Next(DoorCount);
        } while (openDoor == carDoor || openDoor == playerChoice);

        if (changeDoor)
        {
            playerChoice = DoorCount - playerChoice - openDoor;
        }
        return playerChoice == carDoor;
    }

    public void RunSimulations(int numberOfSimulations, bool changeDoor)
    {
        var results = Enumerable.Range(0, numberOfSimulations).Select(_ => Simulate(changeDoor));
        var wins = results.Count(win => win);
        var winsPercent = (double)wins / numberOfSimulations * 100;

        Console.WriteLine($"Out of {numberOfSimulations}, there were {wins} wins.");
        Console.WriteLine($"Win percentage: {winsPercent}%");
    }
}

