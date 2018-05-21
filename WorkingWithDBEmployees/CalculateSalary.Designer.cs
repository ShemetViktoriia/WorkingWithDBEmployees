namespace WorkingWithDBEmployees
{
    partial class CalculateSalary
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
            this.lblCountDays = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtBoxSalaryFName = new System.Windows.Forms.TextBox();
            this.txtBoxSalaryLName = new System.Windows.Forms.TextBox();
            this.lblSalaryLastName = new System.Windows.Forms.Label();
            this.lblSalaryFName = new System.Windows.Forms.Label();
            this.txtSumSalary = new System.Windows.Forms.TextBox();
            this.txtSalaryCountDays = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountDays
            // 
            this.lblCountDays.AutoSize = true;
            this.lblCountDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountDays.ForeColor = System.Drawing.Color.Blue;
            this.lblCountDays.Location = new System.Drawing.Point(12, 136);
            this.lblCountDays.Name = "lblCountDays";
            this.lblCountDays.Size = new System.Drawing.Size(110, 19);
            this.lblCountDays.TabIndex = 65;
            this.lblCountDays.Text = "К-во раб. дней";
            this.lblCountDays.Visible = false;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalary.ForeColor = System.Drawing.Color.Blue;
            this.lblSalary.Location = new System.Drawing.Point(12, 99);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(70, 19);
            this.lblSalary.TabIndex = 63;
            this.lblSalary.Text = "Зарплата";
            // 
            // txtBoxSalaryFName
            // 
            this.txtBoxSalaryFName.Location = new System.Drawing.Point(144, 61);
            this.txtBoxSalaryFName.Name = "txtBoxSalaryFName";
            this.txtBoxSalaryFName.Size = new System.Drawing.Size(187, 20);
            this.txtBoxSalaryFName.TabIndex = 62;
            // 
            // txtBoxSalaryLName
            // 
            this.txtBoxSalaryLName.Location = new System.Drawing.Point(144, 25);
            this.txtBoxSalaryLName.Name = "txtBoxSalaryLName";
            this.txtBoxSalaryLName.Size = new System.Drawing.Size(187, 20);
            this.txtBoxSalaryLName.TabIndex = 61;
            // 
            // lblSalaryLastName
            // 
            this.lblSalaryLastName.AutoSize = true;
            this.lblSalaryLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalaryLastName.ForeColor = System.Drawing.Color.Blue;
            this.lblSalaryLastName.Location = new System.Drawing.Point(10, 26);
            this.lblSalaryLastName.Name = "lblSalaryLastName";
            this.lblSalaryLastName.Size = new System.Drawing.Size(72, 19);
            this.lblSalaryLastName.TabIndex = 60;
            this.lblSalaryLastName.Text = "Фамилия";
            // 
            // lblSalaryFName
            // 
            this.lblSalaryFName.AutoSize = true;
            this.lblSalaryFName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSalaryFName.ForeColor = System.Drawing.Color.Blue;
            this.lblSalaryFName.Location = new System.Drawing.Point(12, 62);
            this.lblSalaryFName.Name = "lblSalaryFName";
            this.lblSalaryFName.Size = new System.Drawing.Size(37, 19);
            this.lblSalaryFName.TabIndex = 59;
            this.lblSalaryFName.Text = "Имя";
            // 
            // txtSumSalary
            // 
            this.txtSumSalary.Location = new System.Drawing.Point(144, 98);
            this.txtSumSalary.Name = "txtSumSalary";
            this.txtSumSalary.Size = new System.Drawing.Size(187, 20);
            this.txtSumSalary.TabIndex = 70;
            // 
            // txtSalaryCountDays
            // 
            this.txtSalaryCountDays.Location = new System.Drawing.Point(144, 135);
            this.txtSalaryCountDays.Name = "txtSalaryCountDays";
            this.txtSalaryCountDays.Size = new System.Drawing.Size(187, 20);
            this.txtSalaryCountDays.TabIndex = 71;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 23);
            this.btnExit.TabIndex = 72;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CalculateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 202);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSalaryCountDays);
            this.Controls.Add(this.txtSumSalary);
            this.Controls.Add(this.lblCountDays);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtBoxSalaryFName);
            this.Controls.Add(this.txtBoxSalaryLName);
            this.Controls.Add(this.lblSalaryLastName);
            this.Controls.Add(this.lblSalaryFName);
            this.Name = "CalculateSalary";
            this.Text = "Расчет ЗП";
            this.Load += new System.EventHandler(this.CalculateSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCountDays;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtBoxSalaryFName;
        private System.Windows.Forms.TextBox txtBoxSalaryLName;
        private System.Windows.Forms.Label lblSalaryLastName;
        private System.Windows.Forms.Label lblSalaryFName;
        private System.Windows.Forms.TextBox txtSumSalary;
        private System.Windows.Forms.TextBox txtSalaryCountDays;
        private System.Windows.Forms.Button btnExit;
    }
}