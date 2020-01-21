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
    public partial class FormRepartizareParcele : Form
    {
        public FormRepartizareParcele()
        {
            InitializeComponent();
        }

        private void FormRepartizareParcele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRAMADataSet.Repartizare_Parcele' table. You can move, or remove it, as needed.
            this.repartizare_ParceleTableAdapter.Fill(this.cRAMADataSet.Repartizare_Parcele);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO crama..Repartizare_Parcele " + "Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text +  "')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie inserata  !\n");

                    this.repartizare_ParceleTableAdapter.Fill(this.cRAMADataSet.Repartizare_Parcele);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM crama..Repartizare_Parcele " + "WHERE  (ID_Parcela, CNP_Angajat) = ('" + textBox1.Text + "', '" + textBox2.Text + "') ";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie Stearsa  !\n");

                    this.repartizare_ParceleTableAdapter.Fill(this.cRAMADataSet.Repartizare_Parcele);
                }
            }
        }
    }
}
