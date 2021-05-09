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
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieOperations form = new MovieOperations();
            form.MdiParent = this;
            form.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerOperations form = new CustomerOperations();
            form.MdiParent = this;
            form.Show();
        }

        private void rentMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovieRentOperations form = new MovieRentOperations();
            form.MdiParent = this;
            form.Show();
        }
    }
}
