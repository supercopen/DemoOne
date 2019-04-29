using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class Kladovshik : Form
    {
        public Kladovshik()
        {
            InitializeComponent();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demo_exDataSet);

        }

        private void Kladovshik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_exDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this.demo_exDataSet.Пользователь);

        }

        private void тканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tk = new tkani();
            tk.Show();
            this.Close();
        }

        private void фурнитураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fur = new Furnitura();
            fur.Show();
            this.Close();
        }
    }
}
