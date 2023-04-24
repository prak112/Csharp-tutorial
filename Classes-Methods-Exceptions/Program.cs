using static Book;

namespace Classes
{
    public class Classes
    {

        public static void Main(string[] args)
        {
            try
            {
                #region Guessing Game

                Console.WriteLine(@"
---Welcome to Guessing Game---
Summary:
- 5 guesses limit
- Hint : children's favourite cartoon
");
                string secretWord = "pikachu";
                string guess = "";
                int guessLimit = 5;
                int guessCount = 0;

                while (secretWord != guess & guessCount <= guessLimit)
                {
                    Console.Write("Enter the secret word : ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                if (guessCount > guessLimit) { Console.WriteLine($"\nOops! Out of guesses..\nSecret word was {secretWord}"); }
                else { Console.WriteLine("\nYou guessed it!"); }

                #endregion

                #region ExponentMethod

                Console.WriteLine(@"
---Welcome to Exponent Magic---
Summary:
- Enter 2 numbers
- Get the result as '1st number powered to 2nd num'
");
                Console.WriteLine("Enter base number : ");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter power : ");
                int power = int.Parse(Console.ReadLine());

                Console.WriteLine($"Result of {baseNum} to the power of {power} = {GetPowerOf(baseNum, power)}");

                #endregion

                #region Book-Classes&Objects
                Console.WriteLine("\n---Welcome to Classes & Objects---\n");

                // book object #1
                Book pokebook = new Book("Bulbasaur", "PokeGoddess", "Vegeterian, bull-like and tortoise-like pokemon", 10);              
                // book object #2
                Book pokebook2 = new Book("Charmander", "PokeGoddess", "Carnivrous reptile, velociraptor-like pokemon", 10);
                // book object with no arguments
                Book pokebook3 = new Book();
                
                Console.WriteLine("\n");
                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex.Message);
            }     
        }

        public static int GetPowerOf(int baseNum, int power) 
        {
            int poweredNum = 1;
            for (int i = 0; i < power; i++)
            {
                poweredNum *= baseNum;
            }
            return poweredNum;
            throw new ArgumentException();
        }

    }

}