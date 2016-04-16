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
    public partial class TableTovar : Form
    {
        public TableTovar()
        {
            InitializeComponent();
        }

        private void TableTovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aditionalDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.aditionalDataSet.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetTovar.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.dataSetTovar.Tovar);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int bb = dataGridView2.CurrentCell.RowIndex;
            tovarBindingSource.Filter = "Code = '" + dataGridView2[0, bb].Value + "'";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int bb = dataGridView2.CurrentCell.RowIndex;
            tovarBindingSource.Filter = "FirmID = '" + dataGridView2[0, bb].Value + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int bb = dataGridView2.CurrentCell.RowIndex;
            tovarBindingSource.Filter = "name = '" + dataGridView2[0, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int bb = dataGridView2.CurrentCell.RowIndex;
            tovarBindingSource.Filter = "kolvo = '" + dataGridView2[0, bb].Value + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tovarBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tovarBindingSource.EndEdit();
            this.tovarTableAdapter.Update(this.dataSetTovar.Tovar);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
