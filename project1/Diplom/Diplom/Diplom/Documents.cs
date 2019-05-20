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
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
        }

        private void Documents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.database1DataSet.student);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string document_number = textBox2.Text;
            string b2 = comboBox3.SelectedValue.ToString();

            string query = "INSERT INTO documents(document_numbers,student_id) VALUES ('" + document_number + "'," + b2 + ")";

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
