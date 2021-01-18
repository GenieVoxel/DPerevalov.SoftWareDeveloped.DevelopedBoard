
namespace DPerevalov.SoftWareDeveloped.DevelopedBoard
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.lbNameZP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDey = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbZPName = new System.Windows.Forms.Label();
            this.lbZPFirm = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namegroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesuardinate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesuardination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(576, 396);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 26);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "&Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(663, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 399);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(106, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "&Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(124, 399);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(106, 23);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "&Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(236, 399);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(106, 23);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "&Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.namegroup,
            this.salaryrate,
            this.date,
            this.namesuardinate,
            this.namesuardination});
            this.dgView.Location = new System.Drawing.Point(12, 12);
            this.dgView.Name = "dgView";
            this.dgView.RowTemplate.Height = 25;
            this.dgView.Size = new System.Drawing.Size(637, 287);
            this.dgView.TabIndex = 5;
            this.dgView.Click += new System.EventHandler(this.dgView_Click);
            // 
            // lbNameZP
            // 
            this.lbNameZP.Location = new System.Drawing.Point(13, 342);
            this.lbNameZP.Name = "lbNameZP";
            this.lbNameZP.Size = new System.Drawing.Size(130, 23);
            this.lbNameZP.TabIndex = 6;
            this.lbNameZP.Text = "Сотрудник не выбран";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(162, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "зарплата составляет: ";
            // 
            // dtDey
            // 
            this.dtDey.Location = new System.Drawing.Point(238, 305);
            this.dtDey.Name = "dtDey";
            this.dtDey.Size = new System.Drawing.Size(143, 23);
            this.dtDey.TabIndex = 0;
            this.dtDey.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выбор даты для начисления зарплаты";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Суммарная зарплата всех сотрудников фирмы:";
            // 
            // lbZPName
            // 
            this.lbZPName.Location = new System.Drawing.Point(301, 342);
            this.lbZPName.Name = "lbZPName";
            this.lbZPName.Size = new System.Drawing.Size(100, 23);
            this.lbZPName.TabIndex = 11;
            // 
            // lbZPFirm
            // 
            this.lbZPFirm.Location = new System.Drawing.Point(301, 369);
            this.lbZPFirm.Name = "lbZPFirm";
            this.lbZPFirm.Size = new System.Drawing.Size(100, 15);
            this.lbZPFirm.TabIndex = 12;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 43;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 56;
            // 
            // namegroup
            // 
            this.namegroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namegroup.HeaderText = "Группа";
            this.namegroup.Name = "namegroup";
            this.namegroup.Width = 71;
            // 
            // salaryrate
            // 
            this.salaryrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salaryrate.HeaderText = "Ставка оклада";
            this.salaryrate.Name = "salaryrate";
            this.salaryrate.Width = 110;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.HeaderText = "Дата приема на работу";
            this.date.Name = "date";
            this.date.Width = 111;
            // 
            // namesuardinate
            // 
            this.namesuardinate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namesuardinate.HeaderText = "Подчинение";
            this.namesuardinate.Name = "namesuardinate";
            this.namesuardinate.Width = 101;
            // 
            // namesuardination
            // 
            this.namesuardination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namesuardination.HeaderText = "Подчинененный";
            this.namesuardination.Name = "namesuardination";
            this.namesuardination.Width = 124;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.lbZPFirm);
            this.Controls.Add(this.lbZPName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNameZP);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начисление заработной платы";
            this.Activated += new System.EventHandler(this.StartForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbNameZP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbZPName;
        private System.Windows.Forms.Label lbZPFirm;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn namegroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesuardinate;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesuardination;
    }
}

