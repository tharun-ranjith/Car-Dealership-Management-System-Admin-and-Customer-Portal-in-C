namespace AD.Forms
{
    partial class CarpartsForm
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
            this.txtCarPartPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewCarParts = new System.Windows.Forms.DataGridView();
            this.txtStockQuantity = new System.Windows.Forms.TextBox();
            this.txtCarPartName = new System.Windows.Forms.TextBox();
            this.txtCarPartID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCarPartType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarPartPrice
            // 
            this.txtCarPartPrice.Location = new System.Drawing.Point(271, 205);
            this.txtCarPartPrice.Name = "txtCarPartPrice";
            this.txtCarPartPrice.Size = new System.Drawing.Size(145, 22);
            this.txtCarPartPrice.TabIndex = 70;
            // 
            // dataGridViewCarParts
            // 
            this.dataGridViewCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarParts.Location = new System.Drawing.Point(57, 320);
            this.dataGridViewCarParts.Name = "dataGridViewCarParts";
            this.dataGridViewCarParts.RowHeadersWidth = 51;
            this.dataGridViewCarParts.RowTemplate.Height = 24;
            this.dataGridViewCarParts.Size = new System.Drawing.Size(963, 192);
            this.dataGridViewCarParts.TabIndex = 69;
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.Location = new System.Drawing.Point(585, 152);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.Size = new System.Drawing.Size(145, 22);
            this.txtStockQuantity.TabIndex = 68;
            // 
            // txtCarPartName
            // 
            this.txtCarPartName.Location = new System.Drawing.Point(271, 152);
            this.txtCarPartName.Name = "txtCarPartName";
            this.txtCarPartName.Size = new System.Drawing.Size(145, 22);
            this.txtCarPartName.TabIndex = 67;
            // 
            // txtCarPartID
            // 
            this.txtCarPartID.Location = new System.Drawing.Point(271, 104);
            this.txtCarPartID.Name = "txtCarPartID";
            this.txtCarPartID.Size = new System.Drawing.Size(145, 22);
            this.txtCarPartID.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Stock Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Car Part Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Car Part Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Car Part Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Car Part ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "ABC CAR TRADERS";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(872, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 43);
            this.button5.TabIndex = 76;
            this.button5.Text = "DISPLAY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(698, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 43);
            this.button4.TabIndex = 75;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 43);
            this.button3.TabIndex = 74;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 73;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 72;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCarPartType
            // 
            this.cmbCarPartType.FormattingEnabled = true;
            this.cmbCarPartType.Items.AddRange(new object[] {
            "Engine Component",
            "Transmission",
            "Chassis",
            "Body"});
            this.cmbCarPartType.Location = new System.Drawing.Point(585, 101);
            this.cmbCarPartType.Name = "cmbCarPartType";
            this.cmbCarPartType.Size = new System.Drawing.Size(121, 24);
            this.cmbCarPartType.TabIndex = 78;
            // 
            // CarpartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 536);
            this.Controls.Add(this.cmbCarPartType);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCarPartPrice);
            this.Controls.Add(this.dataGridViewCarParts);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtCarPartName);
            this.Controls.Add(this.txtCarPartID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarpartsForm";
            this.Text = "CarpartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCarPartPrice;
        private System.Windows.Forms.DataGridView dataGridViewCarParts;
        private System.Windows.Forms.TextBox txtStockQuantity;
        private System.Windows.Forms.TextBox txtCarPartName;
        private System.Windows.Forms.TextBox txtCarPartID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCarPartType;
    }
}