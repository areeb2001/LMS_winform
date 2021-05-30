using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_mangement_system
{
    public partial class stafflogin : Form
    {
        public stafflogin()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            staffsign sign1 = new staffsign();
            sign1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from signupp where staffEmail = '" + textBox1.Text + "' and staffPass ='" + textBox2.Text + "'", con1);
                con1.Open();
                stfinfo stfinfo = new stfinfo();
                DataTable dt = new DataTable();
                adapter.Fill(stfinfo.dt2);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Sucessfully Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stfinfo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con1.Close();




            }
        }
    }
}
