//Keyboard 
//Incoming letter to code/ outgoing code back to letter
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

//Rotor Class

//Plugboard Class