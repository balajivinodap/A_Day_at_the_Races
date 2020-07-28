using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        private string cakeWriting1;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        private int actualLength { get; set; }
        public string CakeWriting { get => cakeWriting; set => cakeWriting = value; }

        private string cakeWriting;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                {
                    return CakeWriting.Length;
                }
            }
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            return 40;
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4) 
                return 8;
            return 16;

        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return true;
                }

                return false;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }

            return costOfDecorations;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                {
                    cakeCost = 75M + ActualLength * .25M;
                }

                return totalCost + cakeCost;
            }
        }
    }
}
