namespace Test1
{
    partial class FormParcele
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
            this.parceleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parceleTableAdapter = new Test1.CRAMADataSetTableAdapters.ParceleTableAdapter();
            this.iDParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suprafataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipdesolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddebareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parceleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDParcelaDataGridViewTextBoxColumn,
            this.suprafataDataGridViewTextBoxColumn,
            this.tipdesolDataGridViewTextBoxColumn,
            this.coddebareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parceleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(526, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceleBindingSource, "Cod_de_bare", true));
            this.textBox4.Location = new System.Drawing.Point(377, 63);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceleBindingSource, "Tip_de_sol", true));
            this.textBox3.Location = new System.Drawing.Point(271, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceleBindingSource, "Suprafata", true));
            this.textBox2.Location = new System.Drawing.Point(165, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceleBindingSource, "ID_Parcela", true));
            this.textBox1.Location = new System.Drawing.Point(59, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parceleBindingSource
            // 
            this.parceleBindingSource.DataMember = "Parcele";
            this.parceleBindingSource.DataSource = this.cRAMADataSet;
            // 
            // parceleTableAdapter
            // 
            this.parceleTableAdapter.ClearBeforeFill = true;
            // 
            // iDParcelaDataGridViewTextBoxColumn
            // 
            this.iDParcelaDataGridViewTextBoxColumn.DataPropertyName = "ID_Parcela";
            this.iDParcelaDataGridViewTextBoxColumn.HeaderText = "ID_Parcela";
            this.iDParcelaDataGridViewTextBoxColumn.Name = "iDParcelaDataGridViewTextBoxColumn";
            // 
            // suprafataDataGridViewTextBoxColumn
            // 
            this.suprafataDataGridViewTextBoxColumn.DataPropertyName = "Suprafata";
            this.suprafataDataGridViewTextBoxColumn.HeaderText = "Suprafata";
            this.suprafataDataGridViewTextBoxColumn.Name = "suprafataDataGridViewTextBoxColumn";
            // 
            // tipdesolDataGridViewTextBoxColumn
            // 
            this.tipdesolDataGridViewTextBoxColumn.DataPropertyName = "Tip_de_sol";
            this.tipdesolDataGridViewTextBoxColumn.HeaderText = "Tip_de_sol";
            this.tipdesolDataGridViewTextBoxColumn.Name = "tipdesolDataGridViewTextBoxColumn";
            // 
            // coddebareDataGridViewTextBoxColumn
            // 
            this.coddebareDataGridViewTextBoxColumn.DataPropertyName = "Cod_de_bare";
            this.coddebareDataGridViewTextBoxColumn.HeaderText = "Cod_de_bare";
            this.coddebareDataGridViewTextBoxColumn.Name = "coddebareDataGridViewTextBoxColumn";
            // 
            // FormParcele
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
            this.Name = "FormParcele";
            this.Text = "Parcele";
            this.Load += new System.EventHandler(this.FormParcele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parceleBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource parceleBindingSource;
        private CRAMADataSetTableAdapters.ParceleTableAdapter parceleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suprafataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipdesolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddebareDataGridViewTextBoxColumn;
    }
}