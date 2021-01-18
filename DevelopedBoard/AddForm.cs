using DPerevalov.SoftWareDeveloped.Storage;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

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
            //var dataWages = DateTime.Parse("dd.MM.yyyy");
            //Добовляем запись
            if (txtName.Text != cbNameSubordinate.Text)
            {
                DBOpenCloseBase.DBAdd(txtName.Text, cbNameGroup.Text, txtSalaryrate.Text, dtDate.Value.ToString("dd.MM.yyyy"), cbNameSubordinate.Text);

                //Закрытие формы
                this.Close();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            dtDate.Value = DateTime.Now;

            // Открыть БД и заполнить Лист именами
            SQLiteConnection baseConnect;
            SQLiteCommand baseCmd;
            String baseName = "CompanyWorkers.db";

            baseConnect = new SQLiteConnection("Data Source=" + baseName + ";Version=3;");
            baseConnect.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'CompanyTable';", baseConnect);
            SQLiteDataReader readName = command.ExecuteReader();

            cbNameSubordinate.Items.Clear();

            foreach (DbDataRecord record in readName)
            {
                cbNameSubordinate.Items.Add(record["name"].ToString());
            }

            baseConnect.Close();

        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtSalaryrate_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.Control || e.Alt || e.Shift || e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Left
                  || e.KeyCode == Keys.Right || e.KeyCode == Keys.Home || e.KeyCode == Keys.End)
                    return;

                if (txtSalaryrate.Text == "" && e.KeyCode == Keys.Decimal)
                    e.SuppressKeyPress = true;

                if (e.KeyCode != Keys.Decimal)
                    if ((txtSalaryrate.Text == "" && e.KeyValue == 188) || (txtSalaryrate.Text == "" && e.KeyValue == 190) || !(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                      || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyValue != 188 && e.KeyValue != 190)
                        e.SuppressKeyPress = true;

                char[] c = (txtSalaryrate.Text + e.KeyData).ToCharArray();
                for (int i = 0; i < c.Length; i++)
                    if (c[i] == ',')
                        if (e.KeyValue == 188 || e.KeyValue == 190 || e.KeyCode == Keys.Decimal || (txtSalaryrate.Text.Length - i) > 2)
                            e.SuppressKeyPress = true;
            }
        }

        private void cbNameGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNameGroup.Text == "Employee")
            {
                cbNameSubordinate.Visible = false;
            }
            else cbNameSubordinate.Visible = true;
        }
    }
}
