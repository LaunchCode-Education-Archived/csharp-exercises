using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cat garfield = new HouseCat("Garfield", 12);

            garfield.Eat();

            (garfield as HouseCat).IsSatisfied();

            HouseCat suki = new HouseCat("Suki", 12);
            CatOwner Annie = new CatOwner
            {
                Pet = suki
            };

            Annie.FeedTheCat();
        }
    }
}
