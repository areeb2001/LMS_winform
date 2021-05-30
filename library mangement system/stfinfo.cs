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
    public partial class stfinfo : Form
    {
        public stfinfo()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            AddBook AB = new AddBook();
            AB.Show();
            this.Hide();
        }
       public DataTable dt2 = new DataTable();
        private void stfinfo_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt2.Rows)
            {
                label3.Text = dr["staffName"].ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReutrnBook rb = new ReutrnBook();
            rb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stdsign st1 = new stdsign();
            st1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IssueBook ib1 = new IssueBook();
            ib1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stafflogin l1 = new stafflogin();
            l1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            detial d1 = new detial();
            d1.Show();
            this.Hide();

        }
    }
}
