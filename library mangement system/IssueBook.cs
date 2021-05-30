using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_mangement_system
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
        }
        private void IssueBook_Load(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection();
            con.ConnectionString="Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bookName from addbook",con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                string ab = textBox4.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from stdsignup where std_id='" + ab + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);


                cmd.CommandText = "select count(std_id) from IRbook where std_id='" + ab + "' and bookReturnDate is null";
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count !=0)
                {
                    textBox6.Text = ds.Tables[0].Rows[0][0].ToString();
                    textBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox3.Clear();
                    MessageBox.Show("Invalid Student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <=2)
                {
                    int id = Int32.Parse(textBox6.Text);
                    string stdname = textBox1.Text;
                    long ph = Int64.Parse(textBox2.Text);
                    string depart = textBox5.Text;
                    string mail = textBox3.Text;
                    string bn = comboBox1.Text;

                    string ab = textBox4.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-JI9U948;Initial Catalog=libraryy;Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into IRbook(std_id,stddName,stddPhone,ddepart,stddEmail,Bookkname,bookIssueDate)values('" + id+ "','" + stdname + "','" + ph + "','" + depart + "','" + mail + "','" + bn + "','" + dateTimePicker1.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Issue","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Maximum Book Has Been Issued", "No Book selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox6.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stfinfo stf1 = new stfinfo();
            stf1.Show();
            this.Hide();
        }
    }
}
