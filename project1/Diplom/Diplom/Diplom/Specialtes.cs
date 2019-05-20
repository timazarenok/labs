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
    public partial class Specialtes : Form
    {
        public Specialtes()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.database1DataSet.departments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string buf = textBox1.Text;
            string b = comboBox1.SelectedValue.ToString();

            string query = "INSERT INTO specialtes(s_name,department) VALUES ('" + buf + "'," + b + ")";

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
