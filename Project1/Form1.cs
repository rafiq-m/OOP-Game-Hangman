using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project1
{
    public partial class Form1 : Form
    {

        Level[] l = new Level[3];
        Level1 l1;
        Level2 l2;
        Level3 l3;
        public Form1()
        {
            InitializeComponent();
            level.BackColor = Color.LightBlue;
            start.BackColor = Color.LightBlue;
            HangMan.getScoreButton(score);
            pictureBox1.Image = Properties.Resources._1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l[0] = new Level1(A, B, C, D,pictureBox1);
            l[0].startingVariableGuess();
            l[0].oneButtonVisible();
            l[0].hintLabel(hint);
            TimerClass.startTimer(hint);
            l[0].labelUnderliner(new Label[] { ex1, ex2, ex3, ex4 });

        }

        private void Start_Click(object sender, EventArgs e)
        {
            l[0].Start(flowLayoutPanel1, start);
            l[0].enableButton(level,"Go To Level 2",flowLayoutPanel1);
        }

        private void Level_Click(object sender, EventArgs e)
        { 
            if(level.Text == "Go To Level 2")
            {
                if (l[0] is Level1)
                {
                    l1 = (Level1)l[0];
                    l1.buttonProperties();
                    l1.removeButtonKeyboard(flowLayoutPanel1);
                    HangMan.resetCounter();
                    //previous 
                    l1.forLevel2();
                    l1.oneButtonVisible();
                    l1.hintFor2ndLevel(hint);
                    l1.Start(flowLayoutPanel1, start);
                    level.Visible = false;
                    l1.enableButton(level, "Go To Level 3", flowLayoutPanel1);
                }
            }
            else if(level.Text == "Go To Level 3")
            {            
                l1.buttonProperties();
                l1.removeButtonKeyboard(flowLayoutPanel1);
                HangMan.resetCounter();
                l[1] = new Level2(A, B, C, D, E, pictureBox1);
                l[1].labelUnderliner(new Label[] { ex1, ex2, ex3, ex4, ex5 });
                l[1].Start(flowLayoutPanel1, start);
                l[1].oneButtonVisible();               
                l[1].startingVariableGuess();
                l[1].hintLabel(hint);
                level.Visible = false;
                l[1].enableButton(level, "Go To Level 4", flowLayoutPanel1);

            }
            else if(level.Text == "Go To Level 4")
            {
                if (l[1] is Level2)
                {
                    l2 = (Level2)l[1];
                    l2.buttonProperties();
                    l2.removeButtonKeyboard(flowLayoutPanel1);
                    HangMan.resetCounter();
                    //previous 
                    l2.forLevel2();
                    l2.hintFor2ndLevel(hint);
                    l2.oneButtonVisible();
                    l2.Start(flowLayoutPanel1, start);
                    level.Visible = false;
                    l2.enableButton(level, "Go To Level 5", flowLayoutPanel1);
                }
            }
            else if(level.Text == "Go To Level 5")
            {
                l2.buttonProperties();
                l2.removeButtonKeyboard(flowLayoutPanel1);
                HangMan.resetCounter();
                l[2] = new Level3(A, B, C, D, E, F, pictureBox1);
                l[2].labelUnderliner(new Label[] { ex1, ex2, ex3, ex4, ex5, ex6 });
                l[2].Start(flowLayoutPanel1, start);
                l[2].oneButtonVisible();
                l[2].startingVariableGuess();
                l[2].hintLabel(hint);
                level.Visible = false;
                l[2].enableButton(level, "Go To Last Level", flowLayoutPanel1);
            }
            else if(level.Text == "Go To Last Level")
            {
                if(l[2] is Level3)
                {
                    l3 = (Level3)l[2];
                    l3.buttonProperties();
                    l3.removeButtonKeyboard(flowLayoutPanel1);
                    HangMan.resetCounter();
                    l3.forLevel2();
                    l3.hintFor2ndLevel(hint);
                    l3.oneButtonVisible();
                    l3.Start(flowLayoutPanel1, start);
                    level.Visible = false;
                    l3.enableButton(level, "End This Game", flowLayoutPanel1);
                }              
            }
            else
            {
                MessageBox.Show("Your Score was: " + HangMan.showScore()+" And you played very well"); 
                Application.Exit();
            }
        }

    }
}