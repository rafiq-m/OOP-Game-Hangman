using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Project1
{
   static class TimerClass
    {
        private static Label ClassLabel = new Label();
        private static Timer timer= new Timer();

        public static void startTimer(Label label)
        {
            timer.Interval = 200;
            timer.Start();
            ClassLabel = label;         

                timer.Tick += new EventHandler(timer_ColorChange);
        }
        private static void timer_ColorChange(object sender,EventArgs e)
        {
            if (ClassLabel.ForeColor == Color.Red)
            {
                ClassLabel.ForeColor = Color.White;
            }
            else
                ClassLabel.ForeColor = Color.Red;
        }
    }
}
