using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Diplom
{
    public partial class TeacherName : Form
    {
        public TeacherName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string buf = textBox1.Text;


            string query = "INSERT INTO teachers(teach_name) VALUES ('" + buf + "')";



            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successful");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Enter unique value");
                }
                Hide();
                connection.Close();
            }
        }
    }
}
