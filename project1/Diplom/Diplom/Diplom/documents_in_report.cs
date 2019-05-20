using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class documents_in_report : Form
    {
        public documents_in_report()
        {
            InitializeComponent();
        }

        private void documents_in_report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.specialtes". При необходимости она может быть перемещена или удалена.
            this.specialtesTableAdapter.Fill(this.database1DataSet.specialtes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.database1DataSet.subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.database1DataSet.groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.personals_files". При необходимости она может быть перемещена или удалена.
            this.personals_filesTableAdapter.Fill(this.database1DataSet.personals_files);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.database1DataSet.student);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
