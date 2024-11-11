namespace DiceWar;

public class Game
{
    private WarDiceCup playerCup;
    public WarDiceCup PlayerCup
    {
        get { return playerCup; }
        set { playerCup = value; }
    }

    private WarDiceCup computerCup;

    public WarDiceCup ComputerCup
    {
        get { return computerCup; }
        set { computerCup = value; }
    }

    public int PlayerPoint { get; private set; }
    public int ComputerPoint { get; private set; }

    public Game()
    {
        PlayerPoint = 0;
        ComputerPoint = 0;
        computerCup = new WarDiceCup(0);
        playerCup = new WarDiceCup(0);
    }

    public void PlayRound()
    {
        PlayerCup.RollAll();
        ComputerCup.RollAll();
        PlayerPoint += PlayerCup.Point();
        ComputerPoint += ComputerCup.Point();
    }

    public void StartGame(int numberOfDices, int rounds)
    {

        PlayerCup = new WarDiceCup(numberOfDices);
        ComputerCup = new WarDiceCup(numberOfDices);
        for (int i = 0; i < rounds; i++)
        {
            PlayRound();
            System.Console.WriteLine($"Round {i + 1}");
            System.Console.WriteLine($"Player\t rolled {PlayerCup.ToString()}a total of : {PlayerCup.Point()}");
            System.Console.WriteLine($"Computer rolled {ComputerCup.ToString()}a total of : {ComputerCup.Point()}");
            System.Console.WriteLine();
        }
        System.Console.WriteLine("--- Game Over ---");
        System.Console.WriteLine($"Player\t total points: {PlayerPoint}");
        System.Console.WriteLine($"Computer total points: {ComputerPoint}");

    }

}