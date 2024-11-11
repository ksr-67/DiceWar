namespace DiceWar;

public class Dice
{
    public int Value { get; set; }

    public void Roll()
    {
        System.Random rnd = new Pcg.PcgRandom();
        this.Value = rnd.Next(1, 7);
    }

    public virtual int Point()
    {
        return this.Value;
    }

    public override string ToString()
    {
        return $"[{this.Value}]";
    }



}
