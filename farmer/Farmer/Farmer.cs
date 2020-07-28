using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

        public int BagsOfFeed;

        private int feedMultiplier;
        public int FeedMultiplier
        {
            get { return feedMultiplier;}
        }


        private int numberOfCows;

        public int NumberOfCows
        {
            get => numberOfCows;
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }

        }
       
    }
}
