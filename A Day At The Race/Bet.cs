using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Day_At_The_Race
{
    public class Bet
    {
        public int Amount; //The amount of cash that was bet
        public int Dog; //The number of dog the bet is on
        public Guy Bettor; //The guy who placed the bet

        //Return a string that says who palce the bet, how much cash was bet, and which dog he bet on ("Joe bets 8 on dog #4")
        //If the amount is zero, no bet was placed ("Joe hasn't placed a bet")
        public string GetDescription()
        {
            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }
            else
            {
                return Bettor.Name + " hasn't placed a bet";
            }
        }

        //The parameter is the winner of the race. IF the dog won, return the amount bet. Otherwise, return a negative of the amount bet.
        public int PayOut(int Winner)
        {
            if(Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
