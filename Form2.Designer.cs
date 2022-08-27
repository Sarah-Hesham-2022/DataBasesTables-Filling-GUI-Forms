namespace ShipperForm
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sHIPPERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIPPERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIPPERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIPPERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTradingDataSet = new ShipperForm.CarTradingDataSet();
            this.carTradingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHIPPERTableAdapter = new ShipperForm.CarTradingDataSetTableAdapters.SHIPPERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sHIPPERIDDataGridViewTextBoxColumn,
            this.sHIPPERNAMEDataGridViewTextBoxColumn,
            this.sHIPPERADDRESSDataGridViewTextBoxColumn,
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn,
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sHIPPERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 331);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sHIPPERIDDataGridViewTextBoxColumn
            // 
            this.sHIPPERIDDataGridViewTextBoxColumn.DataPropertyName = "SHIPPER_ID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            this.sHIPPERIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sHIPPERIDDataGridViewTextBoxColumn.HeaderText = "SHIPPER_ID";
            this.sHIPPERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHIPPERIDDataGridViewTextBoxColumn.Name = "sHIPPERIDDataGridViewTextBoxColumn";
            this.sHIPPERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIPPERIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sHIPPERNAMEDataGridViewTextBoxColumn
            // 
            this.sHIPPERNAMEDataGridViewTextBoxColumn.DataPropertyName = "SHIPPER_NAME";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            this.sHIPPERNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sHIPPERNAMEDataGridViewTextBoxColumn.HeaderText = "SHIPPER_NAME";
            this.sHIPPERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHIPPERNAMEDataGridViewTextBoxColumn.Name = "sHIPPERNAMEDataGridViewTextBoxColumn";
            this.sHIPPERNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // sHIPPERADDRESSDataGridViewTextBoxColumn
            // 
            this.sHIPPERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SHIPPER_ADDRESS";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Cyan;
            this.sHIPPERADDRESSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sHIPPERADDRESSDataGridViewTextBoxColumn.HeaderText = "SHIPPER_ADDRESS";
            this.sHIPPERADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHIPPERADDRESSDataGridViewTextBoxColumn.Name = "sHIPPERADDRESSDataGridViewTextBoxColumn";
            this.sHIPPERADDRESSDataGridViewTextBoxColumn.Width = 160;
            // 
            // sHIPPERTELEPHONEDataGridViewTextBoxColumn
            // 
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "SHIPPER_TELEPHONE";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn.HeaderText = "SHIPPER_TELEPHONE";
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn.Name = "sHIPPERTELEPHONEDataGridViewTextBoxColumn";
            this.sHIPPERTELEPHONEDataGridViewTextBoxColumn.Width = 170;
            // 
            // sHIPPERCOUNTRYDataGridViewTextBoxColumn
            // 
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn.DataPropertyName = "SHIPPER_COUNTRY";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn.HeaderText = "SHIPPER_COUNTRY";
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn.Name = "sHIPPERCOUNTRYDataGridViewTextBoxColumn";
            this.sHIPPERCOUNTRYDataGridViewTextBoxColumn.Width = 150;
            // 
            // sHIPPERBindingSource
            // 
            this.sHIPPERBindingSource.DataMember = "SHIPPER";
            this.sHIPPERBindingSource.DataSource = this.carTradingDataSet;
            // 
            // carTradingDataSet
            // 
            this.carTradingDataSet.DataSetName = "CarTradingDataSet";
            this.carTradingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTradingDataSetBindingSource
            // 
            this.carTradingDataSetBindingSource.DataSource = this.carTradingDataSet;
            this.carTradingDataSetBindingSource.Position = 0;
            // 
            // sHIPPERTableAdapter
            // 
            this.sHIPPERTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(823, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHIPPERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carTradingDataSetBindingSource;
        private CarTradingDataSet carTradingDataSet;
        private System.Windows.Forms.BindingSource sHIPPERBindingSource;
        private CarTradingDataSetTableAdapters.SHIPPERTableAdapter sHIPPERTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIPPERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIPPERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIPPERADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIPPERTELEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIPPERCOUNTRYDataGridViewTextBoxColumn;
    }
}