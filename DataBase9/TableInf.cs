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
    public partial class TableInf : Form
    {
        public TableInf()
        {
            InitializeComponent();
        }

        private void TableInf_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetInf.Inf_tovar". При необходимости она может быть перемещена или удалена.
            this.inf_tovarTableAdapter.Fill(this.dataSetInf.Inf_tovar);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bb = dataGridView3.CurrentCell.RowIndex;
            inftovarBindingSource.Filter = "Code = '" + dataGridView3[0, bb].Value + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bb = dataGridView3.CurrentCell.RowIndex;
            inftovarBindingSource.Filter = "cost = '" + dataGridView3[1, bb].Value + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bb = dataGridView3.CurrentCell.RowIndex;
            inftovarBindingSource.Filter = "srok = '" + dataGridView3[2, bb].Value + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inftovarBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inftovarBindingSource.EndEdit();
            this.inf_tovarTableAdapter.Update(this.dataSetInf.Inf_tovar);
        }
    }
}
