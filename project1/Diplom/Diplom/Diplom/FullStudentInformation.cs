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
    public partial class FullStudentInformation : Form
    {
        public FullStudentInformation()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FullStudentInformation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.database1DataSet.student);

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedValue.ToString();
            StudentInfo f1 = new StudentInfo(id);
            f1.ShowDialog();
        }
    }
}
