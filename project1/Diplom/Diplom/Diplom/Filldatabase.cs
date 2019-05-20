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
    public partial class Filldatabase : Form
    {
        public Filldatabase()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            


            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            


            string query = "INSERT INTO gender(gender_name) VALUES ('Male'),('Female')";




            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
               
                
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
          
               
                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Department f2 = new Department();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Specialtes f3 = new Specialtes();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherName f4 = new TeacherName();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subject f5 = new Subject();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Group f6 = new Group();
            f6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Student f7 = new Student();
            f7.ShowDialog();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            Documents f9 = new Documents();
            f9.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonalFile f10 = new PersonalFile();
            f10.ShowDialog();
        }

 
    }
  

        
}
