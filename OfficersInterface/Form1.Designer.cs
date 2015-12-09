namespace OfficersInterface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sdolgnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dolgnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odolgnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oficersDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oficersDataSet = new OfficersInterface.OficersDataSet();
            this.oficersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersTableAdapter = new OfficersInterface.OficersDataSetTableAdapters.OfficersTableAdapter();
            this.s_dolgnTableAdapter = new OfficersInterface.OficersDataSetTableAdapters.S_dolgnTableAdapter();
            this.oficersDataSet1 = new OfficersInterface.OficersDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdolgnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dolgnDataGridViewTextBoxColumn,
            this.odolgnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sdolgnBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // officersBindingSource
            // 
            this.officersBindingSource.DataMember = "Officers";
            this.officersBindingSource.DataSource = this.oficersDataSetBindingSource;
            // 
            // sdolgnBindingSource
            // 
            this.sdolgnBindingSource.DataMember = "S_dolgn";
            this.sdolgnBindingSource.DataSource = this.oficersDataSetBindingSource1;
            // 
            // dolgnDataGridViewTextBoxColumn
            // 
            this.dolgnDataGridViewTextBoxColumn.DataPropertyName = "Dolgn";
            this.dolgnDataGridViewTextBoxColumn.HeaderText = "Dolgn";
            this.dolgnDataGridViewTextBoxColumn.Name = "dolgnDataGridViewTextBoxColumn";
            // 
            // odolgnDataGridViewTextBoxColumn
            // 
            this.odolgnDataGridViewTextBoxColumn.DataPropertyName = "O_dolgn";
            this.odolgnDataGridViewTextBoxColumn.HeaderText = "O_dolgn";
            this.odolgnDataGridViewTextBoxColumn.Name = "odolgnDataGridViewTextBoxColumn";
            // 
            // oficersDataSetBindingSource1
            // 
            this.oficersDataSetBindingSource1.DataSource = this.oficersDataSet;
            this.oficersDataSetBindingSource1.Position = 0;
            // 
            // oficersDataSet
            // 
            this.oficersDataSet.DataSetName = "OficersDataSet";
            this.oficersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oficersDataSetBindingSource
            // 
            this.oficersDataSetBindingSource.DataSource = this.oficersDataSet;
            this.oficersDataSetBindingSource.Position = 0;
            // 
            // officersTableAdapter
            // 
            this.officersTableAdapter.ClearBeforeFill = true;
            // 
            // s_dolgnTableAdapter
            // 
            this.s_dolgnTableAdapter.ClearBeforeFill = true;
            // 
            // oficersDataSet1
            // 
            this.oficersDataSet1.DataSetName = "OficersDataSet";
            this.oficersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 328);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdolgnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oficersDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oficersDataSetBindingSource;
        private OficersDataSet oficersDataSet;
        private System.Windows.Forms.BindingSource officersBindingSource;
        private OficersDataSetTableAdapters.OfficersTableAdapter officersTableAdapter;
        private System.Windows.Forms.BindingSource oficersDataSetBindingSource1;
        private System.Windows.Forms.BindingSource sdolgnBindingSource;
        private OficersDataSetTableAdapters.S_dolgnTableAdapter s_dolgnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolgnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odolgnDataGridViewTextBoxColumn;
        private OficersDataSet oficersDataSet1;
    }
}

