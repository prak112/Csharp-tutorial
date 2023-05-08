using OOP_Fundmentals;

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
            Guitar guitar1 = new ("Fender", "3");
            Guitar guitar2 = new ("Gibson", "3");
            Guitar guitar3 = new ("Yamaha", "2.7");

            // store Guitar objects in array
            Guitar[] guitars = { guitar1, guitar2, guitar3 };

            // set Guitar objects Rating variable
            guitar1.Rating = "2";
            guitar2.Rating = "4";
            guitar3.Rating = "7";

            for(int i = 0; i < guitars.Length; i++)
            {
                // Test Build - Getters & Setters (Guitars Rating - int)
                Console.WriteLine($"Guitar {i + 1} Rating : {guitars[i].Rating}");
            }

            // Call Guitar class static variable guitarCount
            Console.WriteLine($"\nTotal Guitars in Warehouse : {Guitar.guitarCount}");
            Console.WriteLine($"Static variable call from Object : {guitar1.getGuitarCount()}");

            // Call GuitarTips static class and Learning static method
            GuitarTips.Learning();

            // Create object from Inherited class
            GuitarSpec guitar1Update = new GuitarSpec(GuitarSpec.GuitarTypes.Acoustic, GuitarSpec.StringTypes.Steel, "Fender", "4");
            Console.WriteLine($"Updated details of Guitar 1 :\nGuitar Type: {guitar1Update.getGuitarType()}\nString Type : {guitar1Update.getStringType()}");

            Console.WriteLine("\n---End Program---\n");
        }
    }
}