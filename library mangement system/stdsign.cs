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
    public partial class stdsign : Form
    {
        public stdsign()
        {
            InitializeComponent();
        }
        public int myid;
        SqlConnectionn con1 = new SqlConnectionn("Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox5.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                con1.insertTo("insert into stdsignup values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')");
                MessageBox.Show("Record inserted successfully", "Congrass", MessageBoxButtons.OK);
                clear();
                dataGridView1.DataSource = con1.GetData("select * from stdsignup");
            }
        }
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con1.GetData("select * from stdsignup");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stfinfo stf1 = new stfinfo();
            stf1.Show();
            this.Hide();
        }

        private void stdsign_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myid > 0)
            {
                con1.UpdateData(@"Update stdsignup set stdName='" + textBox1.Text + "',stdPhone='" + textBox2.Text + "',depart='" + textBox5.Text + "',stdEmail='" + textBox3.Text + "',stdPass='" + textBox4.Text + "' where std_id = '" + myid + "'");
                dataGridView1.DataSource = con1.GetData("select * from stdsignup");
                MessageBox.Show("Record updated successfully", "Congrass", MessageBoxButtons.OK);
                clear();

            } 
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myid > 0)
            {
                con1.delete(@"delete from stdsignup where std_id = '" + myid + "'");
                dataGridView1.DataSource = con1.GetData("select * from stdsignup");
                MessageBox.Show("Record delete successfully", "Congrass", MessageBoxButtons.OK);
                clear();

            }
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            myid = int.Parse(dataGridView1.SelectedRows[0].Cells["std_id"].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["stdName"].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells["stdPhone"].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells["depart"].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells["stdEmail"].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells["stdPass"].Value.ToString();
        }
    }
}
