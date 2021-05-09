using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
