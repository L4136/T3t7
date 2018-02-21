using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3t7
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }


        public override string ToString()
        {
            return "Artist: " + Artist + "\nName of the album: " + Name + "\nGenre: " + Genre + "\nPrice: " + Price;
        }
    }
}
