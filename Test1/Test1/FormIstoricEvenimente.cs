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
    public partial class FormIstoricEvenimente : Form
    {
        public FormIstoricEvenimente()
        {
            InitializeComponent();
        }

        private void FormIstoricEvenimente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRAMADataSet.Istoric_Evenimente' table. You can move, or remove it, as needed.
            this.istoric_EvenimenteTableAdapter.Fill(this.cRAMADataSet.Istoric_Evenimente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO crama..Istoric_Evenimente " + "Values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text  + "')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    
                        
                        command.ExecuteNonQuery();
                        
                        
                    
                    /*
                    catch(Exception e)
                    {
                        Console.WriteLine("{0} Exceptie!.", e);
                        MessageBox.Show("Camp trunchiat! Reincercati!");
                    }
                    */
                    MessageBox.Show("Linie inserata  !\n");

                    this.istoric_EvenimenteTableAdapter.Fill(this.cRAMADataSet.Istoric_Evenimente);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM crama..Istoric_Evenimente " + "WHERE ( ID_Eveniment, CNP_Client) = ('" + textBox1.Text + "', '" +textBox2.Text + "')";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Linie Stearsa  !\n");

                    this.istoric_EvenimenteTableAdapter.Fill(this.cRAMADataSet.Istoric_Evenimente);
                }
            }
        }
    }
}
