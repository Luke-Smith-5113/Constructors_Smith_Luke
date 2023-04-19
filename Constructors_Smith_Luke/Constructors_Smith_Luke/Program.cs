using System;

namespace Constructors_Smith_Luke
{
    class Game
    {
        //creates Game field and gives it constructors for title and genre with default values
        public Game(string title = "Unknown Title", string genre = "Casual")
        {
            this.Title = title;
            this.Genre = genre;
        }
        //creates a string field
        public string Title
        {
            get; set;
        }
        //creates a string field
        public string Genre
        {
            get; set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //creates a new game object
            Game BotW = new Game("Legend of Zelda: Breathe of the Wild", "Adventure");
            //prints the title and genre
            Console.WriteLine(BotW.Title);
            Console.WriteLine(BotW.Genre);
            //creates a new game object
            Game game = new Game();
            //prints the title and genre
            Console.WriteLine(game.Title);
            Console.WriteLine(game.Genre);
        }
    }
}
