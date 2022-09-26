class Program
{

//Define an enum 'Suits' with values for Hearts, Spades, Diamonds, and Clubs.
    enum Suits
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs,
    }

    //Create a method DrawAce(Suits suit) that draws one of the symbols ♥♠♦♣
    static string DrawAce(Suits suit)
    {
        //'symbols' is an array of strings.
        string[] symbols = { "♥", "♠", "♦", "♣"};

        //Suits is an integer that contains the integer stored within the parametres.
             int selectedSuit = (int)suit;

        //Returns the 'symbols' stored in the value equivilant to 'selectedSuit'.
        return symbols[selectedSuit];

    }


    static void Main(string[] args)
    {
        Console.WriteLine(".___.");
        Console.WriteLine("I   I");
        Console.Write("I ");
        Console.Write(DrawAce(Suits.Hearts));
        Console.WriteLine(" I");
        Console.WriteLine("I   I");
        Console.WriteLine(".___.");
    }
}