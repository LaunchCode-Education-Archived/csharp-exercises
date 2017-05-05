using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cats
{
    public class CatOwner
    {
        public IFeedable Pet { get; set; }

        public void FeedTheCat()
        {

            // code to prepare the cat's meal

            Pet.Eat();
        }

    }
}
