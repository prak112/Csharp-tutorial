namespace StructsLoopsConditionals;

class PracticeBlock
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("\n---Start MAIN Program---\n");

            #region CallMethods

            // Call METHODS defined below
            Console.WriteLine("RandomNumbers() method returns Random Numbers ARRAY-\n");
            foreach (int num in RandomNumbers())
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
            
            Console.WriteLine(@$"
--METHODS below are called from MAIN Method--
'Emotions()' Method returns Emoji- {Emotions()}
'DoMath(2.3, 1.2)' Method returns Product- {DoMath(2.3, 1.2)}
'Cube(9)' Method returns Cube- {Cube(9)}
'CatSounds('sleeping')' Method returns Cat says- {CatSounds("sleeping")}
'FortuneTeller('will I be rich?', 0)' Method returns Prediction- {FortuneTeller("will I become rich?", 0)}
'DayName(2)' Method returns Day name- {DayName(2)}
");
            Console.WriteLine("\n---End MAIN Program---\n");

            #endregion
        }
        catch (Exception ex){ Console.WriteLine($"ERROR : {ex.Message}\n---TERMINATE PROGRAM---\n"); }
    }

    #region MethodsIntro
    // only called from Main

    static double DoMath(double num1, double num2)
    {
        double product = num1 * num2;
        
        return product;
    }

    static int Cube(int num)
    {
        int cube = num * num * num;
        return cube;
    }

    #endregion

    #region RandomNumbers-Array

    static List<int> RandomNumbers()
    {
        // initialize Array and user input
        Console.Write("\nHow many Random Numbers would you like : ");
        int num = int.Parse(Console.ReadLine());
        List<int> randomNumbers = new List<int>();

        // initialize Random class
        Random number = new Random();       // pseudo-random number generator, non-negative integers

        // access Array element
        Console.WriteLine("Random Numbers generated are : \n");
        for (int i = 0; i < num; i++)
        {
            randomNumbers.Add(number.Next(1000));
        }
        return randomNumbers;
    }
    #endregion


    #region If-Else

    static string CatSounds(string status)
    {
        string sound = "";
        if (status == "sleeping") {
            sound = "Meooo meoo meooo";
            return sound;
        }
        else if(status == "in love") {
            sound = "fuuuur furrrr furrururr";
            return sound;
        }
        else { sound = "Say what Hoooman!";
            return sound;
        }
    }

    static bool FortuneTeller(string question, int money)
    {
        if (question == "You are stupid" && money == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    #endregion

    #region DayName-Switch

    static string DayName(int day)
    {
        string  dayName ;
        switch (day)
        {
            case 1: dayName = "Sunday"; return dayName;
            case 2: dayName = "Monday"; return dayName;
            case 3: dayName = "Tuesday"; return dayName;
            default:    dayName = "So on and So forth.."; return dayName;
        }
    }

    #endregion

    #region Emotions-Loops

    static string Emotions()    // method with user input 
    {
        string feeling;
        do
        {
            Console.WriteLine("\nHow are you feeling today : \nPress Enter if you don't want to say :)");
            feeling = Console.ReadLine();

            string emoji;
            if (feeling == "happy") { 
                emoji = " :-D YAAY!!"; return emoji; }
            else if(feeling == "sad") { 
                emoji = " <3 <3 <3 Have some LOVE"; return emoji; }
            else { 
                emoji = "<3 <3 More LOVE"; return emoji; }
        } while (feeling != string.Empty);
    }

    #endregion
}



