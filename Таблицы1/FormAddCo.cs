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
    public partial class FormAddCo : Form
    {
        public FormAddCo()
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
        public Dictionary<int,string> ProviderData
        {
            set{
                comboBoxProv.DataSource = value.ToArray();
                comboBoxProv.DisplayMember ="Value";
            }
        }
        public int ProviderId
        {
            get
            {
                return ((KeyValuePair<int, string>)comboBoxProv.SelectedItem).Key;
            }
            set
            {
                int idx = 0;
                foreach(KeyValuePair<int, string> item in comboBoxProv.Items)
                {
                    if(item.Key==value)
                    {
                        break;
                    }
                    idx++;
                }
                comboBoxProv.SelectedIndex = idx;
            }
        }

    }
}
