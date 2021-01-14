
namespace DPerevalov.SoftWareDeveloped.DevelopedBoard
{
    partial class AddForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lbSalaryRate = new System.Windows.Forms.Label();
            this.mstxtSalaryrate = new System.Windows.Forms.MaskedTextBox();
            this.lbNameGroup = new System.Windows.Forms.Label();
            this.cbNameGroup = new System.Windows.Forms.ComboBox();
            this.lbNameSubordinate = new System.Windows.Forms.Label();
            this.cbNameSubordinate = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(31, 15);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Имя";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(163, 15);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 23);
            this.txtName.TabIndex = 1;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(13, 51);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(144, 15);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Дата принятия на работу";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(163, 43);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(162, 23);
            this.dtDate.TabIndex = 3;
            // 
            // lbSalaryRate
            // 
            this.lbSalaryRate.AutoSize = true;
            this.lbSalaryRate.Location = new System.Drawing.Point(13, 83);
            this.lbSalaryRate.Name = "lbSalaryRate";
            this.lbSalaryRate.Size = new System.Drawing.Size(88, 15);
            this.lbSalaryRate.TabIndex = 4;
            this.lbSalaryRate.Text = "Базовая ставка";
            // 
            // mstxtSalaryrate
            // 
            this.mstxtSalaryrate.Location = new System.Drawing.Point(163, 72);
            this.mstxtSalaryrate.Mask = "0000000000";
            this.mstxtSalaryrate.Name = "mstxtSalaryrate";
            this.mstxtSalaryrate.Size = new System.Drawing.Size(162, 23);
            this.mstxtSalaryrate.TabIndex = 5;
            this.mstxtSalaryrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mstxtSalaryrate.ValidatingType = typeof(int);
            // 
            // lbNameGroup
            // 
            this.lbNameGroup.AutoSize = true;
            this.lbNameGroup.Location = new System.Drawing.Point(13, 112);
            this.lbNameGroup.Name = "lbNameGroup";
            this.lbNameGroup.Size = new System.Drawing.Size(46, 15);
            this.lbNameGroup.TabIndex = 6;
            this.lbNameGroup.Text = "Группа";
            // 
            // cbNameGroup
            // 
            this.cbNameGroup.AutoCompleteCustomSource.AddRange(new string[] {
            "Employee",
            "Manager",
            "Salesman"});
            this.cbNameGroup.FormattingEnabled = true;
            this.cbNameGroup.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Salesman"});
            this.cbNameGroup.Location = new System.Drawing.Point(163, 104);
            this.cbNameGroup.Name = "cbNameGroup";
            this.cbNameGroup.Size = new System.Drawing.Size(162, 23);
            this.cbNameGroup.TabIndex = 7;
            this.cbNameGroup.Text = "Employee";
            // 
            // lbNameSubordinate
            // 
            this.lbNameSubordinate.AutoSize = true;
            this.lbNameSubordinate.Location = new System.Drawing.Point(13, 142);
            this.lbNameSubordinate.Name = "lbNameSubordinate";
            this.lbNameSubordinate.Size = new System.Drawing.Size(86, 15);
            this.lbNameSubordinate.TabIndex = 8;
            this.lbNameSubordinate.Text = "Подчиненный";
            // 
            // cbNameSubordinate
            // 
            this.cbNameSubordinate.FormattingEnabled = true;
            this.cbNameSubordinate.Location = new System.Drawing.Point(163, 134);
            this.cbNameSubordinate.Name = "cbNameSubordinate";
            this.cbNameSubordinate.Size = new System.Drawing.Size(162, 23);
            this.cbNameSubordinate.TabIndex = 9;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(354, 15);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Запись";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(354, 51);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 169);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbNameSubordinate);
            this.Controls.Add(this.lbNameSubordinate);
            this.Controls.Add(this.cbNameGroup);
            this.Controls.Add(this.lbNameGroup);
            this.Controls.Add(this.mstxtSalaryrate);
            this.Controls.Add(this.lbSalaryRate);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbSalaryRate;
        private System.Windows.Forms.MaskedTextBox mstxtSalaryrate;
        private System.Windows.Forms.Label lbNameGroup;
        private System.Windows.Forms.ComboBox cbNameGroup;
        private System.Windows.Forms.Label lbNameSubordinate;
        private System.Windows.Forms.ComboBox cbNameSubordinate;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DateTimePicker dtDate;
    }
}