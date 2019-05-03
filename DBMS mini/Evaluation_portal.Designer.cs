namespace DBMS_mini
{
    partial class Evaluation_portal
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssessmentComponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentComponentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricMeasurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new DBMS_mini.ProjectBDataSet6();
            this.studentResultTableAdapter = new DBMS_mini.ProjectBDataSet6TableAdapters.StudentResultTableAdapter();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Evaluation";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reg. Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assessment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Component";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Obtained Level";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(182, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(182, 218);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(182, 245);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Evaluation Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.studentIdDataGridViewTextBoxColumn,
            this.AssessmentComponent,
            this.assessmentComponentIdDataGridViewTextBoxColumn,
            this.ObtainedLevel,
            this.rubricMeasurementIdDataGridViewTextBoxColumn,
            this.evaluationDateDataGridViewTextBoxColumn,
            this.ObtainedMarks,
            this.TotalMarks,
            this.Delete,
            this.Update});
            this.dataGridView1.DataSource = this.studentResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Student
            // 
            this.Student.FillWeight = 150F;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.Width = 150;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.FillWeight = 60F;
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ToolTipText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // AssessmentComponent
            // 
            this.AssessmentComponent.HeaderText = "AssessmentComponent";
            this.AssessmentComponent.Name = "AssessmentComponent";
            // 
            // assessmentComponentIdDataGridViewTextBoxColumn
            // 
            this.assessmentComponentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentComponentId";
            this.assessmentComponentIdDataGridViewTextBoxColumn.Name = "assessmentComponentIdDataGridViewTextBoxColumn";
            // 
            // ObtainedLevel
            // 
            this.ObtainedLevel.FillWeight = 80F;
            this.ObtainedLevel.HeaderText = "ObtainedLevel";
            this.ObtainedLevel.Name = "ObtainedLevel";
            this.ObtainedLevel.Width = 80;
            // 
            // rubricMeasurementIdDataGridViewTextBoxColumn
            // 
            this.rubricMeasurementIdDataGridViewTextBoxColumn.DataPropertyName = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.HeaderText = "RubricMeasurementId";
            this.rubricMeasurementIdDataGridViewTextBoxColumn.Name = "rubricMeasurementIdDataGridViewTextBoxColumn";
            // 
            // evaluationDateDataGridViewTextBoxColumn
            // 
            this.evaluationDateDataGridViewTextBoxColumn.DataPropertyName = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.HeaderText = "EvaluationDate";
            this.evaluationDateDataGridViewTextBoxColumn.Name = "evaluationDateDataGridViewTextBoxColumn";
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            // 
            // TotalMarks
            // 
            this.TotalMarks.HeaderText = "TotalMarks";
            this.TotalMarks.Name = "TotalMarks";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // Update
            // 
            this.Update.FillWeight = 50F;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 50;
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(486, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 32);
            this.button9.TabIndex = 51;
            this.button9.Text = "Attendance";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(389, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 32);
            this.button8.TabIndex = 50;
            this.button8.Text = "Evaluation";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(292, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 32);
            this.button6.TabIndex = 49;
            this.button6.Text = "Assessment";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(195, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 48;
            this.button4.Text = "CLO Portal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 47;
            this.button3.Text = "Student Portal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 46;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(0, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 23);
            this.linkLabel2.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 69);
            this.panel1.TabIndex = 52;
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
            // Evaluation_portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Evaluation_portal";
            this.Text = "Evaluation_portal";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet6TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssessmentComponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentComponentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricMeasurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}