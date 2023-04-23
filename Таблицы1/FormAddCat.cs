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
    public partial class FormAddCatCon : Form
    {
        public FormAddCatCon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public Dictionary<int, string> AbData
        {
            set
            {
                comboBoxCatAb.DataSource = value.ToArray();
                comboBoxCatAb.DisplayMember = "Value";
            }
        }
        public int AbId//полчить ФИО
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBoxCatAb.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBoxCatAb.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                comboBoxCatAb.SelectedIndex = idx;
            }
        }
        public Dictionary<int, string> ConData
        {
            set
            {
                comboBoxCatCo.DataSource = value.ToArray();
                comboBoxCatCo.DisplayMember = "Value";
            }
        }
        public int ConId//полчить ФИО
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBoxCatCo.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach (KeyValuePair<int, string> item in comboBoxCatCo.Items)
                {
                    if (item.Key == value)
                    {
                        break;
                    }
                    idx++;
                }
                comboBoxCatCo.SelectedIndex = idx;
            }
        }
    }
}
