namespace Test1
{
    partial class FormEvenimenteInterne
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cRAMADataSet = new Test1.CRAMADataSet();
            this.evenimenteinterneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evenimente_interneTableAdapter = new Test1.CRAMADataSetTableAdapters.Evenimente_interneTableAdapter();
            this.iDEvenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimenteinterneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 34);
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
            this.iDEvenimentDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.scopDataGridViewTextBoxColumn,
            this.durataDataGridViewTextBoxColumn,
            this.cNPAngajatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evenimenteinterneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evenimenteinterneBindingSource, "CNP_Angajat", true));
            this.textBox5.Location = new System.Drawing.Point(465, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evenimenteinterneBindingSource, "Durata", true));
            this.textBox4.Location = new System.Drawing.Point(359, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evenimenteinterneBindingSource, "Scop", true));
            this.textBox3.Location = new System.Drawing.Point(253, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evenimenteinterneBindingSource, "Data", true));
            this.textBox2.Location = new System.Drawing.Point(147, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evenimenteinterneBindingSource, "ID_Eveniment", true));
            this.textBox1.Location = new System.Drawing.Point(41, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenimenteinterneBindingSource
            // 
            this.evenimenteinterneBindingSource.DataMember = "Evenimente_interne";
            this.evenimenteinterneBindingSource.DataSource = this.cRAMADataSet;
            // 
            // evenimente_interneTableAdapter
            // 
            this.evenimente_interneTableAdapter.ClearBeforeFill = true;
            // 
            // iDEvenimentDataGridViewTextBoxColumn
            // 
            this.iDEvenimentDataGridViewTextBoxColumn.DataPropertyName = "ID_Eveniment";
            this.iDEvenimentDataGridViewTextBoxColumn.HeaderText = "ID_Eveniment";
            this.iDEvenimentDataGridViewTextBoxColumn.Name = "iDEvenimentDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // scopDataGridViewTextBoxColumn
            // 
            this.scopDataGridViewTextBoxColumn.DataPropertyName = "Scop";
            this.scopDataGridViewTextBoxColumn.HeaderText = "Scop";
            this.scopDataGridViewTextBoxColumn.Name = "scopDataGridViewTextBoxColumn";
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "Durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "Durata";
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            // 
            // cNPAngajatDataGridViewTextBoxColumn
            // 
            this.cNPAngajatDataGridViewTextBoxColumn.DataPropertyName = "CNP_Angajat";
            this.cNPAngajatDataGridViewTextBoxColumn.HeaderText = "CNP_Angajat";
            this.cNPAngajatDataGridViewTextBoxColumn.Name = "cNPAngajatDataGridViewTextBoxColumn";
            // 
            // FormEvenimenteInterne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormEvenimenteInterne";
            this.Text = "EvenimenteInterne";
            this.Load += new System.EventHandler(this.FormEvenimenteInterne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenimenteinterneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CRAMADataSet cRAMADataSet;
        private System.Windows.Forms.BindingSource evenimenteinterneBindingSource;
        private CRAMADataSetTableAdapters.Evenimente_interneTableAdapter evenimente_interneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEvenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPAngajatDataGridViewTextBoxColumn;
    }
}