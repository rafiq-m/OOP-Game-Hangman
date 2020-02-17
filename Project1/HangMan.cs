using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public static class HangMan
    {
        private static PictureBox picture = new PictureBox();
        private static int counter = 2;
        private static int score = 0;
        private static Button Score = new Button();

        public static void counterIncrement()
        {
            counter++;
        }
        public static void scoreIncrement()
        {
            score++;
            Score.Text = (score).ToString();
        }
        public static void scoreDecrement()
        {
            score--;
            Score.Text = (score).ToString();
        }
        public static void getScoreButton(Button score)
        {
            Score = score;
        }
        public static int showScore()
        {
            return score;
        }
        public static void checkCounter()
        {
            if(counter ==8 )
            {
                gameOver();
            }
        }
        public static void changeImage(PictureBox pictureBox)
        {
            picture = pictureBox;
            switch(counter)
            {
                case 2:
                    pictureBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox.Image = Properties.Resources._7;
                    break;
            }
        }
        private static void gameOver()
        {
            MessageBox.Show("You lose the match");
            Application.Exit();
        }
        public static void resetCounter()
        {
            counter = 2;
            picture.Image = Properties.Resources._1 ;
        }
    }
}
