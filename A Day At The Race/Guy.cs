using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Race
{
    public class Guy
    {
        public string Name; //The guy's name
        public Bet MyBet; //An istance of Bet that has his bet
        public int Cash; //How much cash he has

        //The last two field are the guy's GUI controls on the form 
        public RadioButton MyRadioButton; //My Radio Button
        public Label MyLabel; //My Label

        //Set my label to my bet's  description, and the label on my radio button to show my cash ("Joe has 43 bucks")
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = MyBet.GetDescription(); 
        }

        //Reset  my bet so it's zero
        public void ClearBet()
        {
            PlaceBet(0, 0);
        }

        //Place a new bet and store it in my bet field
        //return true if the guy had enought money to bet
        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount <= Cash)
            {
                MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
        }

        //ask my bet to pay out,clear my bet,and update my labels
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
