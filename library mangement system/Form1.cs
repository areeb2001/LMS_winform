using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_mangement_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Logincs l1 = new Logincs();
            l1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stafflogin stl1 = new stafflogin();
            stl1.Show();
            this.Hide();
        }
    }
}
