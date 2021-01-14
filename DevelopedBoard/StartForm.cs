using DPerevalov.SoftWareDeveloped.Storage;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPerevalov.SoftWareDeveloped.DevelopedBoard
{
    public partial class StartForm : Form
    {
        //Старт программы
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        private void btExit_Click(object sender, EventArgs e)
        {
            //Выход их программы
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            //Обращаемся к открытию базы
            DBOpenCloseBase.DBOpen();
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Обращаемся для закрытия БД при закрытии программы
            DBOpenCloseBase.DBClose();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = (AddForm)Application.OpenForms["AddForm"];

            // Если форма не существует, то создаём
            if (addForm == null)
            {
                // Создание нового экземпляра формы
                AddForm form2 = new AddForm();
                // Отображаем форму
                form2.Show();
            }
            else
                // Активируем форму на передний план (из трея или заднего плана)
                addForm.Activate();
        }

        private UpdatingTable()
        {
            //
        }

    }
}
