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

namespace DEMO
{
    public partial class Furnitura : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");

        public Furnitura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form klad = new Kladovshik();
            klad.Show();
            this.Close();
        }

        private void Furnitura_Load(object sender, EventArgs e)
        {
            String query = "Select * from Фурнитура";

            SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Фурнитура");

            dataGridView1.DataSource = ds.Tables["Фурнитура"];
        }
    }
}
