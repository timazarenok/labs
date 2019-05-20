namespace Diplom
{
    partial class documents_in_report
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new Diplom.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Diplom.Database1DataSetTableAdapters.studentTableAdapter();
            this.personalsfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personals_filesTableAdapter = new Diplom.Database1DataSetTableAdapters.personals_filesTableAdapter();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Diplom.Database1DataSetTableAdapters.groupsTableAdapter();
            this.groupsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new Diplom.Database1DataSetTableAdapters.subjectsTableAdapter();
            this.specialtesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtesTableAdapter = new Diplom.Database1DataSetTableAdapters.specialtesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.groupsBindingSource1;
            this.comboBox1.DisplayMember = "group_num";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.subjectsBindingSource;
            this.comboBox2.DisplayMember = "sub_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(139, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "id";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.specialtesBindingSource;
            this.comboBox3.DisplayMember = "s_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "spec_id";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.personalsfilesBindingSource;
            this.comboBox4.DisplayMember = "entered";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(139, 39);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            this.comboBox4.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // personalsfilesBindingSource
            // 
            this.personalsfilesBindingSource.DataMember = "personals_files";
            this.personalsfilesBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // personals_filesTableAdapter
            // 
            this.personals_filesTableAdapter.ClearBeforeFill = true;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // groupsBindingSource1
            // 
            this.groupsBindingSource1.DataMember = "groups";
            this.groupsBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // specialtesBindingSource
            // 
            this.specialtesBindingSource.DataMember = "specialtes";
            this.specialtesBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // specialtesTableAdapter
            // 
            this.specialtesTableAdapter.ClearBeforeFill = true;
            // 
            // documents_in_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "documents_in_report";
            this.Text = "documents_in_report";
            this.Load += new System.EventHandler(this.documents_in_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource personalsfilesBindingSource;
        private Database1DataSetTableAdapters.personals_filesTableAdapter personals_filesTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private Database1DataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource1;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private Database1DataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource specialtesBindingSource;
        private Database1DataSetTableAdapters.specialtesTableAdapter specialtesTableAdapter;
    }
}