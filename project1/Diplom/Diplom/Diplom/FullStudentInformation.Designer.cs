namespace Diplom
{
    partial class FullStudentInformation
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
            this.database1DataSet = new Diplom.Database1DataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Diplom.Database1DataSetTableAdapters.studentTableAdapter();
            this.tableAdapterManager = new Diplom.Database1DataSetTableAdapters.TableAdapterManager();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departmentsTableAdapter = null;
            this.tableAdapterManager.documentsTableAdapter = null;
            this.tableAdapterManager.genderTableAdapter = null;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.personals_filesTableAdapter = null;
            this.tableAdapterManager.specialtesTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.subjectsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.database1DataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentBindingSource;
            this.comboBox1.DisplayMember = "student_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.studentBindingSource;
            this.comboBox2.DisplayMember = "student_surname";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "id";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.studentBindingSource;
            this.comboBox3.DisplayMember = "student_secondname";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(149, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secondname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Look";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "student";
            this.studentBindingSource2.DataSource = this.database1DataSet;
            // 
            // FullStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FullStudentInformation";
            this.Text = "FullStudentInformation";
            this.Load += new System.EventHandler(this.FullStudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}