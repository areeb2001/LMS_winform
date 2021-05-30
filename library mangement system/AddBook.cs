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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        SqlConnectionn con1 = new SqlConnectionn("Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True");
        public int myid;
        private void button2_Click(object sender, EventArgs e)
        {
            stfinfo info = new stfinfo();
            info.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                con1.insertTo("insert into addbook values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')");
                MessageBox.Show("Record inserted successfully", "Congrass", MessageBoxButtons.OK);
                clear();
                dataGridView1.DataSource = con1.GetData("select * from addbook");
            }
        }
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myid > 0)
            {
                con1.UpdateData(@"Update addbook set bookName='" + textBox1.Text + "',bookAuthor='" + textBox2.Text + "',bookPurh='" + dateTimePicker1.Text + "',bookPrice='"+textBox3.Text+ "',bookQan='"+textBox4.Text+"' where book_id = '" + myid + "'");
                dataGridView1.DataSource = con1.GetData("select * from addbook");
                MessageBox.Show("Record updated successfully", "Congrass", MessageBoxButtons.OK);
                clear();

            }
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (myid > 0)
            {
                con1.delete(@"delete from addbook where book_id = '" + myid + "'");
                dataGridView1.DataSource = con1.GetData("select * from addbook");
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
            myid = int.Parse(dataGridView1.SelectedRows[0].Cells["book_id"].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells["bookName"].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells["bookAuthor"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells["bookPurh"].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells["bookPrice"].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells["bookQan"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con1.GetData("select * from addbook");
        }
    }
}
