namespace Diplom
{
    partial class list_of_graduates
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
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new Diplom.Database1DataSetTableAdapters.departmentsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.personalsfilesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personalsfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personals_filesTableAdapter = new Diplom.Database1DataSetTableAdapters.personals_filesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsfilesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsfilesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(141, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Secondname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Speciality";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Group number";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Entered date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBox1.Location = new System.Drawing.Point(14, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // personalsfilesBindingSource1
            // 
            this.personalsfilesBindingSource1.DataMember = "personals_files";
            this.personalsfilesBindingSource1.DataSource = this.database1DataSetBindingSource1;
            // 
            // database1DataSetBindingSource1
            // 
            this.database1DataSetBindingSource1.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource1.Position = 0;
            // 
            // personalsfilesBindingSource
            // 
            this.personalsfilesBindingSource.DataMember = "personals_files";
            this.personalsfilesBindingSource.DataSource = this.database1DataSetBindingSource1;
            // 
            // personals_filesTableAdapter
            // 
            this.personals_filesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_of_graduates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "list_of_graduates";
            this.Text = "list_of_graduates";
            this.Load += new System.EventHandler(this.list_of_graduates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsfilesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalsfilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private Database1DataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource personalsfilesBindingSource;
        private Database1DataSetTableAdapters.personals_filesTableAdapter personals_filesTableAdapter;
        private System.Windows.Forms.BindingSource personalsfilesBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}