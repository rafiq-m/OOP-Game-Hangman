using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project1
{
    abstract class Level 
    {
        abstract public void startingVariableGuess();

        abstract public void oneButtonVisible();

         public void Start(FlowLayoutPanel flowLayoutPanel1, Button start)
        {
            int x = 65;
            for (int i = 0; i < 33; i++)
            {
                if ((i > 23 && i < 27) || (i >= 29 && i <33))
                {
                    var buttons = addButton2(x);
                    flowLayoutPanel1.Controls.Add(buttons);
                }
                else
                {
                    var button = addButton(x);
                    flowLayoutPanel1.Controls.Add(button);
                    button.Click += new EventHandler(this.buttonClick);
                    x = x + 1;
                }
            }
            start.Visible = false;
        }
        virtual public void formInfo(Form form)
        {

        }

        private Button addButton(int x)
        {
            char c = (char)x;
            var button = new Button();
            button.BackColor = Color.LightBlue;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.DarkBlue;
            button.FlatAppearance.BorderSize = 2;
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.Name = c.ToString();
            button.Text = c.ToString();
            button.Height = 80;
            button.Width = 74;
            return button;
        }
        private Button addButton2(int x)
        {
            char c = (char)x;
            var button = new Button();
            button.BackColor = Color.Transparent;
            button.Name = c.ToString();
            button.Text = "-".ToString();
            button.Height = 80;
            button.Width = 74;
            return button;
        }
        abstract public void buttonClick(object sender, EventArgs e);

        abstract public void enableButton(Button button, String text,FlowLayoutPanel flowLayoutPanel);

        abstract public void labelUnderliner(Label[] label);

        public void displayButton(Button button)
        {
            button.ForeColor = Color.White;
            button.BackColor = Color.LightGreen;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.DarkGreen;
            button.FlatAppearance.BorderSize = 2;
            button.Enabled = false;
        }
        public void displayWrongButtoon(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.DarkRed;
            button.FlatAppearance.BorderSize = 2;
            button.ForeColor = Color.White;
            button.BackColor = Color.Red;
            button.Enabled = false;
        }
        abstract public void hintLabel(Label label);
        abstract public void hintFor2ndLevel(Label label);

    }
}
