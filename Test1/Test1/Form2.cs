using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myFirstDatabaseDataSet.Tabel' table. You can move, or remove it, as needed.
            this.tabelTableAdapter.Fill(this.myFirstDatabaseDataSet.Tabel);
            // TODO: This line of code loads data into the 'myFirstDatabaseDataSet1.TabelTest' table. You can move, or remove it, as needed.
            this.tabelTestTableAdapter1.Fill(this.myFirstDatabaseDataSet1.TabelTest);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
