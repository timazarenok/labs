namespace Diplom
{
    partial class Specialtes
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Diplom.Database1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentsTableAdapter = new Diplom.Database1DataSetTableAdapters.departmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Specialtes Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departmentsBindingSource;
            this.comboBox1.DisplayMember = "d_name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "id";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Department Name";
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Specialtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 222);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Specialtes";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private Database1DataSetTableAdapters.departmentsTableAdapter departmentsTableAdapter;
    }
}