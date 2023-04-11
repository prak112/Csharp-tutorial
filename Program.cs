using System.Drawing;
using System.Xml.Linq;

public class freeCodeCamp
{
    public static void Main(string[] args)
    {
        try
        {
            #region Drawing Right-Angled-Triangle

            // ask user input for triangle height
            Console.WriteLine("--Draw Right Angled Triangle---\n\nEnter height of Triangle (units > 1, only) : ");
            int height = int.Parse(Console.ReadLine());

            /* automation logic -
             * tabSpace = height-1 -> iterate with tabSpace--;
             * internalDistance = height-1 -> iterate with internalDistance++;
            */

            // iterate as per above logic
            for (int row = 0; row < height; row++)
            {
                string tabSpace = new string(' ', height - row);
                string internalDistance = new string(' ', row);

                if (row == height - 1)
                {         // base of the triangle
                    string triangleBase = new string('_', height - 1);
                    Console.WriteLine($"{tabSpace}/{triangleBase}|");
                }
                else
                {                           // continuous triangle structure 
                    Console.WriteLine($"{tabSpace}/{internalDistance}|");
                }
            }
            Console.WriteLine("---End Drawing Program----\n");

            #endregion


            #region Variables

            Console.WriteLine("\n---Welcome to Story Mode---\n\n Enter your favourite character name : ");
            // user input for character details
            string charName = Console.ReadLine();
            Console.WriteLine("Enter your character's age : ");
            int charAge = int.Parse(Console.ReadLine());

            Console.WriteLine($@"
Here is your story...
Long long long ago, once upon a time, there lived a lone wolf whose was a non-binary post-apocalyptic survivor, their name was {charName}.
They were walking in the streets of Trondheimhäven, when they were {charAge} years old.
Suddenly, one day...
");
            Console.WriteLine("---End Story Mode---\n");

            #endregion


            #region DataTypes
            Console.WriteLine("\n---Welcome to DataTypes---\n");

            int someNumber = 0;
            double someDecimalDoubleFloat = Math.PI / 10;
            char someChar = 'a';
            string someString = string.Empty;
            bool someBool = false;

            Console.WriteLine($"All defined variables:\ninteger : {someNumber}\ndouble : {someDecimalDoubleFloat}\ncharacter : {someChar}\nstring : {someString}\nboolean : {someBool}");
            Console.WriteLine("\n---End Data Types---\n");
            #endregion


            #region Strings
            Console.WriteLine("\n---Welcome To Strings---\nEnter a string (name, place, animal, thing, etc.) :");
            string userString = Console.ReadLine();
            Console.WriteLine("Choose string format :\n-'l' for LowerCase\n-'u' for UpperCase ");
            string userChoice = Console.ReadLine();

            // string format
            if (userChoice == "l") { Console.WriteLine(userString.ToLower()); }
            else { Console.WriteLine(userString.ToUpper()); }
            Console.WriteLine();

            // string search
            Console.WriteLine("Enter a phrase(name, place, animal, thing, etc.) :");
            string userPhrase = Console.ReadLine();
            Console.WriteLine($"Phrase contains a preposition : {userPhrase.Contains("an")} \n");

            // string index
            Console.WriteLine($"Choose a number within {userPhrase.Length} :");
            int userIndex = int.Parse(Console.ReadLine());
            Console.WriteLine($"You chose the character {userPhrase[userIndex]}");
            Console.WriteLine($"Index of character {userPhrase[10]} is {userPhrase.IndexOf('a')}\n");

            // substrings
            Console.WriteLine("Choose a substring from the above Phrase.\nEnter starting index :");
            int startIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a substring from the above Phrase.\nEnter phrase length :");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chosen substring is : '{userPhrase.Substring(startIndex, length)}'");

            Console.WriteLine("\n---End Strings---\n");
            #endregion


            #region Numbers
            Console.WriteLine("---Welcome to Numbers---\n");
 
            Console.WriteLine($@"
Sum of 5.361 and 4.122 = {{5.361 + 4.122}}
Remainder of 6 and 3.14 = {6 / 3.14}
Result of Math.Abs(-548) = {Math.Abs(-548)}
Result of Math.Pow(5, 3) = {Math.Pow(5, 3)}
Result of Math.Sqrt(9861873) = {Math.Sqrt(9861873)}
Result of Math.Max(54, 2023) = {Math.Max(54, 2023)}
Result of Math.Round(Math.PI, 3) = {Math.Round(Math.PI, 3)}
");
            Console.WriteLine("\n---End Numbers---\n");
            #endregion


            #region UserInput

            Console.WriteLine("\n---Please Note that ALL the above programs included User Input----\n");

            #endregion


            #region Calculator
            // initialize boolean for running app
            bool endApp = false;

            // display title of app
            Console.WriteLine("---Welcome to Calculator in C#---\n");

            // while loop to iterate app operation
            while (!endApp)
            {
                // initialize variables to empty
                string userNum1 = " ";
                string userNum2 = "";
                double result = 0;

                // inner iteration for correct user input
                // first user input - double x
                Console.WriteLine("Enter a number for calculation : ");
                userNum1 = Console.ReadLine();

                double doubleNum1 = 0;
                while (!double.TryParse(userNum1, out doubleNum1))
                {
                    Console.WriteLine("Invalid input! Enter a valid number");
                    userNum1 = Console.ReadLine();
                }

                // second user input - double y
                Console.WriteLine("Enter another number for calculation : ");
                userNum2 = Console.ReadLine();

                double doubleNum2 = 0;
                while (!double.TryParse(userNum2, out doubleNum2))
                {
                    Console.WriteLine("Enter a valid input");
                    userNum2 = Console.ReadLine();
                }

                // user chooses arithmetic operation
                Console.WriteLine(@"
Choose an arithmetic operation from list below :
'a' - addition
's' - subtraction
'm' - multiplication
'd' - division

Your option : ");

                // read user input
                string op = Console.ReadLine();

                // try-catch block to access Calculator_logic Class for calculation
                try
                {
                    result = Calculator.DoOperation(doubleNum1, doubleNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Given input leads to a zero-error operation.");
                    }
                    else Console.WriteLine("Result : {0:0.##}", result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured for the given inputs.\nDetails: " + ex.Message);
                }
                Console.WriteLine("x---------------------x\n");

                // wait for user to end or continue app
                Console.WriteLine("Press 'q' for exit. Press any button to continue.\n");
                if (Console.ReadLine() == "q")
                {
                    endApp = true;
                }

            }

            Console.WriteLine("Buh-bye! Thanks for using the calculator :-)\n----End Calculator---\n");
            #endregion


            #region MadLib
            Console.WriteLine("\n---Welcome to Mad Lib---\n");
            Console.WriteLine("In this Mad Lib, enter the following values -\n");
            
            Console.Write("Enter Color : ");
            string color = Console.ReadLine();

            Console.Write("Enter Noun : ");
            string noun = Console.ReadLine();

            Console.Write("Enter Celebrity Name : ");
            string celebName =  Console.ReadLine();

            Console.WriteLine($@"
Roses can be whatever color they want, but I Like {color}.
{noun} are probably mostly green or blue.
BUT, I would love to meet {celebName}
");
            Console.WriteLine("\n---End Mad Lib---\n");
            #endregion

        }
        
        catch(Exception ex) { 
            Console.WriteLine("ERROR : "+ex.Message); 
        }

    }
}