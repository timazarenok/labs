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
    public partial class Student : Form
    {
        public bool chk = false;
        public Student()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chk = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            string buf = textBox1.Text;
            string buf1 = textBox2.Text;
            string buf2 = textBox3.Text;
            string buf3 = comboBox2.SelectedValue.ToString();
            string b = comboBox1.SelectedValue.ToString();
            int a;
            if(chk == false)
            {
                a = 0;
            }
            else
            {
                a = 1;
            }

            string query = "INSERT INTO student(student_name,student_surname,student_secondname,gender_id,groupss,is_reservist) VALUES ('" + buf + "','" + buf1 + "','" + buf2 + "'," + buf3 + "," + b + ","+ a + ")";

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

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.database1DataSet.gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.database1DataSet.groups);

        }

    }
}

