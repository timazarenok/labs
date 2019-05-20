namespace Diplom
{
    partial class Group
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.curator = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Diplom.Database1DataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.specialtesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new Diplom.Database1DataSetTableAdapters.teachersTableAdapter();
            this.specialtesTableAdapter = new Diplom.Database1DataSetTableAdapters.specialtesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialtes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // curator
            // 
            this.curator.DataSource = this.teachersBindingSource;
            this.curator.DisplayMember = "teach_name";
            this.curator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.curator.FormattingEnabled = true;
            this.curator.Location = new System.Drawing.Point(91, 63);
            this.curator.Name = "curator";
            this.curator.Size = new System.Drawing.Size(164, 21);
            this.curator.TabIndex = 4;
            this.curator.ValueMember = "id";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.specialtesBindingSource;
            this.comboBox2.DisplayMember = "s_name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(261, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "spec_id";
            // 
            // specialtesBindingSource
            // 
            this.specialtesBindingSource.DataMember = "specialtes";
            this.specialtesBindingSource.DataSource = this.database1DataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // specialtesTableAdapter
            // 
            this.specialtesTableAdapter.ClearBeforeFill = true;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 272);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.curator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Group";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox curator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private Database1DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource specialtesBindingSource;
        private Database1DataSetTableAdapters.specialtesTableAdapter specialtesTableAdapter;
    }
}