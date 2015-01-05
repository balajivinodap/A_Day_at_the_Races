using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A_Day_At_The_Race
{
    public class Greyhound
    {
        public int StartingPosition; //Where my PictureBox starts
        public int RacetrackLenght; // How long the racetrak is
        public PictureBox MyPictureBox = null; //My PictureBox object
        public int Location = 0; // My location on the racetrack
        public Random Randomizer; // An instance of Random

        //Move forward either 1,2,3 or 4 space at random
        //Update the position of my PictureBox on the form like this:
        //My PictureBox.Left = StartingPosition + Location;
        //Return true if I won the race
        public bool Run()
        {
            Location += Randomizer.Next(4); //Changhe the value to speed up the race!
            MyPictureBox.Left = StartingPosition + Location;
            MyPictureBox.Refresh();

            if (MyPictureBox.Left >= RacetrackLenght - MyPictureBox.Width+20)
                return true;
            else
                return false;
        }


        public void TakeStartingPosition()
        {
            //Reset my location to 0 and my PictureBox to starting position
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
