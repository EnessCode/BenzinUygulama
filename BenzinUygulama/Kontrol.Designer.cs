namespace BenzinUygulama
{
    partial class Kontrol
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dbBenzinDataSet = new BenzinUygulama.DbBenzinDataSet();
            this.tBLHAREKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLHAREKETTableAdapter = new BenzinUygulama.DbBenzinDataSetTableAdapters.TBLHAREKETTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENZINTURUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lITREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbBenzinDataSet1 = new BenzinUygulama.DbBenzinDataSet1();
            this.tBLHAREKET2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLHAREKET2TableAdapter = new BenzinUygulama.DbBenzinDataSet1TableAdapters.TBLHAREKET2TableAdapter();
            this.ıDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bENZINTURUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lITREDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIYATDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBenzinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHAREKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBenzinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHAREKET2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.pLAKADataGridViewTextBoxColumn,
            this.bENZINTURUDataGridViewTextBoxColumn,
            this.lITREDataGridViewTextBoxColumn,
            this.fIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLHAREKETBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(817, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn1,
            this.bENZINTURUDataGridViewTextBoxColumn1,
            this.lITREDataGridViewTextBoxColumn1,
            this.fIYATDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tBLHAREKET2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(817, 271);
            this.dataGridView2.TabIndex = 1;
            // 
            // dbBenzinDataSet
            // 
            this.dbBenzinDataSet.DataSetName = "DbBenzinDataSet";
            this.dbBenzinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLHAREKETBindingSource
            // 
            this.tBLHAREKETBindingSource.DataMember = "TBLHAREKET";
            this.tBLHAREKETBindingSource.DataSource = this.dbBenzinDataSet;
            // 
            // tBLHAREKETTableAdapter
            // 
            this.tBLHAREKETTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLAKADataGridViewTextBoxColumn
            // 
            this.pLAKADataGridViewTextBoxColumn.DataPropertyName = "PLAKA";
            this.pLAKADataGridViewTextBoxColumn.HeaderText = "PLAKA";
            this.pLAKADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pLAKADataGridViewTextBoxColumn.Name = "pLAKADataGridViewTextBoxColumn";
            // 
            // bENZINTURUDataGridViewTextBoxColumn
            // 
            this.bENZINTURUDataGridViewTextBoxColumn.DataPropertyName = "BENZINTURU";
            this.bENZINTURUDataGridViewTextBoxColumn.HeaderText = "BENZINTURU";
            this.bENZINTURUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bENZINTURUDataGridViewTextBoxColumn.Name = "bENZINTURUDataGridViewTextBoxColumn";
            // 
            // lITREDataGridViewTextBoxColumn
            // 
            this.lITREDataGridViewTextBoxColumn.DataPropertyName = "LITRE";
            this.lITREDataGridViewTextBoxColumn.HeaderText = "LITRE";
            this.lITREDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lITREDataGridViewTextBoxColumn.Name = "lITREDataGridViewTextBoxColumn";
            // 
            // fIYATDataGridViewTextBoxColumn
            // 
            this.fIYATDataGridViewTextBoxColumn.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIYATDataGridViewTextBoxColumn.Name = "fIYATDataGridViewTextBoxColumn";
            // 
            // dbBenzinDataSet1
            // 
            this.dbBenzinDataSet1.DataSetName = "DbBenzinDataSet1";
            this.dbBenzinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLHAREKET2BindingSource
            // 
            this.tBLHAREKET2BindingSource.DataMember = "TBLHAREKET2";
            this.tBLHAREKET2BindingSource.DataSource = this.dbBenzinDataSet1;
            // 
            // tBLHAREKET2TableAdapter
            // 
            this.tBLHAREKET2TableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn1
            // 
            this.ıDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn1.Name = "ıDDataGridViewTextBoxColumn1";
            this.ıDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bENZINTURUDataGridViewTextBoxColumn1
            // 
            this.bENZINTURUDataGridViewTextBoxColumn1.DataPropertyName = "BENZINTURU";
            this.bENZINTURUDataGridViewTextBoxColumn1.HeaderText = "BENZINTURU";
            this.bENZINTURUDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bENZINTURUDataGridViewTextBoxColumn1.Name = "bENZINTURUDataGridViewTextBoxColumn1";
            // 
            // lITREDataGridViewTextBoxColumn1
            // 
            this.lITREDataGridViewTextBoxColumn1.DataPropertyName = "LITRE";
            this.lITREDataGridViewTextBoxColumn1.HeaderText = "LITRE";
            this.lITREDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lITREDataGridViewTextBoxColumn1.Name = "lITREDataGridViewTextBoxColumn1";
            // 
            // fIYATDataGridViewTextBoxColumn1
            // 
            this.fIYATDataGridViewTextBoxColumn1.DataPropertyName = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn1.HeaderText = "FIYAT";
            this.fIYATDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fIYATDataGridViewTextBoxColumn1.Name = "fIYATDataGridViewTextBoxColumn1";
            // 
            // Kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 571);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kontrol";
            this.Text = "Kontrol";
            this.Load += new System.EventHandler(this.Kontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBenzinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHAREKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBenzinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHAREKET2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DbBenzinDataSet dbBenzinDataSet;
        private System.Windows.Forms.BindingSource tBLHAREKETBindingSource;
        private DbBenzinDataSetTableAdapters.TBLHAREKETTableAdapter tBLHAREKETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAKADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENZINTURUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lITREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn;
        private DbBenzinDataSet1 dbBenzinDataSet1;
        private System.Windows.Forms.BindingSource tBLHAREKET2BindingSource;
        private DbBenzinDataSet1TableAdapters.TBLHAREKET2TableAdapter tBLHAREKET2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bENZINTURUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lITREDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIYATDataGridViewTextBoxColumn1;
    }
}