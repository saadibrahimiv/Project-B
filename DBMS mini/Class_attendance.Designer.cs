namespace DBMS_mini
{
    partial class Class_attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet7 = new DBMS_mini.ProjectBDataSet7();
            this.classAttendanceTableAdapter = new DBMS_mini.ProjectBDataSet7TableAdapters.ClassAttendanceTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.projectBDataSet8 = new DBMS_mini.ProjectBDataSet8();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendanceTableAdapter = new DBMS_mini.ProjectBDataSet8TableAdapters.StudentAttendanceTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet9 = new DBMS_mini.ProjectBDataSet9();
            this.studentTableAdapter = new DBMS_mini.ProjectBDataSet9TableAdapters.StudentTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.studentAttendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet10 = new DBMS_mini.ProjectBDataSet10();
            this.studentAttendanceTableAdapter1 = new DBMS_mini.ProjectBDataSet10TableAdapters.StudentAttendanceTableAdapter();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet10)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Attendance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(486, -1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 32);
            this.button9.TabIndex = 65;
            this.button9.Text = "Attendance";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(389, -1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 32);
            this.button8.TabIndex = 64;
            this.button8.Text = "Evaluation";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(292, -1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 32);
            this.button6.TabIndex = 63;
            this.button6.Text = "Assessment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(195, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 62;
            this.button4.Text = "CLO Portal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 61;
            this.button3.Text = "Student Portal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 60;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(0, -1);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 23);
            this.linkLabel2.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Attendance Date";
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet7;
            // 
            // projectBDataSet7
            // 
            this.projectBDataSet7.DataSetName = "ProjectBDataSet7";
            this.projectBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(230, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 25);
            this.button5.TabIndex = 71;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(322, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 27);
            this.button7.TabIndex = 72;
            this.button7.Text = "Mark";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // projectBDataSet8
            // 
            this.projectBDataSet8.DataSetName = "ProjectBDataSet8";
            this.projectBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet8;
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.AttendanceId,
            this.AttendanceStatus});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(90, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 150);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // AttendanceId
            // 
            this.AttendanceId.FillWeight = 80F;
            this.AttendanceId.HeaderText = "AttendanceId";
            this.AttendanceId.Name = "AttendanceId";
            this.AttendanceId.Width = 80;
            // 
            // AttendanceStatus
            // 
            this.AttendanceStatus.HeaderText = "AttendanceStatus";
            this.AttendanceStatus.Name = "AttendanceStatus";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet9;
            // 
            // projectBDataSet9
            // 
            this.projectBDataSet9.DataSetName = "ProjectBDataSet9";
            this.projectBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 74;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(349, 418);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 25);
            this.button10.TabIndex = 75;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // studentAttendanceBindingSource1
            // 
            this.studentAttendanceBindingSource1.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource1.DataSource = this.projectBDataSet10;
            // 
            // projectBDataSet10
            // 
            this.projectBDataSet10.DataSetName = "ProjectBDataSet10";
            this.projectBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentAttendanceTableAdapter1
            // 
            this.studentAttendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(278, 418);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 25);
            this.button11.TabIndex = 77;
            this.button11.Text = "Update";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 69);
            this.panel1.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(62, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Assessment System";
            // 
            // Class_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Class_attendance";
            this.Text = "Class_Attendance";
            this.Load += new System.EventHandler(this.Class_attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet10)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private ProjectBDataSet7 projectBDataSet7;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSet7TableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private ProjectBDataSet8 projectBDataSet8;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet8TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet9 projectBDataSet9;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet9TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceId;
        private System.Windows.Forms.DataGridViewComboBoxColumn AttendanceStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private ProjectBDataSet10 projectBDataSet10;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource1;
        private ProjectBDataSet10TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}