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
    public partial class FormComenziSpeciale : Form
    {
        public FormComenziSpeciale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlDataReader dataReader;
            string query = textBox1.Text;
            String Output = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    //command.ExecuteNonQuery();

                    dataReader = command.ExecuteReader();

                    while(dataReader.Read())
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                            Output += dataReader.GetValue(i) + "  ";
                        Output += "\n"; 
                    }

                    MessageBox.Show(Output);
                    

                    
                }
            }
            
            /*
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = textBox1.Text;

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                for(int i = 0; i < dataReader.FieldCount; i++)
                            Output += dataReader.GetValue(i) + " ";
                Output += "\n";
            }

            MessageBox.Show(Output);
            */
        }
    }
}
