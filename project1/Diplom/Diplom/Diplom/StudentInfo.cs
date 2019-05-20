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
    public partial class StudentInfo : Form
    {
        public StudentInfo(string id)
        {
            InitializeComponent();
            LoadData(id);
            LoadData1(id);
            LoadData2(id);
            get_id(id);
        }

        private void LoadData2(string id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string d_id = get_id(id);
                string query = "SELECT characteristic FROM personals_files where personals_files.document_id = '" + d_id + "'";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = reader[0].ToString();

                }

                reader.Close();

                connection.Close();
                foreach (string[] i in data)
                    dataGridView3.Rows.Add(i);
            }
        }

        private string get_id(string id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string get_id = "select id from documents where documents.student_id = '" + id + "'";
                SqlCommand command1 = new SqlCommand(get_id, connection);
                SqlDataReader reader = command1.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = reader[0].ToString();

                }
                string d_id = data[data.Count - 1][0];
                reader.Close();

                connection.Close();
                
                return d_id;
            }
        }


        private void LoadData1(string id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                MessageBox.Show(id);
                string d_id = get_id(id);
                string query = "SELECT documents.document_numbers, documents.is_archeve, personals_files.entered, personals_files.deducted, personals_files.diploma_number, " +
                                "personals_files.number_file, personals_files.is_graduate " +
                                "FROM documents INNER JOIN " +
                                "personals_files ON documents.id = personals_files.document_id " +
                                "where documents.student_id = '" + id + "' and personals_files.document_id = '" + d_id +"'";

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
                foreach (string[] i in data)
                    dataGridView2.Rows.Add(i);
            }
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.database1DataSet.departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.personals_files". При необходимости она может быть перемещена или удалена.
            this.personals_filesTableAdapter.Fill(this.database1DataSet.personals_files);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.database1DataSet.documents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.database1DataSet.student);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillBy(this.database1DataSet.student);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        string ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True";


        private void LoadData(string id)
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
