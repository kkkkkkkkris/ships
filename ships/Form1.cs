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

namespace ships
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=PC-306-02;Initial Catalog=Ship;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string zapros = "select name,class,launched from Ships";
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapros, connect);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                //3
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = @"Data Source=PC-306-02;Initial Catalog=Ship;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(a);
            con.Open();
            DataSet b = new DataSet();
            String comand = ("SELECT* FROM Classes ");
            SqlDataAdapter n = new SqlDataAdapter(comand, con);
            n.Fill(b);
            dataGridView1.DataSource = b.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = @"Data Source=PC-306-02;Initial Catalog=Ship;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(a);
            con.Open();
            DataSet b = new DataSet();
            String comand = ("SELECT* FROM Outcomes ");
            SqlDataAdapter n = new SqlDataAdapter(comand, con);
            n.Fill(b);
            dataGridView1.DataSource = b.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = @"Data Source=PC-306-02;Initial Catalog=Ship;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(a);
            con.Open();
            DataSet b = new DataSet();
            String comand = ("SELECT* FROM Battles ");
            SqlDataAdapter n = new SqlDataAdapter(comand, con);
            n.Fill(b);
            dataGridView1.DataSource = b.Tables[0];
        }
    }
}
