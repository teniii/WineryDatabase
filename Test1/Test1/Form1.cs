using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select * from TabelTest";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) +" "+ dataReader.GetValue(2) + "\n";
            }

            MessageBox.Show("Connection Open  !\n"+ cnn.State);

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();



            MessageBox.Show("Connection " + cnn.State);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Insert into TabelTest (PersonID,FirstName,LastName) values (4,'Irina','Tenita')";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Connection " + cnn.State);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Update TabelTest set FirstName = '"+"irina" + "' where PersonID = 4";

            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Connection " + cnn.State);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-8KN1OOC\TENITASQL;Initial Catalog=myFirstDatabase;User ID=sa;Password=20003030";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            sql = "Delete TabelTest where PersonID = 4";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            MessageBox.Show("Connection " + cnn.State);

        }
    }
}
