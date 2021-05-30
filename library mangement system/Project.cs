using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace library_mangement_system
{
    class Project
    {
    }
    public class SqlConnectionn
    {
        public SqlConnection con;
        public  SqlConnectionn(string conString)
        {
            this.con = new SqlConnection(conString);
        }
        public void insertTo(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.CommandText = query;
            con.Close();
        }
        public void delete(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.CommandText = query;
            con.Close();
        }
        public DataTable GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public void printData(string query)
        {
            DataTable dt = new DataTable(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.WriteLine(dt.Rows[i][j].ToString() + "\t");
                }
            }
        }
    }
}
