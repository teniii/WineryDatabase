namespace Test1
{
    partial class FormUtilaje
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cRAMADataSet = new Test1.CRAMADataSet();
            this.utilajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilajeTableAdapter = new Test1.CRAMADataSetTableAdapters.UtilajeTableAdapter();
            this.seriesasiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anfabricatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataexpiraregarantieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPAngajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilajeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 46);
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
            this.seriesasiuDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.anfabricatieDataGridViewTextBoxColumn,
            this.dataexpiraregarantieDataGridViewTextBoxColumn,
            this.functieDataGridViewTextBoxColumn,
            this.cNPAngajatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.utilajeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(782, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "Functie", true));
            this.textBox6.Location = new System.Drawing.Point(567, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "Data_expirare_garantie", true));
            this.textBox5.Location = new System.Drawing.Point(461, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "An_fabricatie", true));
            this.textBox4.Location = new System.Drawing.Point(355, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "Model", true));
            this.textBox3.Location = new System.Drawing.Point(249, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "Marca", true));
            this.textBox2.Location = new System.Drawing.Point(143, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "Serie_sasiu", true));
            this.textBox1.Location = new System.Drawing.Point(37, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilajeBindingSource
            // 
            this.utilajeBindingSource.DataMember = "Utilaje";
            this.utilajeBindingSource.DataSource = this.cRAMADataSet;
            // 
            // utilajeTableAdapter
            // 
            this.utilajeTableAdapter.ClearBeforeFill = true;
            // 
            // seriesasiuDataGridViewTextBoxColumn
            // 
            this.seriesasiuDataGridViewTextBoxColumn.DataPropertyName = "Serie_sasiu";
            this.seriesasiuDataGridViewTextBoxColumn.HeaderText = "Serie_sasiu";
            this.seriesasiuDataGridViewTextBoxColumn.Name = "seriesasiuDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // anfabricatieDataGridViewTextBoxColumn
            // 
            this.anfabricatieDataGridViewTextBoxColumn.DataPropertyName = "An_fabricatie";
            this.anfabricatieDataGridViewTextBoxColumn.HeaderText = "An_fabricatie";
            this.anfabricatieDataGridViewTextBoxColumn.Name = "anfabricatieDataGridViewTextBoxColumn";
            // 
            // dataexpiraregarantieDataGridViewTextBoxColumn
            // 
            this.dataexpiraregarantieDataGridViewTextBoxColumn.DataPropertyName = "Data_expirare_garantie";
            this.dataexpiraregarantieDataGridViewTextBoxColumn.HeaderText = "Data_expirare_garantie";
            this.dataexpiraregarantieDataGridViewTextBoxColumn.Name = "dataexpiraregarantieDataGridViewTextBoxColumn";
            // 
            // functieDataGridViewTextBoxColumn
            // 
            this.functieDataGridViewTextBoxColumn.DataPropertyName = "Functie";
            this.functieDataGridViewTextBoxColumn.HeaderText = "Functie";
            this.functieDataGridViewTextBoxColumn.Name = "functieDataGridViewTextBoxColumn";
            // 
            // cNPAngajatDataGridViewTextBoxColumn
            // 
            this.cNPAngajatDataGridViewTextBoxColumn.DataPropertyName = "CNP_Angajat";
            this.cNPAngajatDataGridViewTextBoxColumn.HeaderText = "CNP_Angajat";
            this.cNPAngajatDataGridViewTextBoxColumn.Name = "cNPAngajatDataGridViewTextBoxColumn";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilajeBindingSource, "CNP_Angajat", true));
            this.textBox7.Location = new System.Drawing.Point(673, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            // 
            // FormUtilaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.textBox7);
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
            this.Name = "FormUtilaje";
            this.Text = "Utilaje";
            this.Load += new System.EventHandler(this.FormUtilaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilajeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CRAMADataSet cRAMADataSet;
        private System.Windows.Forms.BindingSource utilajeBindingSource;
        private CRAMADataSetTableAdapters.UtilajeTableAdapter utilajeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesasiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anfabricatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataexpiraregarantieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPAngajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox7;
    }
}