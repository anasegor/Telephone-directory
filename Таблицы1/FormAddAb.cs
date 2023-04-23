using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Таблицы1
{
    public partial class FormAddAb : Form
    {
        public FormAddAb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//добавление данных
        {

            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
