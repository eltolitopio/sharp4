using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace _4lab_
{
    internal class StudentsDialog : Form
    {
        private ListBox studentsListBox;

        public StudentsDialog(List<Student> students)
        {
            InitializeComponent();
            studentsListBox.DataSource = students;
        }

        private void InitializeComponent()
        {
            studentsListBox = new ListBox();
            Controls.Add(studentsListBox);
            Size = new Size(200, 200);
            Text = "Selected Students";
        }
    }
}
