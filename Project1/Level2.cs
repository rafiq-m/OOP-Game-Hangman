using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Project1
{
    sealed class Level2 : Level, ButtonProperties
    {
        private Button enableBUTTON= new Button();
        private int guess;
        private Label[] labels = new Label[5];
        private Label[] ex = new Label[5];
        private Random random = new Random();
        private PictureBox pictureBox = new PictureBox();
        private FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();

        public Level2(Label label1, Label label2, Label label3, Label label4,Label label5,PictureBox pictureBox)
        {
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            this.pictureBox = pictureBox;
        }

        public void forLevel2()
        {
            guess = random.Next(1, 5);
            switch (guess)
            {
                case 1:
                    labels[0].Text = "A";
                    labels[1].Text = "P";
                    labels[2].Text = "P";
                    labels[3].Text = "L";
                    labels[4].Text = "E";
                    break;
                case 2:
                    labels[0].Text = "T";
                    labels[1].Text = "I";
                    labels[2].Text = "G";
                    labels[3].Text = "E";
                    labels[4].Text = "R";
                    break;
                case 3:
                    labels[0].Text = "I";
                    labels[1].Text = "N";
                    labels[2].Text = "D";
                    labels[3].Text = "I";
                    labels[4].Text = "A";
                    break;
                case 4:
                    labels[0].Text = "P";
                    labels[1].Text = "I";
                    labels[2].Text = "Z";
                    labels[3].Text = "Z";
                    labels[4].Text = "A";
                    break;
            }
        }
        override public void startingVariableGuess()
        {
            guess = random.Next(1, 5);
            switch (guess)
            {
                case 1:
                    labels[0].Text = "H";
                    labels[1].Text = "A";
                    labels[2].Text = "P";
                    labels[3].Text = "P";
                    labels[4].Text = "Y";
                    break;
                case 2:
                    labels[0].Text = "U";
                    labels[1].Text = "N";
                    labels[2].Text = "I";
                    labels[3].Text = "T";
                    labels[4].Text = "Y";
                    break;
                case 3:
                    labels[0].Text = "G";
                    labels[1].Text = "R";
                    labels[2].Text = "E";
                    labels[3].Text = "E";
                    labels[4].Text = "N";
                    break;
                case 4:
                    labels[0].Text = "W";
                    labels[1].Text = "A";
                    labels[2].Text = "T";
                    labels[3].Text = "E";
                    labels[4].Text = "R";
                    break;
            }
        }
        override public void oneButtonVisible()
        {
            Random r = new Random();
            int x = r.Next(1, 5);
            switch (x)
            {
                case 1:
                    labels[0].Visible = true;
                    break;
                case 2:
                    labels[1].Visible = true;
                    break;
                case 3:
                    labels[2].Visible = true;
                    break;
                case 4:
                    labels[3].Visible = true;
                    break;
                case 5:
                    labels[4].Visible = true;
                    break;

            }
        }

        override public void buttonClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            displayWrongButtoon(currentButton);
            for (int i = 0; i < 5; i++)
            {
                if (currentButton.Text == labels[i].Text)
                {
                    labels[i].Visible = true;
                    displayButton(currentButton);
                    HangMan.scoreIncrement();
                }
            }
            if (currentButton.Text != labels[0].Text && currentButton.Text != labels[1].Text && currentButton.Text != labels[2].Text && currentButton.Text != labels[3].Text && currentButton.Text != labels[4].Text)
            {
                HangMan.checkCounter();
                HangMan.changeImage(pictureBox);
                HangMan.counterIncrement();
                HangMan.scoreDecrement();
            }
            if (labels[0].Visible == true && labels[1].Visible == true && labels[2].Visible == true && labels[3].Visible == true && labels[4].Visible == true)
            {
                enableBUTTON.Visible = true;
                flowLayoutPanel.Controls.Clear();

            }

        }
       override public void enableButton(Button button,String text,FlowLayoutPanel flowLayoutPanel)
        {
            enableBUTTON = button;
            enableBUTTON.Text = text;
            this.flowLayoutPanel = flowLayoutPanel;
        }


        public void buttonProperties()
        {
            for(int i =0;i<labels.Length;i++)
            {
                labels [i].Visible = false;
            }
        }
        public void removeButtonKeyboard(FlowLayoutPanel flowLayout1)
        {
            flowLayout1.Controls.Clear();
        }
        override public void labelUnderliner(Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                ex[i] = label[i];
                ex[i].Font = new Font(ex[i].Font.Name, ex[i].Font.SizeInPoints, FontStyle.Underline);
            }
        }
        public override void hintLabel(Label label)
        {
            switch (guess)
            {
                case 1:
                    label.Text = "Hint: feeling or showing pleasure or contentment.";
                    break;
                case 2:
                    label.Text = "Hint: It's the need of every muslim to remain in _________";
                    break;
                case 3:
                    label.Text = "Hint: It's a colour of plant.";
                    break;
                case 4:
                    label.Text = "Hint: It's the most important thing for human beings as well as animals";
                    break;
            }
        }
        public override void hintFor2ndLevel(Label label)
        {
            switch (guess)
            {
                case 1:
                    label.Text = "Hint: It keeps doctors away.";
                    break;
                case 2:
                    label.Text = "Hint: It is the king of jungle";
                    break;
                case 3:
                    label.Text = "Hint: It is the World's largest Democratic country in the world";
                    break;
                case 4:
                    label.Text = "Hint: It's a Italian dish consisting of flat round dough and some toppings";
                    break;
            }
        }
    }
}

