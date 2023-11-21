//Keyboard 
//Incoming letter to code/ outgoing code back to letter
// Keyboard k = new Keyboard();
// char input1 = 'C';
// char input2 = 'e';

// int index1 = k.EncodeLetter(input1);
// int index2 = k.EncodeLetter(input2);
// Console.WriteLine(index1);
// Console.WriteLine(index2);


// Console.WriteLine(k.DecodeKey(index1));
// Console.WriteLine(k.DecodeKey(index2));


public class Keyboard
{
    public string Alphabet { get; }
    public Keyboard()
    {
        Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
    public int EncodeLetter(char letter)
    {
        letter = char.ToUpper(letter);

        if (Alphabet.Contains(letter))
        {
            return Alphabet.IndexOf(letter);
        }
        else
        {
            throw new ArgumentException("The input is not a valid keyboard letter");
        }
    }
    public char DecodeKey(int key)
    {
        return Alphabet[key];
    }
}

