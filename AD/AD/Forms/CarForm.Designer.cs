namespace AD.Forms
{
    partial class CarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarColour = new System.Windows.Forms.TextBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.txtCarMileage = new System.Windows.Forms.TextBox();
            this.cmbEngineType = new System.Windows.Forms.ComboBox();
            this.cmbTransmissionType = new System.Windows.Forms.ComboBox();
            this.txtAvailableQuantity = new System.Windows.Forms.TextBox();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerCar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC CAR TRADERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Car Mileage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Car Colour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Manufacture Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Available Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Transmission Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Engine Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(659, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 43);
            this.button4.TabIndex = 13;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(175, 103);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(145, 22);
            this.txtCarID.TabIndex = 14;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(175, 151);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(145, 22);
            this.txtCarModel.TabIndex = 15;
            // 
            // txtCarColour
            // 
            this.txtCarColour.Location = new System.Drawing.Point(489, 151);
            this.txtCarColour.Name = "txtCarColour";
            this.txtCarColour.Size = new System.Drawing.Size(145, 22);
            this.txtCarColour.TabIndex = 16;
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(31, 316);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.RowHeadersWidth = 51;
            this.dataGridViewCars.RowTemplate.Height = 24;
            this.dataGridViewCars.Size = new System.Drawing.Size(963, 216);
            this.dataGridViewCars.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(833, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 43);
            this.button5.TabIndex = 18;
            this.button5.Text = "DISPLAY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtCarMileage
            // 
            this.txtCarMileage.Location = new System.Drawing.Point(489, 204);
            this.txtCarMileage.Name = "txtCarMileage";
            this.txtCarMileage.Size = new System.Drawing.Size(145, 22);
            this.txtCarMileage.TabIndex = 19;
            // 
            // cmbEngineType
            // 
            this.cmbEngineType.FormattingEnabled = true;
            this.cmbEngineType.Items.AddRange(new object[] {
            "Hybrid",
            "Electric",
            "V8",
            "V6"});
            this.cmbEngineType.Location = new System.Drawing.Point(833, 95);
            this.cmbEngineType.Name = "cmbEngineType";
            this.cmbEngineType.Size = new System.Drawing.Size(121, 24);
            this.cmbEngineType.TabIndex = 20;
            this.cmbEngineType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbTransmissionType
            // 
            this.cmbTransmissionType.FormattingEnabled = true;
            this.cmbTransmissionType.Items.AddRange(new object[] {
            "Manual",
            "Automatic",
            "Dual-Clutch",
            "Tiptronic"});
            this.cmbTransmissionType.Location = new System.Drawing.Point(833, 148);
            this.cmbTransmissionType.Name = "cmbTransmissionType";
            this.cmbTransmissionType.Size = new System.Drawing.Size(121, 24);
            this.cmbTransmissionType.TabIndex = 21;
            // 
            // txtAvailableQuantity
            // 
            this.txtAvailableQuantity.Location = new System.Drawing.Point(833, 198);
            this.txtAvailableQuantity.Name = "txtAvailableQuantity";
            this.txtAvailableQuantity.Size = new System.Drawing.Size(145, 22);
            this.txtAvailableQuantity.TabIndex = 22;
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(175, 204);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(145, 22);
            this.txtCarPrice.TabIndex = 23;
            // 
            // dateTimePickerCar
            // 
            this.dateTimePickerCar.Location = new System.Drawing.Point(489, 103);
            this.dateTimePickerCar.Name = "dateTimePickerCar";
            this.dateTimePickerCar.Size = new System.Drawing.Size(158, 22);
            this.dateTimePickerCar.TabIndex = 24;
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 581);
            this.Controls.Add(this.dateTimePickerCar);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.txtAvailableQuantity);
            this.Controls.Add(this.cmbTransmissionType);
            this.Controls.Add(this.cmbEngineType);
            this.Controls.Add(this.txtCarMileage);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.txtCarColour);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarForm";
            this.Text = "CarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarColour;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtCarMileage;
        private System.Windows.Forms.ComboBox cmbEngineType;
        private System.Windows.Forms.ComboBox cmbTransmissionType;
        private System.Windows.Forms.TextBox txtAvailableQuantity;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerCar;
    }
}