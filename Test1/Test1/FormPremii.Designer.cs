namespace Test1
{
    partial class FormPremii
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cRAMADataSet = new Test1.CRAMADataSet();
            this.premiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premiiTableAdapter = new Test1.CRAMADataSetTableAdapters.PremiiTableAdapter();
            this.iDConcursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddebareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medaliaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDConcursDataGridViewTextBoxColumn,
            this.coddebareDataGridViewTextBoxColumn,
            this.medaliaDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.premiiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premiiBindingSource, "Descriere", true));
            this.textBox4.Location = new System.Drawing.Point(371, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premiiBindingSource, "Medalia", true));
            this.textBox3.Location = new System.Drawing.Point(265, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premiiBindingSource, "Cod_de_bare", true));
            this.textBox2.Location = new System.Drawing.Point(159, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.premiiBindingSource, "ID_Concurs", true));
            this.textBox1.Location = new System.Drawing.Point(53, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // premiiBindingSource
            // 
            this.premiiBindingSource.DataMember = "Premii";
            this.premiiBindingSource.DataSource = this.cRAMADataSet;
            // 
            // premiiTableAdapter
            // 
            this.premiiTableAdapter.ClearBeforeFill = true;
            // 
            // iDConcursDataGridViewTextBoxColumn
            // 
            this.iDConcursDataGridViewTextBoxColumn.DataPropertyName = "ID_Concurs";
            this.iDConcursDataGridViewTextBoxColumn.HeaderText = "ID_Concurs";
            this.iDConcursDataGridViewTextBoxColumn.Name = "iDConcursDataGridViewTextBoxColumn";
            // 
            // coddebareDataGridViewTextBoxColumn
            // 
            this.coddebareDataGridViewTextBoxColumn.DataPropertyName = "Cod_de_bare";
            this.coddebareDataGridViewTextBoxColumn.HeaderText = "Cod_de_bare";
            this.coddebareDataGridViewTextBoxColumn.Name = "coddebareDataGridViewTextBoxColumn";
            // 
            // medaliaDataGridViewTextBoxColumn
            // 
            this.medaliaDataGridViewTextBoxColumn.DataPropertyName = "Medalia";
            this.medaliaDataGridViewTextBoxColumn.HeaderText = "Medalia";
            this.medaliaDataGridViewTextBoxColumn.Name = "medaliaDataGridViewTextBoxColumn";
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "Descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            // 
            // FormPremii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormPremii";
            this.Text = "Premii";
            this.Load += new System.EventHandler(this.FormPremii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CRAMADataSet cRAMADataSet;
        private System.Windows.Forms.BindingSource premiiBindingSource;
        private CRAMADataSetTableAdapters.PremiiTableAdapter premiiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDConcursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddebareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medaliaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
    }
}