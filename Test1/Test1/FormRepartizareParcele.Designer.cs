namespace Test1
{
    partial class FormRepartizareParcele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cRAMADataSet = new Test1.CRAMADataSet();
            this.repartizareParceleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repartizare_ParceleTableAdapter = new Test1.CRAMADataSetTableAdapters.Repartizare_ParceleTableAdapter();
            this.iDParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainceputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repartizareParceleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Format Data : YYYY-MM-DD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDParcelaDataGridViewTextBoxColumn,
            this.cNPAngajatDataGridViewTextBoxColumn,
            this.functieDataGridViewTextBoxColumn,
            this.datainceputDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.repartizareParceleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartizareParceleBindingSource, "Data_inceput", true));
            this.textBox4.Location = new System.Drawing.Point(364, 58);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartizareParceleBindingSource, "Functie", true));
            this.textBox3.Location = new System.Drawing.Point(258, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartizareParceleBindingSource, "CNP_Angajat", true));
            this.textBox2.Location = new System.Drawing.Point(152, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repartizareParceleBindingSource, "ID_Parcela", true));
            this.textBox1.Location = new System.Drawing.Point(46, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repartizareParceleBindingSource
            // 
            this.repartizareParceleBindingSource.DataMember = "Repartizare_Parcele";
            this.repartizareParceleBindingSource.DataSource = this.cRAMADataSet;
            // 
            // repartizare_ParceleTableAdapter
            // 
            this.repartizare_ParceleTableAdapter.ClearBeforeFill = true;
            // 
            // iDParcelaDataGridViewTextBoxColumn
            // 
            this.iDParcelaDataGridViewTextBoxColumn.DataPropertyName = "ID_Parcela";
            this.iDParcelaDataGridViewTextBoxColumn.HeaderText = "ID_Parcela";
            this.iDParcelaDataGridViewTextBoxColumn.Name = "iDParcelaDataGridViewTextBoxColumn";
            // 
            // cNPAngajatDataGridViewTextBoxColumn
            // 
            this.cNPAngajatDataGridViewTextBoxColumn.DataPropertyName = "CNP_Angajat";
            this.cNPAngajatDataGridViewTextBoxColumn.HeaderText = "CNP_Angajat";
            this.cNPAngajatDataGridViewTextBoxColumn.Name = "cNPAngajatDataGridViewTextBoxColumn";
            // 
            // functieDataGridViewTextBoxColumn
            // 
            this.functieDataGridViewTextBoxColumn.DataPropertyName = "Functie";
            this.functieDataGridViewTextBoxColumn.HeaderText = "Functie";
            this.functieDataGridViewTextBoxColumn.Name = "functieDataGridViewTextBoxColumn";
            // 
            // datainceputDataGridViewTextBoxColumn
            // 
            this.datainceputDataGridViewTextBoxColumn.DataPropertyName = "Data_inceput";
            this.datainceputDataGridViewTextBoxColumn.HeaderText = "Data_inceput";
            this.datainceputDataGridViewTextBoxColumn.Name = "datainceputDataGridViewTextBoxColumn";
            // 
            // FormRepartizareParcele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRepartizareParcele";
            this.Text = "RepartizareParcele";
            this.Load += new System.EventHandler(this.FormRepartizareParcele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repartizareParceleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CRAMADataSet cRAMADataSet;
        private System.Windows.Forms.BindingSource repartizareParceleBindingSource;
        private CRAMADataSetTableAdapters.Repartizare_ParceleTableAdapter repartizare_ParceleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainceputDataGridViewTextBoxColumn;
    }
}