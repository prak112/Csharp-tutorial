using System;

class Guitar
{
    // Properties
    public string manufacturer { get; set; }
    private string rating = String.Empty;  // secure and internal class access-only variable
    public static int guitarCount = 0;

    // Constructor
    public Guitar(string aManufacturer, string aRating)
    {
        manufacturer = aManufacturer;
        Rating = aRating;       // argument assigned to Getter & Setter Method
        guitarCount++;          // increment guitarCount for every object created
    }

    // Methods
    // Getter & Setter Method
    public string Rating  // set & return value to private variable in Properties
    {
        // required for rating setup and retrieve
        get { return rating; }
        set
        {
            // enforce rating with strict rules, i.e., between 1-5 only
            switch (value)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    rating = value;
                    break;
                default:
                    rating = "No-Rating";
                    //throw new ArgumentException("Enter a Value between 1-5");
                    break;
            }
        }
    }

    // Static variable access
    public int getGuitarCount()
    {
        return guitarCount;
    }
}


// Static class
static class GuitarTips 
{ 
    // Static Method
    public static void Learning()
    {
        Console.WriteLine(@"
Here is a list of Guitar Learning Options :
- Chordify, practice any song on Youtube 
- Gituru, AI-powered novice-level practice
- Yousician, fully packed learning experience for all levels
- Find a Local Teacher at your nearest Community College ;-)
");
    }
}
