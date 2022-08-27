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
namespace ShipperForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";
            SqlConnection con=new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select* from Shipper";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text; 
            SqlDataReader reader = cmd.ExecuteReader();
            String ShippersNames = "";
            while(reader.Read())
            {
                ShippersNames += reader[1];
                ShippersNames += "\n";
            }
            MessageBox.Show(ShippersNames);
            reader.Close();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form1=new Form2();
            Form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("Insert Into Shipper values ( '" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "' ,'" + textBox3.Text+"')", con);

            con.Open();
            MessageBox.Show("Inserted Successfully");
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("update Shipper set Shipper_Name = '" +textBox1.Text + "' where Shipper_Telephone = '" + textBox2.Text + "'", con);
            SqlCommand cmd2 = new SqlCommand("update Shipper set Shipper_Telephone = '" + textBox2.Text + "' where Shipper_Name = '" + textBox1.Text + "' and Shipper_Country = '" + textBox3.Text + "' and Shipper_Address = '" + textBox4.Text + "'", con);
           SqlCommand cmd3 = new SqlCommand("update Shipper set Shipper_Country = '" + textBox3.Text +  "' where Shipper_Telephone = '" + textBox2.Text + "'", con);
            SqlCommand cmd4 = new SqlCommand("update Shipper set Shipper_Address = '" + textBox4.Text + "' where Shipper_Telephone = '" + textBox2.Text + "'", con);



            con.Open();
            MessageBox.Show("Updated Successfully");
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            con.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"Data Source=DESKTOP-TVRD1PQ\SQLEXPRESS;Initial Catalog=CarTrading;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("Delete from Shipper where Shipper_Telephone = '" + textBox2.Text + "'", con);


            con.Open();
            MessageBox.Show("Deleted Successfully");
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
