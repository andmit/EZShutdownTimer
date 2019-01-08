using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int seconds = (int)(numericUpDown1.Value * 60) * 60;
            secs.Text = seconds + "Secs";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "shutdown -s -t" + secsGet();
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private int secsGet()
        {
            return (int)numericUpDown1.Value * 60 * 60;
        }
    }
}
