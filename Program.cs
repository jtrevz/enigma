//Plugboard Class
//Ability to add pairs (left and right?)
//amount of pairs available
Plugboard plugboard = new Plugboard();

plugboard.AddPair(2, 4);
plugboard.AddPair(21, 7);
plugboard.AddPair(12, 14);
plugboard.AddPair(5, 9);
plugboard.AddPair(8, 2);

foreach (int[] pair in plugboard.GetPairs())
{
    Console.WriteLine(pair[0]);
}
public class Plugboard
{
    public List<int[]> Pairs;

    public Plugboard()
    {
        Pairs = new List<int[]>();
    }
    public int GetPairCount()
    {
        return Pairs.Count;
    }
    public void AddPair(int val1, int val2)
    {
        if (this.GetPairCount() < 10)
        {
            Pairs.Add(new int[] { val1, val2 });
        }
    }
    public List<int[]> GetPairs()
    {
        return Pairs;
    }
}

