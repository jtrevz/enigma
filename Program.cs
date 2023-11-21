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
        if (this.GetPairCount() < 10 && !this.ContainsChar(val1) && !this.ContainsChar(val2))
        {
            Pairs.Add(new int[] { val1, val2 });
        }
    }
    public bool ContainsChar(int val)
    {
        foreach (int[] pair in Pairs)
        {
            if (pair[0] == val || pair[1] == val)
            {
                return true;
            }
        }
        return false;
    }
    public int Pass(int value)
    {
        foreach (int[] pair in Pairs)
        {
            if (pair[0] == value) return pair[1];
            if (pair[1] == value) return pair[0];
        }
        return value;
    }


}



