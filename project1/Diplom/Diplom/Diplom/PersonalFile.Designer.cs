namespace Diplom
{
    partial class PersonalFile
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.documentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Diplom.Database1DataSet();
            this.documentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.documentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new Diplom.Database1DataSetTableAdapters.documentsTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(449, 279);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 354);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 380);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 406);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(99, 20);
            this.textBox5.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.documentsBindingSource3;
            this.comboBox1.DisplayMember = "document_numbers";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 328);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "id";
            // 
            // documentsBindingSource3
            // 
            this.documentsBindingSource3.DataMember = "documents";
            this.documentsBindingSource3.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsBindingSource2
            // 
            this.documentsBindingSource2.DataMember = "documents";
            this.documentsBindingSource2.DataSource = this.database1DataSet;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "documents";
            this.documentsBindingSource.DataSource = this.database1DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Characteristic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Entered Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Deducted date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Diplom number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Document Number";
            // 
            // documentsBindingSource1
            // 
            this.documentsBindingSource1.DataMember = "documents";
            this.documentsBindingSource1.DataSource = this.database1DataSet;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(211, 356);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Is graduate";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PersonalFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 521);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "PersonalFile";
            this.Text = "PersonalFile";
            this.Load += new System.EventHandler(this.PersonalFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource documentsBindingSource1;
        private System.Windows.Forms.BindingSource documentsBindingSource2;
        private System.Windows.Forms.BindingSource documentsBindingSource3;
        private Database1DataSetTableAdapters.documentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}