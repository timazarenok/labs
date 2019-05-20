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
    public partial class Reservists : Form
    {
        public Reservists()
        {
            InitializeComponent();
        }

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
                catch (System.NullReferenceException)
                {
                    id = "2";
                }
                string query = "SELECT student.student_name, student.student_surname, student.student_secondname, specialtes.s_name, groups.group_num, personals_files.entered " +
                                "FROM student INNER JOIN " +
                                "groups ON student.groupss = groups.id INNER JOIN " +
                                "specialtes ON groups.s_id = specialtes.spec_id INNER JOIN " +
                                "personals_files ON student.id = personals_files.id " +
                                "where personals_files.entered like '%" + id + "%' and student.is_reservist = 1";

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
