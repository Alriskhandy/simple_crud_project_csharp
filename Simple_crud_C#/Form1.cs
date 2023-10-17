using Microsoft.Data.SqlClient;
using System.CodeDom;
using System.Data;

namespace Simple_crud_C_
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=ALRISKHANDY-NIT\SQLEXPRESS01;Initial Catalog=school;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update teacher set name='" + txtname.Text + "', address='" + txtaddress.Text + "', salary='" + txtsalary.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from teacher where id='" + txtfind.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            data_adapter.Fill(data_table);
            txtname.Text = data_table.ToString();
            txtaddress.Text = data_table.ToString();
            txtsalary.Text = data_table.ToString();
            dataGridView1.DataSource = data_table;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"insert into teacher values('{txtid.Text.ToString()}','{txtname.Text}', '{txtaddress.Text}', '{txtsalary.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }

        private void cleardata()
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtsalary.Clear();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from teacher";
            cmd.ExecuteNonQuery();
            DataTable data_table = new DataTable();
            SqlDataAdapter data_adapter = new SqlDataAdapter(cmd);
            data_adapter.Fill(data_table);
            dataGridView1.DataSource = data_table;
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string query = $"delete teacher where id='{txtid.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}