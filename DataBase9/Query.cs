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
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b;
            sqlCommand1.Parameters["@DATA"].Value = Convert.ToDateTime(textBox1.Text);
            sqlCommand1.Parameters["@quantity"].Value = Convert.ToInt32(textBox2.Text);
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            b = (int)sqlCommand1.Parameters["@cout"].Value;
            textBox3.Text = Convert.ToString(b);

        }
    }
}
