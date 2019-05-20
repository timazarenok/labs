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
    public partial class documents_in_report_view : Form
    {
        public documents_in_report_view()
        {
            InitializeComponent();
            LoadData();
            LoadData1();
        }

        string ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True";

        private void LoadData1()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT student.student_name, student.student_surname, student.student_secondname, gender.gender_name, student.is_reservist, groups.group_num, " +
                         "teachers.teach_name " +
                         "FROM student " +
                         "INNER JOIN " +
                         "gender ON student.gender_id = gender.id INNER JOIN " +
                         "groups ON student.groupss = groups.id INNER JOIN " +
                         "teachers ON groups.curator_id = teachers.id " +
                         "where student.id = '" + id + "'";


                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }

                reader.Close();

                connection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT student.student_name, student.student_surname, student.student_secondname, gender.gender_name, student.is_reservist, groups.group_num, " +
                         "teachers.teach_name " +
                         "FROM student " +
                         "INNER JOIN " +
                         "gender ON student.gender_id = gender.id INNER JOIN " +
                         "groups ON student.groupss = groups.id INNER JOIN " +
                         "teachers ON groups.curator_id = teachers.id " +
                         "where student.id = '" + id + "'";


                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }

                reader.Close();

                connection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }

        }
    }
    
}
