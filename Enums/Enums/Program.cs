class Program
{

//Define an enum Suits with values for Hearts, Spades, Diamonds, and Clubs.
    enum Suits
    {
            //cast an enum value to an int by doing(int) in front of the variable.
            //Then you can use that int as an index in your string or array.
        Hearts,
        Spades,
        Diamonds,
        Clubs,
    }

    //Create a method DrawAce(Suits suit) that draws an ASCII graphic of
    //an ace of that suit (use one of the symbols ♥♠♦♣ 


    //When the suit 'heart' is called as a parametre, the console should output '♥'
    static string DrawAce(Suits suit)
    {
        //'symbols' is an array of strings.
        string[] symbols = { "♥", "♠", "♦", "♣"};

        //Suits is an integer that contains the integer stored within the parametres.
             int selectedSuit = (int)suit;
        return symbols[selectedSuit];


            //Cast an enum value to an int by doing (int) in front of the variable

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