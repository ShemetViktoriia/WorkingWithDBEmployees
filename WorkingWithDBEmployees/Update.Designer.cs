namespace WorkingWithDBEmployees
{
    partial class Update
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
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numUpdateRate = new System.Windows.Forms.NumericUpDown();
            this.numUpdateCountHours = new System.Windows.Forms.NumericUpDown();
            this.numUpdateCountDays = new System.Windows.Forms.NumericUpDown();
            this.lblUpdateRate = new System.Windows.Forms.Label();
            this.lblUpdateCountHours = new System.Windows.Forms.Label();
            this.lblUpdateCountDays = new System.Windows.Forms.Label();
            this.txtBoxUpdateFName = new System.Windows.Forms.TextBox();
            this.checkBoxUpdatePayment = new System.Windows.Forms.CheckBox();
            this.txtBoxUpdateLName = new System.Windows.Forms.TextBox();
            this.lblUpdateLName = new System.Windows.Forms.Label();
            this.lblUpdateFName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCountHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCountDays)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(439, 128);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(122, 26);
            this.btnUpdateCancel.TabIndex = 88;
            this.btnUpdateCancel.Text = "Отмена";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(303, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 26);
            this.btnUpdate.TabIndex = 87;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numUpdateRate
            // 
            this.numUpdateRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdateRate.Location = new System.Drawing.Point(361, 46);
            this.numUpdateRate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpdateRate.Name = "numUpdateRate";
            this.numUpdateRate.Size = new System.Drawing.Size(81, 26);
            this.numUpdateRate.TabIndex = 86;
            this.numUpdateRate.ThousandsSeparator = true;
            // 
            // numUpdateCountHours
            // 
            this.numUpdateCountHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdateCountHours.Location = new System.Drawing.Point(161, 128);
            this.numUpdateCountHours.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpdateCountHours.Name = "numUpdateCountHours";
            this.numUpdateCountHours.Size = new System.Drawing.Size(90, 26);
            this.numUpdateCountHours.TabIndex = 85;
            this.numUpdateCountHours.Visible = false;
            // 
            // numUpdateCountDays
            // 
            this.numUpdateCountDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdateCountDays.Location = new System.Drawing.Point(161, 93);
            this.numUpdateCountDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numUpdateCountDays.Name = "numUpdateCountDays";
            this.numUpdateCountDays.Size = new System.Drawing.Size(90, 26);
            this.numUpdateCountDays.TabIndex = 84;
            // 
            // lblUpdateRate
            // 
            this.lblUpdateRate.AutoSize = true;
            this.lblUpdateRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateRate.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdateRate.Location = new System.Drawing.Point(299, 52);
            this.lblUpdateRate.Name = "lblUpdateRate";
            this.lblUpdateRate.Size = new System.Drawing.Size(56, 19);
            this.lblUpdateRate.TabIndex = 83;
            this.lblUpdateRate.Text = "Ставка";
            // 
            // lblUpdateCountHours
            // 
            this.lblUpdateCountHours.AutoSize = true;
            this.lblUpdateCountHours.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateCountHours.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdateCountHours.Location = new System.Drawing.Point(12, 130);
            this.lblUpdateCountHours.Name = "lblUpdateCountHours";
            this.lblUpdateCountHours.Size = new System.Drawing.Size(130, 19);
            this.lblUpdateCountHours.TabIndex = 82;
            this.lblUpdateCountHours.Text = "К-во отраб. часов";
            this.lblUpdateCountHours.Visible = false;
            // 
            // lblUpdateCountDays
            // 
            this.lblUpdateCountDays.AutoSize = true;
            this.lblUpdateCountDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateCountDays.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdateCountDays.Location = new System.Drawing.Point(12, 93);
            this.lblUpdateCountDays.Name = "lblUpdateCountDays";
            this.lblUpdateCountDays.Size = new System.Drawing.Size(125, 19);
            this.lblUpdateCountDays.TabIndex = 81;
            this.lblUpdateCountDays.Text = "К-во отраб. дней";
            // 
            // txtBoxUpdateFName
            // 
            this.txtBoxUpdateFName.Location = new System.Drawing.Point(361, 12);
            this.txtBoxUpdateFName.Name = "txtBoxUpdateFName";
            this.txtBoxUpdateFName.Size = new System.Drawing.Size(201, 20);
            this.txtBoxUpdateFName.TabIndex = 80;
            // 
            // checkBoxUpdatePayment
            // 
            this.checkBoxUpdatePayment.AutoSize = true;
            this.checkBoxUpdatePayment.Checked = true;
            this.checkBoxUpdatePayment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpdatePayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxUpdatePayment.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxUpdatePayment.Location = new System.Drawing.Point(16, 48);
            this.checkBoxUpdatePayment.Name = "checkBoxUpdatePayment";
            this.checkBoxUpdatePayment.Size = new System.Drawing.Size(118, 23);
            this.checkBoxUpdatePayment.TabIndex = 79;
            this.checkBoxUpdatePayment.Text = "Фикс. оплата";
            this.checkBoxUpdatePayment.UseVisualStyleBackColor = true;
            this.checkBoxUpdatePayment.CheckedChanged += new System.EventHandler(this.checkBoxUpdatePayment_CheckedChanged);
            // 
            // txtBoxUpdateLName
            // 
            this.txtBoxUpdateLName.Location = new System.Drawing.Point(90, 14);
            this.txtBoxUpdateLName.Name = "txtBoxUpdateLName";
            this.txtBoxUpdateLName.Size = new System.Drawing.Size(161, 20);
            this.txtBoxUpdateLName.TabIndex = 78;
            // 
            // lblUpdateLName
            // 
            this.lblUpdateLName.AutoSize = true;
            this.lblUpdateLName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateLName.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdateLName.Location = new System.Drawing.Point(12, 13);
            this.lblUpdateLName.Name = "lblUpdateLName";
            this.lblUpdateLName.Size = new System.Drawing.Size(72, 19);
            this.lblUpdateLName.TabIndex = 77;
            this.lblUpdateLName.Text = "Фамилия";
            // 
            // lblUpdateFName
            // 
            this.lblUpdateFName.AutoSize = true;
            this.lblUpdateFName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateFName.ForeColor = System.Drawing.Color.Blue;
            this.lblUpdateFName.Location = new System.Drawing.Point(299, 13);
            this.lblUpdateFName.Name = "lblUpdateFName";
            this.lblUpdateFName.Size = new System.Drawing.Size(37, 19);
            this.lblUpdateFName.TabIndex = 76;
            this.lblUpdateFName.Text = "Имя";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 163);
            this.Controls.Add(this.btnUpdateCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numUpdateRate);
            this.Controls.Add(this.numUpdateCountHours);
            this.Controls.Add(this.numUpdateCountDays);
            this.Controls.Add(this.lblUpdateRate);
            this.Controls.Add(this.lblUpdateCountHours);
            this.Controls.Add(this.lblUpdateCountDays);
            this.Controls.Add(this.txtBoxUpdateFName);
            this.Controls.Add(this.checkBoxUpdatePayment);
            this.Controls.Add(this.txtBoxUpdateLName);
            this.Controls.Add(this.lblUpdateLName);
            this.Controls.Add(this.lblUpdateFName);
            this.Name = "Update";
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCountHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCountDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numUpdateRate;
        private System.Windows.Forms.NumericUpDown numUpdateCountHours;
        private System.Windows.Forms.NumericUpDown numUpdateCountDays;
        private System.Windows.Forms.Label lblUpdateRate;
        private System.Windows.Forms.Label lblUpdateCountHours;
        private System.Windows.Forms.Label lblUpdateCountDays;
        private System.Windows.Forms.TextBox txtBoxUpdateFName;
        private System.Windows.Forms.CheckBox checkBoxUpdatePayment;
        private System.Windows.Forms.TextBox txtBoxUpdateLName;
        private System.Windows.Forms.Label lblUpdateLName;
        private System.Windows.Forms.Label lblUpdateFName;
    }
}