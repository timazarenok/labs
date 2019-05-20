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
using System.Globalization;

namespace Diplom
{

    public partial class PersonalFile : Form
    {
        public bool chk = false;
        public PersonalFile()
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
            IFormatProvider culture = new CultureInfo("en-US", true);
            string characteristic = textBox1.Text;
            DateTime entereted_date = DateTime.Parse(textBox2.Text, culture);
            string isoDate = entereted_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime deducted_date = DateTime.Parse(textBox3.Text, culture);
            string isoDate1 = deducted_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            string diploma_number = textBox4.Text;
            string number_file = textBox5.Text;
            string b2 = comboBox1.SelectedValue.ToString();
            int a;
            if (chk == false)
            {
                a = 0;
            }
            else
            {
                a = 1;
            }

            string query = "INSERT INTO personals_files(entered,deducted,diploma_number,number_file,characteristic,is_graduate,document_id) VALUES ('" + isoDate + "','" + isoDate1 + "','" + diploma_number + "','" + number_file + "','" + characteristic + "','" + a + "','" + b2 + "')";

            MessageBox.Show(a.ToString());
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

        private void PersonalFile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.database1DataSet.documents);

        }


    }
}
