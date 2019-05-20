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
    public partial class Usedatabse : Form
    {
        public Usedatabse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullStudentInformation f1 = new FullStudentInformation();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            list_of_graduates f2 = new list_of_graduates();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deducted_student f3 = new deducted_student();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reservists f4 = new Reservists();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            documents_in_report f5 = new documents_in_report();
            f5.ShowDialog();
        }
    }
}
