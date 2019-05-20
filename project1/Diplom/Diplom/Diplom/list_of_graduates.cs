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
    public partial class list_of_graduates : Form
    {
        public list_of_graduates()
        {
            InitializeComponent();
            
        }

        
        private void list_of_graduates_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.personals_files". При необходимости она может быть перемещена или удалена.
            this.personals_filesTableAdapter.Fill(this.database1DataSet.personals_files);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.database1DataSet.departments);

        }

        string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

 

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string id = "0";

                try
                {
                    id = comboBox1.SelectedItem.ToString();
                }
                catch(System.NullReferenceException)
                {
                    id = "2";
                }
                string query = "SELECT student.student_name, student.student_surname, student.student_secondname, specialtes.s_name, groups.group_num, personals_files.entered " +
                                "FROM student INNER JOIN " +
                                "groups ON student.groupss = groups.id INNER JOIN " +
                                "specialtes ON groups.s_id = specialtes.spec_id INNER JOIN " +
                                "personals_files ON student.id = personals_files.id " +
                                "where personals_files.deducted like '%" + id + "%' and personals_files.is_graduate = 1";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }

                reader.Close();

                connection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }

        }
    }
}
