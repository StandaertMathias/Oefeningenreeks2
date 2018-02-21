using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    enum Geslacht{
        Man, 
        Vrouw
    }
    class BandLid
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Geslacht Geslacht { get; set; }
        public bool death { get; set; }
    }
}
