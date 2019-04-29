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
    public partial class Logpas : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");

        public Logpas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form r = new Reg();
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionString.Open();
            String login = textBox1.Text;
            String pass = textBox2.Text;

            SqlCommand command = new SqlCommand("SELECT * FROM Пользователь WHERE Логин = '" + login + "' AND Пароль = '" + pass + "'", ConnectionString);
            SqlDataReader reader = command.ExecuteReader();

            String role = "", name = "";
            while (reader.Read())
            {

                role = reader[2].ToString();
                name = reader[3].ToString();
            }

            Form form = null;
            switch (role)
            {
                case "Заказчик":
                    form = new Zakachik();
                    this.Hide();
                    form.Show();

                    break;
                case "Администратор":
                    form = new Admin();
                    this.Hide();
                    form.Show();

                    break;
                case "Кладовщик":
                    form = new Kladovshik();
                    this.Hide();
                    form.Show();

                    break;
                case "Менеджер":
                    form = new Meneger();
                    this.Hide();
                    form.Show();

                    break;
                default:
                    MessageBox.Show("Роль не установлена или пользователь не найден!");
                    break;

            }
        }
    }
}
