namespace WorkingWithDBEmployees
{
    partial class Insert
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
            this.numInsertRate = new System.Windows.Forms.NumericUpDown();
            this.numInsertCountHours = new System.Windows.Forms.NumericUpDown();
            this.numInsertCountDays = new System.Windows.Forms.NumericUpDown();
            this.lblInsertRate = new System.Windows.Forms.Label();
            this.lblInsertCountHours = new System.Windows.Forms.Label();
            this.lblInsertCountDays = new System.Windows.Forms.Label();
            this.txtBoxInsertFName = new System.Windows.Forms.TextBox();
            this.checkBoxInsertPayment = new System.Windows.Forms.CheckBox();
            this.txtBoxInsertLName = new System.Windows.Forms.TextBox();
            this.lblLInsertLName = new System.Windows.Forms.Label();
            this.lblInsertFName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertCountHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertCountDays)).BeginInit();
            this.SuspendLayout();
            // 
            // numInsertRate
            // 
            this.numInsertRate.DecimalPlaces = 2;
            this.numInsertRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numInsertRate.Location = new System.Drawing.Point(361, 48);
            this.numInsertRate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numInsertRate.Name = "numInsertRate";
            this.numInsertRate.Size = new System.Drawing.Size(81, 26);
            this.numInsertRate.TabIndex = 73;
            // 
            // numInsertCountHours
            // 
            this.numInsertCountHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numInsertCountHours.Location = new System.Drawing.Point(161, 130);
            this.numInsertCountHours.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numInsertCountHours.Name = "numInsertCountHours";
            this.numInsertCountHours.Size = new System.Drawing.Size(90, 26);
            this.numInsertCountHours.TabIndex = 72;
            this.numInsertCountHours.Visible = false;
            // 
            // numInsertCountDays
            // 
            this.numInsertCountDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numInsertCountDays.Location = new System.Drawing.Point(161, 95);
            this.numInsertCountDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numInsertCountDays.Name = "numInsertCountDays";
            this.numInsertCountDays.Size = new System.Drawing.Size(90, 26);
            this.numInsertCountDays.TabIndex = 71;
            // 
            // lblInsertRate
            // 
            this.lblInsertRate.AutoSize = true;
            this.lblInsertRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInsertRate.ForeColor = System.Drawing.Color.Blue;
            this.lblInsertRate.Location = new System.Drawing.Point(299, 54);
            this.lblInsertRate.Name = "lblInsertRate";
            this.lblInsertRate.Size = new System.Drawing.Size(56, 19);
            this.lblInsertRate.TabIndex = 70;
            this.lblInsertRate.Text = "Ставка";
            // 
            // lblInsertCountHours
            // 
            this.lblInsertCountHours.AutoSize = true;
            this.lblInsertCountHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInsertCountHours.ForeColor = System.Drawing.Color.Blue;
            this.lblInsertCountHours.Location = new System.Drawing.Point(12, 132);
            this.lblInsertCountHours.Name = "lblInsertCountHours";
            this.lblInsertCountHours.Size = new System.Drawing.Size(130, 19);
            this.lblInsertCountHours.TabIndex = 69;
            this.lblInsertCountHours.Text = "К-во отраб. часов";
            this.lblInsertCountHours.Visible = false;
            // 
            // lblInsertCountDays
            // 
            this.lblInsertCountDays.AutoSize = true;
            this.lblInsertCountDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInsertCountDays.ForeColor = System.Drawing.Color.Blue;
            this.lblInsertCountDays.Location = new System.Drawing.Point(12, 95);
            this.lblInsertCountDays.Name = "lblInsertCountDays";
            this.lblInsertCountDays.Size = new System.Drawing.Size(125, 19);
            this.lblInsertCountDays.TabIndex = 68;
            this.lblInsertCountDays.Text = "К-во отраб. дней";
            // 
            // txtBoxInsertFName
            // 
            this.txtBoxInsertFName.Location = new System.Drawing.Point(361, 14);
            this.txtBoxInsertFName.Name = "txtBoxInsertFName";
            this.txtBoxInsertFName.Size = new System.Drawing.Size(201, 20);
            this.txtBoxInsertFName.TabIndex = 67;
            // 
            // checkBoxInsertPayment
            // 
            this.checkBoxInsertPayment.AutoSize = true;
            this.checkBoxInsertPayment.Checked = true;
            this.checkBoxInsertPayment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInsertPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxInsertPayment.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxInsertPayment.Location = new System.Drawing.Point(12, 54);
            this.checkBoxInsertPayment.Name = "checkBoxInsertPayment";
            this.checkBoxInsertPayment.Size = new System.Drawing.Size(118, 23);
            this.checkBoxInsertPayment.TabIndex = 66;
            this.checkBoxInsertPayment.Text = "Фикс. оплата";
            this.checkBoxInsertPayment.UseVisualStyleBackColor = true;
            this.checkBoxInsertPayment.CheckedChanged += new System.EventHandler(this.checkBoxInsertPayment_CheckedChanged);
            // 
            // txtBoxInsertLName
            // 
            this.txtBoxInsertLName.Location = new System.Drawing.Point(90, 16);
            this.txtBoxInsertLName.Name = "txtBoxInsertLName";
            this.txtBoxInsertLName.Size = new System.Drawing.Size(161, 20);
            this.txtBoxInsertLName.TabIndex = 65;
            // 
            // lblLInsertLName
            // 
            this.lblLInsertLName.AutoSize = true;
            this.lblLInsertLName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLInsertLName.ForeColor = System.Drawing.Color.Blue;
            this.lblLInsertLName.Location = new System.Drawing.Point(12, 15);
            this.lblLInsertLName.Name = "lblLInsertLName";
            this.lblLInsertLName.Size = new System.Drawing.Size(72, 19);
            this.lblLInsertLName.TabIndex = 64;
            this.lblLInsertLName.Text = "Фамилия";
            // 
            // lblInsertFName
            // 
            this.lblInsertFName.AutoSize = true;
            this.lblInsertFName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInsertFName.ForeColor = System.Drawing.Color.Blue;
            this.lblInsertFName.Location = new System.Drawing.Point(299, 15);
            this.lblInsertFName.Name = "lblInsertFName";
            this.lblInsertFName.Size = new System.Drawing.Size(37, 19);
            this.lblInsertFName.TabIndex = 63;
            this.lblInsertFName.Text = "Имя";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(303, 130);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(122, 26);
            this.btnInsert.TabIndex = 74;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(439, 130);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(122, 26);
            this.btnUpdateCancel.TabIndex = 75;
            this.btnUpdateCancel.Text = "Отмена";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnInsertCancel_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 175);
            this.Controls.Add(this.btnUpdateCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.numInsertRate);
            this.Controls.Add(this.numInsertCountHours);
            this.Controls.Add(this.numInsertCountDays);
            this.Controls.Add(this.lblInsertRate);
            this.Controls.Add(this.lblInsertCountHours);
            this.Controls.Add(this.lblInsertCountDays);
            this.Controls.Add(this.txtBoxInsertFName);
            this.Controls.Add(this.checkBoxInsertPayment);
            this.Controls.Add(this.txtBoxInsertLName);
            this.Controls.Add(this.lblLInsertLName);
            this.Controls.Add(this.lblInsertFName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Insert";
            this.Text = "Добавить";
            ((System.ComponentModel.ISupportInitialize)(this.numInsertRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertCountHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInsertCountDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numInsertRate;
        private System.Windows.Forms.NumericUpDown numInsertCountHours;
        private System.Windows.Forms.NumericUpDown numInsertCountDays;
        private System.Windows.Forms.Label lblInsertRate;
        private System.Windows.Forms.Label lblInsertCountHours;
        private System.Windows.Forms.Label lblInsertCountDays;
        private System.Windows.Forms.TextBox txtBoxInsertFName;
        private System.Windows.Forms.CheckBox checkBoxInsertPayment;
        private System.Windows.Forms.TextBox txtBoxInsertLName;
        private System.Windows.Forms.Label lblLInsertLName;
        private System.Windows.Forms.Label lblInsertFName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdateCancel;
    }
}