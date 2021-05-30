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
    public partial class InfoUser : Form
    {
        public InfoUser()
        {
            InitializeComponent();
        }
        public DataTable dt2 = new DataTable();
        private void InfoUser_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in dt2.Rows)
            {
                label3.Text = dr["stdName"].ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            detial d1 = new detial();
            d1.Show();
            this.Hide();
        }
    }
}
