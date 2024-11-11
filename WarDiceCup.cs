namespace DiceWar;

public class WarDiceCup
{

    public List<WarDice> Dices { get; set; }
    public WarDiceCup(int count)
    {
        this.Dices = new List<WarDice>();
        for (int i = 0; i < count; i++)
        {

            this.Dices.Add(new WarDice());
        }
    }

    public void RollAll()
    {
        foreach (var item in Dices)
        {
            item.Roll();
        }
    }

    public int Point()
    {
        int i = 0;
        foreach (var item in Dices)
        {
            i += item.Point();
        }
        return i;
    }

    public override string ToString()
    {
        string x = string.Empty;
        foreach (var item in Dices)
        {
            x += $"[{item.Value}] ";
        }
        return x;
    }





}