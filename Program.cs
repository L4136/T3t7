using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3t7
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            cd.Artist = "Nightwish";
            cd.Name = "Endless Forms Most Beautiful";
            cd.Genre = "Symphonic metal";
            cd.Price = 19.90;

            Console.WriteLine(cd.ToString());
        }


    }
}
