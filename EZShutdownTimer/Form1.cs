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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void secs_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal seconds = (numericUpDown1.Value * 60) * 60;
            secs.Text = seconds + "Secs";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            shutdown(true);
        }

        private void shutdown(bool state)
        {
            if (state)
            {
                //var pwr = new ProcessStartInfo("shutdown", "/s /t " + secsGet());
                //System.Diagnostics.Process.Start("ShutDown", "/t " + secsGet());
                //Process.Start(Environment.ExpandEnvironmentVariables("cmd.exe"), "shutdown /s /t "  + secsGet().ToString());
                ProcessStartInfo startInfo = new ProcessStartInfo("shutdown.exe", "/s /t " + secsGet());
                startInfo.Verb = "runas";
                System.Diagnostics.Process.Start(startInfo);


                button1.Visible = false;
                button2.Visible = true;
            }
            else {
                //var pwr = new ProcessStartInfo("shutdown", "/a");
                System.Diagnostics.Process.Start("shutdown", "/a");

//                pwr.CreateNoWindow = true;
  //              pwr.UseShellExecute = false;
    //            Process.Start(pwr);
                button1.Visible = true;
                button2.Visible = false;
                
            }
        }

        private decimal secsGet()
        {
            return 1 + numericUpDown1.Value * 60 * 60;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shutdown(false);
        }
    }
}
