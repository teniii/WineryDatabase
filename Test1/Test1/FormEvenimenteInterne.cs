using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class FormEvenimenteInterne : Form
    {
        public FormEvenimenteInterne()
        {
            InitializeComponent();
        }

        private void FormEvenimenteInterne_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRAMADataSet.Evenimente_interne' table. You can move, or remove it, as needed.
            this.evenimente_interneTableAdapter.Fill(this.cRAMADataSet.Evenimente_interne);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO crama..Evenimente_Interne " + "Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie inserata  !\n");

                    this.evenimente_interneTableAdapter.Fill(this.cRAMADataSet.Evenimente_interne);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM crama..Evenimente_Interne " + "WHERE ( ID_Eveniment = '" + textBox1.Text + "')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie Stearsa  !\n");

                    this.evenimente_interneTableAdapter.Fill(this.cRAMADataSet.Evenimente_interne);
                }
            }
        }
    }
}
