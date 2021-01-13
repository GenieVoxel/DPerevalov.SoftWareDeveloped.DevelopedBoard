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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
