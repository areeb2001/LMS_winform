using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_mangement_system
{
    public partial class staffsign : Form
    {
        public staffsign()
        {
            InitializeComponent();
        }
        SqlConnectionn c1 = new SqlConnectionn("Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            stafflogin stl1 = new stafflogin();
            stl1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                c1.insertTo("insert into signupp values('" + textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')");
                MessageBox.Show("Sucessfully signin", "Add record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stafflogin stff1 = new stafflogin();
                stff1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(".........", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
