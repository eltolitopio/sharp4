using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _4lab_
{
      
    
    public partial class Form1 : Form
    {
        private StudentCollection studentCollection;
        private BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            InitializeDataGridView();
        }


        private void InitializeDataGridView()
        {
            bindingSource = new BindingSource();
            studentCollection = new StudentCollection();
            bindingSource.DataSource = studentCollection.Students;
            dataGridView1.DataSource = bindingSource;
        }

        private void LoadData()
        {
            if (File.Exists("data.bin"))
            {
                using (var fileStream = File.OpenRead("data.bin"))
                {
                    var formatter = new BinaryFormatter();
                    studentCollection = (StudentCollection)formatter.Deserialize(fileStream);
                }
            }
            else
            {
                studentCollection = new StudentCollection();
            }
        }

        private void SaveData()
        {
            using (var fileStream = File.Create("data.bin"))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, studentCollection);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }


        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var fName = firstName.Text;
            var lName = lastName.Text;
            var student = new Student(fName, lName);
            studentCollection.Students.Add(student);
            bindingSource.ResetBindings(false);
            firstName.Text = "";
            lastName.Text = "";
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                studentCollection.Students.Remove(selectedStudent);
                bindingSource.ResetBindings(false);
            }
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                var fName = firstName.Text;
                var lName = lastName.Text;
                selectedStudent.FirstName = fName;
                selectedStudent.LastName = lName;
                bindingSource.ResetBindings(false);
            }
        }

        private void addSubToStuButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                var subject = subjectBox.Text;
                var grade = int.Parse(gradeBox.Text);
                selectedStudent.Grades[subject] = grade;
                bindingSource.ResetBindings(false);
                subjectBox.Text = "";
                gradeBox.Text = "";
            }
        }
        private void deleteGrade_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedStudent = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                var subject = subjectBox.Text;
                selectedStudent.Grades.Remove(subject);
                bindingSource.ResetBindings(false);
                subjectBox.Text = "";
                gradeBox.Text = "";
            }
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            studentCollection.Students = studentCollection.Students.OrderBy(ch => ch.LastName).ToList();
            bindingSource.ResetBindings(false);
        }

        
        private void showStudentButton_Click(object sender, EventArgs e)
        {
            var subject = selectSubject.Text;
            var selectedStudents = studentCollection.Students.Where(s => s.Grades.ContainsKey(subject)).ToList();

            var dialog = new StudentsDialog(selectedStudents);
            dialog.ShowDialog();
        }
        

        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
