using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace EZShutdownTimer
{
    public partial class EZShutdownTimer : Form
    {
        public EZShutdownTimer()
        {
            InitializeComponent();
        }

        private void secs_Click(object sender, EventArgs e)
        {

        }

        //controls the input feild and changes secs label
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal seconds = (numericUpDown1.Value * 60) * 60;
            secs.Text = seconds + "Secs";

        }

        //Shutdown Button
        private void button1_Click(object sender, EventArgs e)
        {

            shutdown(true);
        }

        //Allows one easy method for calling a shutdown(true) or an abort(false).
        private void shutdown(bool state)
        {

            if (state)
            {
                
                System.Diagnostics.Process.Start("shutdown","-s -t " + secsGet());
                
                //Hide shutdown and show abort button
                button1.Visible = false;
                button2.Visible = true;
            }
            else {
                //var pwr = new ProcessStartInfo("shutdown", "/a");
                System.Diagnostics.Process.Start("shutdown", "/a");

                //hide abort button
                button1.Visible = true;
                button2.Visible = false;
                
            }
        }

        //converts counter value to int and returns the hours in seconds
        private int secsGet()
        {
            return 1 + (int)(numericUpDown1.Value * 60 * 60);
        }

        //Abort button
        private void button2_Click(object sender, EventArgs e)
        {
            shutdown(false);
        }
    }
}
