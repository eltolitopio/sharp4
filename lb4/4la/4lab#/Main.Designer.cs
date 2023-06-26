namespace _4lab_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addStudentButton = new System.Windows.Forms.Button();
            this.showStudentButton = new System.Windows.Forms.Button();
            this.addGrade = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortButton = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.editStudent = new System.Windows.Forms.Button();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.deleteGrade = new System.Windows.Forms.Button();
            this.selectSubject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(996, 68);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(149, 39);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // showStudentButton
            // 
            this.showStudentButton.Location = new System.Drawing.Point(996, 423);
            this.showStudentButton.Name = "showStudentButton";
            this.showStudentButton.Size = new System.Drawing.Size(149, 39);
            this.showStudentButton.TabIndex = 2;
            this.showStudentButton.Text = "Show Student";
            this.showStudentButton.UseVisualStyleBackColor = true;
            this.showStudentButton.Click += new System.EventHandler(this.showStudentButton_Click);
            // 
            // addGrade
            // 
            this.addGrade.Location = new System.Drawing.Point(996, 259);
            this.addGrade.Name = "addGrade";
            this.addGrade.Size = new System.Drawing.Size(149, 39);
            this.addGrade.TabIndex = 6;
            this.addGrade.Text = "Add Grade";
            this.addGrade.UseVisualStyleBackColor = true;
            this.addGrade.Click += new System.EventHandler(this.addSubToStuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "First name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(996, 12);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(149, 22);
            this.firstName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(876, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(996, 40);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(149, 22);
            this.lastName.TabIndex = 11;
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(996, 231);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(149, 22);
            this.gradeBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(876, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Subject";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(876, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Grade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 389);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(996, 350);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(149, 39);
            this.sortButton.TabIndex = 21;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(996, 113);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(149, 39);
            this.deleteStudent.TabIndex = 23;
            this.deleteStudent.Text = "Delete Student";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // editStudent
            // 
            this.editStudent.Location = new System.Drawing.Point(996, 158);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(149, 39);
            this.editStudent.TabIndex = 24;
            this.editStudent.Text = "Edit Student";
            this.editStudent.UseVisualStyleBackColor = true;
            this.editStudent.Click += new System.EventHandler(this.editStudent_Click);
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(996, 203);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(149, 22);
            this.subjectBox.TabIndex = 25;
            // 
            // deleteGrade
            // 
            this.deleteGrade.Location = new System.Drawing.Point(996, 304);
            this.deleteGrade.Name = "deleteGrade";
            this.deleteGrade.Size = new System.Drawing.Size(149, 39);
            this.deleteGrade.TabIndex = 26;
            this.deleteGrade.Text = "Delete Grade";
            this.deleteGrade.UseVisualStyleBackColor = true;
            this.deleteGrade.Click += new System.EventHandler(this.deleteGrade_Click);
            // 
            // selectSubject
            // 
            this.selectSubject.Location = new System.Drawing.Point(996, 395);
            this.selectSubject.Name = "selectSubject";
            this.selectSubject.Size = new System.Drawing.Size(149, 22);
            this.selectSubject.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 572);
            this.Controls.Add(this.selectSubject);
            this.Controls.Add(this.deleteGrade);
            this.Controls.Add(this.subjectBox);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.addGrade);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.showStudentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button showStudentButton;
        private System.Windows.Forms.Button addGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Button editStudent;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Button deleteGrade;
        private System.Windows.Forms.TextBox selectSubject;
    }
}

