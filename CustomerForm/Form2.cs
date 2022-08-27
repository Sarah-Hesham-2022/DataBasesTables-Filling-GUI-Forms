using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carTradingDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.carTradingDataSet.CUSTOMER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Update(this.carTradingDataSet.CUSTOMER);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
