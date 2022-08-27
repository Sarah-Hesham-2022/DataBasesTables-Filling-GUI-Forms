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
namespace CustomerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection to database code statement
            String connectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //Define SQL Query
            SqlCommand com=new SqlCommand();
            com.CommandText = "Select*from Customer";
            com.Connection = con;
            com.CommandType = CommandType.Text; 
            //Execute the sql query
            SqlDataReader reader=com.ExecuteReader();
            String customerNames = "";
            while(reader.Read())
            {
                customerNames += (reader[1]);
                customerNames += "\n";
            }
            MessageBox.Show(customerNames);
            //close the reader and the connection
            reader.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form1 = new Form2();
            Form1.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Insert Into Customer values ( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            con.Open();
            MessageBox.Show("Inserted Successfully");
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("update Customer set Customer_Name = '" + textBox1.Text + "' where Customer_Mobile = '" + textBox2.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("update Customer set Customer_Telephone = '" + textBox3.Text + "' where Customer_Mobile = '" + textBox2.Text + "'", con);
            SqlCommand cmd3 = new SqlCommand("update Customer set Customer_Address = '" + textBox4.Text + "' where Customer_Mobile = '" + textBox2.Text + "'", con);
            SqlCommand cmd4 = new SqlCommand("update Customer set Customer_Mobile = '" + textBox2.Text + "' where Customer_Name = '" + textBox1.Text + "'and Customer_Telephone='"+textBox3.Text + "'and Customer_Address='" + textBox4.Text + "'", con);
            con.Open();
            MessageBox.Show("Updated Successfully");
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            con.Close();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("Delete from Customer where Customer_Mobile = '" + textBox2.Text + "'", con);


            con.Open();
            MessageBox.Show("Deleted Successfully");
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
