namespace OOPconcepts
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
---Welcome to Guitar Database---
Summary: (BUILD & TEST Phase)
- Enter details of the guitar (Later)
- All data is saved into a CSV (To-Do)
- Access CSV whenever needed (To-Do)
");
            // Test Build - Object Methods
            Guitar guitar1 = new Guitar("Classic", "Fender", "Nylon", 6, false, "1");
            Guitar guitar2 = new Guitar("Electric", "Gibson", "Metal", 7, true, "2");
            Guitar guitar3 = new Guitar("Acoustic", "Yamaha", "Metal", 6, true, "4");

            // store Guitar objects in array
            Guitar[] guitars = { guitar1, guitar2, guitar3 };

            // set Guitar objects Rating variable
            guitar1.Rating = "2";
            guitar2.Rating = "4";
            guitar3.Rating = "7";

            for(int i = 0; i < guitars.Length; i++)
            {
                // Check method - Guitar.IsElectric()
                Console.WriteLine($"Guitar {i+1} is Electric : {guitars[i].IsElectric()}");

                // Test Build - Getters & Setters (Guitars Rating - int)
                Console.WriteLine($"Guitar {i + 1} Rating : {guitars[i].Rating}");

            }
            

            // TO-DO :
            // Static Class Attributes
            // Static Methods & Classes
            // Inheritance


            /*
            // initialize variables
            bool userExit = false;

            // application loop, until userExit = true        
            try
            {
                while (!userExit)
                {
                    // PROGRAM_CODE BELOW



                    // option for user to exit
                    Console.WriteLine("\nPress 'q' to exit or Enter to continue");
                    if (Console.ReadLine() == "q") { userExit = true; }
                }
                Console.WriteLine("\n---End <program_name>---\n");
            }
            catch (Exception ex) { Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n"); }
            */
        }
    }
}