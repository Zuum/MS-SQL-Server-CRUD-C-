using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase9
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetInf.Inf_tovar". При необходимости она может быть перемещена или удалена.
            this.inf_tovarTableAdapter.Fill(this.dataSetInf.Inf_tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetTovar.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.dataSetTovar.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetPostavshik.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.dataSetPostavshik.Postavshik);

        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablePostavshik Form2 = new TablePostavshik();
            Form2.Show();

        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableTovar Form3 = new TableTovar();
            Form3.Show();
        }

        private void информацияОТовареToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableInf Form4 = new TableInf();
            Form4.Show();
        }

        private void количествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query Form5 = new Query();
            Form5.Show();
        }

        private void табличнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1.Show();
        }

        private void свободнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report2.RegisterData(dataSetTovar, "Tovar");
            report2.Show();
        }
    }
}
