using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP2.project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Product_Info set ItemName= '" + textBox3.Text + "', Color ='" + comboBox1.Text + "' where ProductID = '" + int.Parse(textBox2.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Update.");
            BindData();
        }
        SqlConnection con = new SqlConnection("Data Source=PRIMA\\MSSQLSERVER01;Initial Catalog=oop2.p;Persist Security Info=True;User ID=sa;Password=prima17;Encrypt=False");
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Product_Info values ('" + int.Parse(textBox2.Text) + "','" + textBox3.Text + "','" + comboBox1.Text + "', getdate())", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Inserted.");
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Product_Info", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("Delete Product_Info where ProductID= '" + int.Parse(textBox2.Text) + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted.");
            BindData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Product_Info where ProductID= '" + int.Parse(textBox2.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
    }
