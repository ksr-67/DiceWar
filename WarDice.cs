namespace DiceWar;

public class WarDice : Dice
{
    public override int Point()
    {
        return this.Value % 2 == 0 ? this.Value : this.Value * 2;
    }
}
