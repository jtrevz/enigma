
public class Rotor
{
    public int[] Wiring { get; set; }
    public int Notch;
    public int RotorOrder;
    public int Index;

    public Rotor(int rotor, int order)
    {
        RotorOrder = order;
        Index = 0;
        switch (rotor)
        {
            case 0:
                Wiring = new int[] { 11, 9, 12, 5, 6, 15, 7, 3, 16, 25, 22, 13, 0, 8, 23, 24, 20, 2, 18, 21, 19, 16, 17, 9, 1, 14, 10, 4 };
                Notch = 16;
                break;
            case 1:
                Wiring = new int[] { 0, 9, 3, 10, 15, 23, 16, 6, 19, 24, 2, 20, 8, 12, 18, 7, 1, 11, 5, 22, 17, 25, 13, 4, 21, 14 };
                Notch = 4;
                break;
            case 2:
                Wiring = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 2, 23, 17, 19, 21, 25, 24, 23, 8, 6, 4, 2, 0, 22, 20, 18, 16, 14, 12, 10 };
                Notch = 21;
                break;
            case 3:
                Wiring = new int[] { 4, 18, 14, 15, 15, 25, 9, 0, 24, 20, 16, 10, 23, 7, 1, 24, 21, 17, 8, 11, 12, 13, 22, 5, 19, 6, 2 };
                Notch = 9;
                break;
            case 4:
                Wiring = new int[] { 21, 25, 1, 17, 6, 23, 7, 8, 19, 12, 3, 13, 15, 14, 11, 0, 22, 9, 24, 20, 16, 10, 4, 2, 5, 18 };
                Notch = 25;
                break;
            default:
                Wiring = new int[26];
                break;
        }
    }
    //Pass to and fron functions
    // step/turn
    // internal or external next step implementation
}

