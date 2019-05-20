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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string buf = textBox1.Text;
            string b = curator.SelectedValue.ToString();
            string g = comboBox2.SelectedValue.ToString();

            string query = "INSERT INTO groups(group_num,curator_id,s_id ) VALUES ('" + buf + "'," + b + "," + g + ")";



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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.specialtes". При необходимости она может быть перемещена или удалена.
            this.specialtesTableAdapter.Fill(this.database1DataSet.specialtes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.database1DataSet.teachers);

        }
    }
}
