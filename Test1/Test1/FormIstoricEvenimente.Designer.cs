namespace Test1
{
    partial class FormIstoricEvenimente
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cRAMADataSet = new Test1.CRAMADataSet();
            this.istoricEvenimenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istoric_EvenimenteTableAdapter = new Test1.CRAMADataSetTableAdapters.Istoric_EvenimenteTableAdapter();
            this.iDEvenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notafeedbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricEvenimenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEvenimentDataGridViewTextBoxColumn,
            this.cNPClientDataGridViewTextBoxColumn,
            this.notafeedbackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.istoricEvenimenteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istoricEvenimenteBindingSource, "Nota_feedback", true));
            this.textBox3.Location = new System.Drawing.Point(261, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istoricEvenimenteBindingSource, "CNP_Client", true));
            this.textBox2.Location = new System.Drawing.Point(155, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istoricEvenimenteBindingSource, "ID_Eveniment", true));
            this.textBox1.Location = new System.Drawing.Point(49, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // cRAMADataSet
            // 
            this.cRAMADataSet.DataSetName = "CRAMADataSet";
            this.cRAMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istoricEvenimenteBindingSource
            // 
            this.istoricEvenimenteBindingSource.DataMember = "Istoric_Evenimente";
            this.istoricEvenimenteBindingSource.DataSource = this.cRAMADataSet;
            // 
            // istoric_EvenimenteTableAdapter
            // 
            this.istoric_EvenimenteTableAdapter.ClearBeforeFill = true;
            // 
            // iDEvenimentDataGridViewTextBoxColumn
            // 
            this.iDEvenimentDataGridViewTextBoxColumn.DataPropertyName = "ID_Eveniment";
            this.iDEvenimentDataGridViewTextBoxColumn.HeaderText = "ID_Eveniment";
            this.iDEvenimentDataGridViewTextBoxColumn.Name = "iDEvenimentDataGridViewTextBoxColumn";
            // 
            // cNPClientDataGridViewTextBoxColumn
            // 
            this.cNPClientDataGridViewTextBoxColumn.DataPropertyName = "CNP_Client";
            this.cNPClientDataGridViewTextBoxColumn.HeaderText = "CNP_Client";
            this.cNPClientDataGridViewTextBoxColumn.Name = "cNPClientDataGridViewTextBoxColumn";
            // 
            // notafeedbackDataGridViewTextBoxColumn
            // 
            this.notafeedbackDataGridViewTextBoxColumn.DataPropertyName = "Nota_feedback";
            this.notafeedbackDataGridViewTextBoxColumn.HeaderText = "Nota_feedback";
            this.notafeedbackDataGridViewTextBoxColumn.Name = "notafeedbackDataGridViewTextBoxColumn";
            // 
            // FormIstoricEvenimente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormIstoricEvenimente";
            this.Text = "IstoricEvenimente";
            this.Load += new System.EventHandler(this.FormIstoricEvenimente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRAMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istoricEvenimenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CRAMADataSet cRAMADataSet;
        private System.Windows.Forms.BindingSource istoricEvenimenteBindingSource;
        private CRAMADataSetTableAdapters.Istoric_EvenimenteTableAdapter istoric_EvenimenteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEvenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notafeedbackDataGridViewTextBoxColumn;
    }
}