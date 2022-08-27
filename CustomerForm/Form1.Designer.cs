namespace CustomerForm
{
    partial class Form1
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonGrid = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Thistle;
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.Location = new System.Drawing.Point(587, 376);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(166, 50);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select Names";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGrid
            // 
            this.buttonGrid.BackColor = System.Drawing.Color.Thistle;
            this.buttonGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrid.Location = new System.Drawing.Point(347, 376);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(209, 50);
            this.buttonGrid.TabIndex = 1;
            this.buttonGrid.Text = "Select all data grid";
            this.buttonGrid.UseVisualStyleBackColor = false;
            this.buttonGrid.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(72, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(194, 29);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "CustomerName";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(74, 93);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(205, 29);
            this.labelMobile.TabIndex = 3;
            this.labelMobile.Text = "CustomerMobile";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephone.Location = new System.Drawing.Point(72, 140);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(252, 29);
            this.labelTelephone.TabIndex = 4;
            this.labelTelephone.Text = "CustomerTelephone";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(72, 188);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(221, 29);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "CustomerAddress";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(335, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(335, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(335, 195);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(406, 151);
            this.textBox4.TabIndex = 9;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Thistle;
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(12, 376);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(95, 50);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Thistle;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(113, 376);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(110, 50);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Thistle;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(229, 376);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 50);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.buttonSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonGrid;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

