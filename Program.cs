namespace DiceWar;
using Pcg;
class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.StartGame(5, 5);
    }
}
