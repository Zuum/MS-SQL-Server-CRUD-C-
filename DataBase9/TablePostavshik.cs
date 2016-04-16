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
    public partial class TablePostavshik : Form
    {
        public TablePostavshik()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablePostavshik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetPostavshik.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.dataSetPostavshik.Postavshik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postavshikBindingSource.EndEdit();
            this.postavshikTableAdapter.Update(this.dataSetPostavshik.Postavshik);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int bb = dataGridView1.CurrentCell.RowIndex;
            postavshikBindingSource.Filter = "Firma = '" + dataGridView1[0, bb].Value+"'";
        
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int bb = dataGridView1.CurrentCell.RowIndex;
            postavshikBindingSource.Filter = "Code = '" + dataGridView1[1, bb].Value+"'";
        
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int bb = dataGridView1.CurrentCell.RowIndex;
            postavshikBindingSource.Filter = "Adress = '" + dataGridView1[2, bb].Value+"'";
        
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int bb = dataGridView1.CurrentCell.RowIndex;
            postavshikBindingSource.Filter = "Phone = '" + dataGridView1[3, bb].Value+"'";

        }
    }
}
