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
using System.IO;

namespace DEMO
{
    public partial class Reg : Form
    {

        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");

        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form lp = new Logpas();
            lp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int errors = 0;
            String message = "";

            if (textBox1.Text == "")
            {
                errors++;
                message += "Пожалуйста введите имя\n";
            }

            if (textBox2.Text == "")
            {
                errors++;
                message += "Пожалуйста введите логин\n";
            }

            if (textBox3.Text == "")
            {
                errors++;
                message += "Пожалуйста введите пароль\n";
            }

            if (textBox4.Text == "")
            {
                errors++;
                message += "Пожалуйста введите подтверждение пароля\n";
            }

            if (textBox3.Text != textBox4.Text)
            {
                errors++;
                message += "Пароли не совпадают!\n";
            }

            if (errors > 0)
            {
                MessageBox.Show(message);
            }

            else
            {
                ConnectionString.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Пользователь (Логин,Пароль,Роль,Наименование) VALUES (@Логин,@Пароль,@Роль,@Наименование)", ConnectionString);
                    command.Parameters.AddWithValue("@Логин", textBox2.Text);
                    command.Parameters.AddWithValue("@Пароль", textBox3.Text);
                    command.Parameters.AddWithValue("@Роль", "Заказчик");
                    command.Parameters.AddWithValue("@Наименование", textBox1.Text);
                    int regged = Convert.ToInt32(command.ExecuteNonQuery());
                    ConnectionString.Close();
                    MessageBox.Show("Пользователь успешно зарегистрировался!\n");

                    Form lp = new Logpas();
                    lp.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Такой пользователь существует!\n");

                }

            }
        }
    }
}
