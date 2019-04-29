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
    public partial class tkani : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");

        public tkani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form klsd = new Kladovshik();
            klsd.Show();
            this.Close();
        }

        private void tkani_Load(object sender, EventArgs e)
        {
            String query = "Select * from Ткань";

            SqlDataAdapter sda = new SqlDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();

            sda.Fill(ds, "Ткань");

            dataGridView1.DataSource = ds.Tables["Ткань"];
        }
    }
}
