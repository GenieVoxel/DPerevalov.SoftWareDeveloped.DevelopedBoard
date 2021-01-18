using DPerevalov.SoftWareDeveloped.Storage;
using DPerevalov.SoftWareDeveloped.MajorProject;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

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
            dtDey.Value = DateTime.Now;

            //Обращаемся к открытию базы
            DBOpenCloseBase.DBOpen();

            UpdatingTable();

            lbZPFirm.Text = "Идет подсчет...";
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
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
        
        // Метод обновления таблицы
        private void UpdatingTable()
        {

            SQLiteConnection baseConnect;
            SQLiteCommand baseCmd;
            String baseName = "CompanyWorkers.db";

            baseConnect = new SQLiteConnection();
            baseCmd = new SQLiteCommand();
            SQLiteConnection ConnectDB = new SQLiteConnection(@"Data Source = " + baseName + "; Version=3;");
            baseConnect = new SQLiteConnection("Data Source=" + baseName + ";Version=3;");
            baseConnect.Open();

            DataTable dTable = new DataTable();
            String CommandText;
                
            // Заполняем таблицу данными
            try
            {
                CommandText = "SELECT * FROM CompanyTable";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(CommandText, ConnectDB);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dgView.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dgView.Rows.Add(dTable.Rows[i].ItemArray);
                }

                baseCmd.Connection = baseConnect;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            baseConnect.Close();
        }

        private void StartForm_Activated(object sender, EventArgs e)
        {
            // При активации формы, обновить таблицу
            UpdatingTable();
        }

        private void dgView_Click(object sender, EventArgs e)
        {
            // Проверка, есть ли строки в dataGridView1
            if (dgView.RowCount <= 1)
            {
                return;
            }
            else
            {
                // Определение номера (позиции) выделенной строки
                int index = dgView.CurrentRow.Index;

                // Проверка, выделена ли вообще строка
                if (index == dgView.RowCount)
                {
                    lbNameZP.Text = "Строка не выделена";
                    return;
                }
                else
                {
                    // Если строка выделена, то вывести информацию о ней
                    string sName = (string)dgView.Rows[index].Cells[1].Value;
                    string sNamegroup = (string)dgView.Rows[index].Cells[2].Value;
                    string sSalaryrate = (string)dgView.Rows[index].Cells[3].Value;
                    string sDate = (string)dgView.Rows[index].Cells[4].Value;
                    string sNamesubordination = (string)dgView.Rows[index].Cells[5].Value;
                    string sNamesubordinate = (string)dgView.Rows[index].Cells[6].Value;
                    
                    // Вывод Имени сотрудника
                    lbNameZP.Text = sName;
                    lbZPName.Text = "Идет пересчет...";

                    string tData = dtDey.Value.ToString("dd.MM.yyyy");

                    // Выполняем действия по начислению зарплаты по группе сотрудника и вызова соответствующего класса
                    if (sNamegroup == "Manager")
                    {
                        Manager.ManagerZP(sSalaryrate);
                    }
                    else if (sNamegroup == "Salesman")
                        {
                            //
                        }
                        else
                        {
                        // sDate - Дата принятия на работу
                        // tData - Дата на момент расчета зарплаты
                        lbZPName.Text = Employee.WagesEmployee(sDate, tData, sSalaryrate).ToString("0.00");
                        }

                }
            }
         }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Проверка, есть ли строки в dataGridView1
            if (dgView.RowCount <= 1)
            {
                return;
            }
            else
            {
                // Определение номера (позиции) выделенной строки
                int index = dgView.CurrentRow.Index;

                // Проверка, выделена ли вообще строка
                if (index == dgView.RowCount)
                {
                    lbNameZP.Text = "Строка не выделена";
                    return;
                }
                else
                {
                    // Определяем запись для удаления
                    //int sDelete = (int)dgView.Rows[index].Cells[0].Value;
                    //lbNameZP.Text = "Удлить строку: " + sDelete.ToString();
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
