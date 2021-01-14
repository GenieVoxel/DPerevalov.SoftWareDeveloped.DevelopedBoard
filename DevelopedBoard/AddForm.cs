using DPerevalov.SoftWareDeveloped.Storage;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DPerevalov.SoftWareDeveloped.DevelopedBoard
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //Закрытие формы
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //Добовляем запись
            DBOpenCloseBase.DBAdd(txtName.Text, cbNameGroup.Text, int.Parse(mstxtSalaryrate.Text), 
                dtDate.Value.Date, cbNameSubordinate.Text);
            //Закрытие формы
            this.Close();
        }
    }
}
