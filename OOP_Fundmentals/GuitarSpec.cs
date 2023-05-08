using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundmentals
{
    class GuitarSpec : Guitar
    {
        // Define Enums
        public enum GuitarTypes 
        { 
            Acoustic, Electric, Classical 
        }
        public enum StringTypes 
        { 
            Brass, Steel, Nylon 
        }

        // Properties (declare enums)
        public GuitarTypes guitarType { get; set; }
        public StringTypes stringType { get; set; }

        // Constructor
        public GuitarSpec(GuitarTypes guitarType, StringTypes stringType, string aManufacturer, string aRating) : base(aManufacturer, aRating)
        {
            this.guitarType = guitarType;
            this.stringType = stringType;
        }

        // Methods
        public GuitarTypes getGuitarType() 
        {
            return guitarType;
        }

        public StringTypes getStringType()
        {
            return stringType;
        }

    }
}
