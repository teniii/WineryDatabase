namespace Test1
{
    partial class FormConcursuri
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cRAMADataSet = new Test1.CRAMADataSet();
            this.concursuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concursuriTableAdapter = new Test1.CRAMADataSetTableAdapters.ConcursuriTableAdapter();
            this.iDConcursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeconcursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concursuriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concursuriBindingSource, "ID_Concurs", true));
            this.textBox1.Location = new System.Drawing.Point(45, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concursuriBindingSource, "Nume_concurs", true));
            this.textBox2.Location = new System.Drawing.Point(151, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concursuriBindingSource, "Data", true));
            this.textBox3.Location = new System.Drawing.Point(257, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concursuriBindingSource, "Editie", true));
            this.textBox4.Location = new System.Drawing.Point(363, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concursuriBindingSource, "Localitate", true));
            this.textBox5.Location = new System.Drawing.Point(469, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concursuriBindingSource, "Stat", true));
            this.textBox6.Location = new System.Drawing.Point(575, 61);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDConcursDataGridViewTextBoxColumn,
            this.numeconcursDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.editieDataGridViewTextBoxColumn,
            this.localitateDataGridViewTextBoxColumn,
            this.statDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.concursuriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // concursuriBindingSource
            // 
            this.concursuriBindingSource.DataMember = "Concursuri";
            this.concursuriBindingSource.DataSource = this.cRAMADataSet;
            // 
            // concursuriTableAdapter
            // 
            this.concursuriTableAdapter.ClearBeforeFill = true;
            // 
            // iDConcursDataGridViewTextBoxColumn
            // 
            this.iDConcursDataGridViewTextBoxColumn.DataPropertyName = "ID_Concurs";
            this.iDConcursDataGridViewTextBoxColumn.HeaderText = "ID_Concurs";
            this.iDConcursDataGridViewTextBoxColumn.Name = "iDConcursDataGridViewTextBoxColumn";
            // 
            // numeconcursDataGridViewTextBoxColumn
            // 
            this.numeconcursDataGridViewTextBoxColumn.DataPropertyName = "Nume_concurs";
            this.numeconcursDataGridViewTextBoxColumn.HeaderText = "Nume_concurs";
            this.numeconcursDataGridViewTextBoxColumn.Name = "numeconcursDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // editieDataGridViewTextBoxColumn
            // 
            this.editieDataGridViewTextBoxColumn.DataPropertyName = "Editie";
            this.editieDataGridViewTextBoxColumn.HeaderText = "Editie";
            this.editieDataGridViewTextBoxColumn.Name = "editieDataGridViewTextBoxColumn";
            // 
            // localitateDataGridViewTextBoxColumn
            // 
            this.localitateDataGridViewTextBoxColumn.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn.Name = "localitateDataGridViewTextBoxColumn";
            // 
            // statDataGridViewTextBoxColumn
            // 
            this.statDataGridViewTextBoxColumn.DataPropertyName = "Stat";
            this.statDataGridViewTextBoxColumn.HeaderText = "Stat";
            this.statDataGridViewTextBoxColumn.Name = "statDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Format Data : YYYY-MM-DD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormConcursuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormConcursuri";
            this.Text = "Concursuri";
            this.Load += new System.EventHandler(this.FormConcursuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concursuriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CRAMADataSet cRAMADataSet;
        private System.Windows.Forms.BindingSource concursuriBindingSource;
        private CRAMADataSetTableAdapters.ConcursuriTableAdapter concursuriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDConcursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeconcursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}