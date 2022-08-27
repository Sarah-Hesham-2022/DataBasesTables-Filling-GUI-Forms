namespace CustomerForm
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
            this.carTradingDataSet = new CustomerForm.CarTradingDataSet();
            this.carTradingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new CustomerForm.CarTradingDataSetTableAdapters.CUSTOMERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.cUSTOMERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSTOMERNAMEDataGridViewTextBoxColumn,
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn,
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn,
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.carTradingDataSetBindingSource;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(624, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cUSTOMERNAMEDataGridViewTextBoxColumn
            // 
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_NAME";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.Name = "cUSTOMERNAMEDataGridViewTextBoxColumn";
            this.cUSTOMERNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cUSTOMERMOBILEDataGridViewTextBoxColumn
            // 
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_MOBILE";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn.HeaderText = "CustomerMobile";
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn.Name = "cUSTOMERMOBILEDataGridViewTextBoxColumn";
            this.cUSTOMERMOBILEDataGridViewTextBoxColumn.Width = 150;
            // 
            // cUSTOMERTELEPHONEDataGridViewTextBoxColumn
            // 
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_TELEPHONE";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn.HeaderText = "CustomerTelephone";
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn.Name = "cUSTOMERTELEPHONEDataGridViewTextBoxColumn";
            this.cUSTOMERTELEPHONEDataGridViewTextBoxColumn.Width = 170;
            // 
            // cUSTOMERADDRESSDataGridViewTextBoxColumn
            // 
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ADDRESS";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Name = "cUSTOMERADDRESSDataGridViewTextBoxColumn";
            this.cUSTOMERADDRESSDataGridViewTextBoxColumn.Width = 155;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTradingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource carTradingDataSetBindingSource;
        private CarTradingDataSet carTradingDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private CarTradingDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERMOBILEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERTELEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSTOMERADDRESSDataGridViewTextBoxColumn;
    }
}