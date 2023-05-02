using System;

public class Guitar
{
    // Properties
    public string guitarType { get; set; }
    public string manufacturer { get; set; }
    public string stringType { get; set; }
    public int stringCount { get; set; }
    public bool hasAmplifier { get; set; }
    private string rating;  // secure and internal class access-only variable

    // Constructor
    public Guitar(string aGuitarType, string aManufacturer, string aStringType, int aStringCount, bool aHasAmplifier, string aRating)
    {
        guitarType = aGuitarType;
        manufacturer = aManufacturer;
        stringType = aStringType;
        stringCount = aStringCount;
        hasAmplifier = aHasAmplifier;
        Rating = aRating;
    }

    // Methods
     public bool IsElectric()
    {
        if (guitarType == "Electric") { return true; }
        return false;
    }

    // Getter & Setter Method
    public string Rating  // to be assigned to private variable from Constructor
    {
        // required for value setup and retrieve
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

}
