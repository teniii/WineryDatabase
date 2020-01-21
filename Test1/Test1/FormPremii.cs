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
    public partial class FormPremii : Form
    {
        public FormPremii()
        {
            InitializeComponent();
        }

        private void FormPremii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRAMADataSet.Premii' table. You can move, or remove it, as needed.
            this.premiiTableAdapter.Fill(this.cRAMADataSet.Premii);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO crama..Premii " + "Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie inserata  !\n");

                    this.premiiTableAdapter.Fill(this.cRAMADataSet.Premii);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM crama..Premii " + "WHERE  (ID_Concurs, Cod_de_bare) = ('" + textBox1.Text + "', '" + textBox2.Text +  "') ";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie Stearsa  !\n");

                    this.premiiTableAdapter.Fill(this.cRAMADataSet.Premii);
                }
            }
        }

        
    }
}
