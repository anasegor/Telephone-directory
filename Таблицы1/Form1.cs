using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Таблицы1
{
    public partial class Form1 : Form
    {
        string connection = "Data Source=192.168.9.5;User ID=sa;Password=sa";
        public void TableAbonents()
        {
            string querlySQL = "SELECT * FROM [Egorova_Abonents]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(querlySQL, connection);
            //Создаем объект-таблицу
            DataTable abonent = new DataTable();
            //Заполняем таблицу посредством адаптера
            aOrder.Fill(abonent);
            abonent.Columns["surname"].ColumnName = "Фамилия";
            abonent.Columns["name"].ColumnName = "Имя";
            abonent.Columns["patronymic"].ColumnName = "Отчество";
            abonent.Columns["address"].ColumnName = "Адрес";
            abonent.Columns["comment"].ColumnName = "Комментарий";
            abonent.Columns["b_date"].ColumnName = "День_рождения";
            dataGridView1.DataSource = abonent;
            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView1.Columns["b_date"].HeaderText = "День_рождения";
        }
        public void TableContacts()
        {
            string querlySQL = @"SELECT * FROM [Egorova_Contact]
                                JOIN [Egorova_Provider] ON Egorova_Contact.provider_id=Egorova_Provider.id";

            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(querlySQL, connection);
            //Создаем объект-таблицу
            DataTable contact = new DataTable();
            //Заполняем таблицу посредством адаптера
            aOrder.Fill(contact);
            contact.Columns["phone"].ColumnName = "Номер телефона";
            contact.Columns["type"].ColumnName = "Тип";
            contact.Columns["name"].ColumnName = "Провайдер";
            dataGridView2.DataSource = contact;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Id1"].Visible = false;
            dataGridView2.Columns["score"].Visible = false;
            dataGridView2.Columns["provider_id"].Visible = false;
        }
        public void TableProviders()
        {
            string querlySQL = "SELECT * FROM [Egorova_Provider]";
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(querlySQL, connection);
            //Создаем объект-таблицу
            DataTable prov = new DataTable();
            //Заполняем таблицу посредством адаптера
            aOrder.Fill(prov);
            prov.Columns["name"].ColumnName = "Имя";
            prov.Columns["score"].ColumnName = "Счет";
            dataGridView3.DataSource = prov;
            dataGridView3.Columns["Id"].Visible = false;
        }
        public void TableCatalog()
        {

            string querlySQL = @"SELECT * FROM [Egorova_Abonents]
                                    JOIN [Egorova_Abonents_Has_Contact] ON Egorova_Abonents.Id=Egorova_Abonents_Has_Contact.abonents_id
                                    JOIN [Egorova_Contact] ON Egorova_Abonents_Has_Contact.contact_id=Egorova_Contact.Id
                                    JOIN [Egorova_Provider] ON Egorova_Contact.provider_id=Egorova_Provider.id";
                 //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(querlySQL, connection);
            //Создаем объект-таблицу
            DataTable catalog = new DataTable();
            //Заполняем таблицу посредством адаптера
            aOrder.Fill(catalog);

            catalog.Columns["name"].ColumnName = "Имя";
            catalog.Columns["surname"].ColumnName = "Фамилия";
            catalog.Columns["patronymic"].ColumnName = "Отчество";
            catalog.Columns["address"].ColumnName = "Адрес";
            catalog.Columns["comment"].ColumnName = "Комментарий";
            catalog.Columns["b_date"].ColumnName = "День_рождения";
            catalog.Columns["phone"].ColumnName = "Номер телефона";
            catalog.Columns["type"].ColumnName = "Тип";
            catalog.Columns["name1"].ColumnName = "Провайдер";

            dataGridView4.DataSource = catalog;
            dataGridView4.Columns["Id"].Visible = false;
            dataGridView4.Columns["Id1"].Visible = false;
            dataGridView4.Columns["Id2"].Visible = false;
            dataGridView4.Columns["abonents_id"].Visible = false;
            dataGridView4.Columns["contact_id"].Visible = false;
            dataGridView4.Columns["provider_id"].Visible = false;
            dataGridView4.Columns["score"].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            TableAbonents();
            TableContacts();
            TableProviders();
            TableCatalog();
            
        }

        private void SearchInTable()
        {
           // string [] words = for_phio.Text.Split(' ');

            string querlySQL = string.Format(@"SELECT * FROM [Egorova_Abonents]
                                    JOIN [Egorova_Abonents_Has_Contact] ON [Egorova_Abonents].Id=[Egorova_Abonents_Has_Contact].abonents_id
                                    JOIN [Egorova_Contact] ON [Egorova_Abonents_Has_Contact].contact_id=[Egorova_Contact].Id
                                    JOIN [Egorova_Provider] ON [Egorova_Contact].provider_id=[Egorova_Provider].id
                                    WHERE [Egorova_Abonents].surname +' '+ [Egorova_Abonents].name+' '+ [Egorova_Abonents].patronymic LIKE '%"+for_phio.Text +@"%'  
                                    AND [Egorova_Abonents].address LIKE '%"+for_address.Text +@"%'  
                                    AND [Egorova_Provider].name LIKE '%" + for_provider.Text + @"%'
                                    AND [Egorova_Contact].phone LIKE '%" +for_telnumber.Text +"%' "
                                    
                                    );
            //Создаем объект адаптера
            SqlDataAdapter aOrder = new SqlDataAdapter(querlySQL, connection);
            //Создаем объект-таблицу
            DataTable catalog = new DataTable();
            //Заполняем таблицу посредством адаптера
            aOrder.Fill(catalog);
           

            catalog.Columns["name"].ColumnName = "Имя";
            catalog.Columns["surname"].ColumnName = "Фамилия";
            catalog.Columns["patronymic"].ColumnName = "Отчество";
            catalog.Columns["address"].ColumnName = "Адрес";
            catalog.Columns["comment"].ColumnName = "Комментарий";
            catalog.Columns["b_date"].ColumnName = "День_рождения";
            catalog.Columns["phone"].ColumnName = "Номер телефона";
            catalog.Columns["type"].ColumnName = "Тип";
            catalog.Columns["name1"].ColumnName = "Провайдер";

            dataGridView4.DataSource = catalog;
            dataGridView4.Columns["Id"].Visible = false;
            dataGridView4.Columns["Id1"].Visible = false;
            dataGridView4.Columns["Id2"].Visible = false;
            dataGridView4.Columns["abonents_id"].Visible = false;
            dataGridView4.Columns["contact_id"].Visible = false;
            dataGridView4.Columns["provider_id"].Visible = false;
            dataGridView4.Columns["score"].Visible = false;
        }

        private void for_phio_TextChanged(object sender, EventArgs e)
        {
            SearchInTable();

        }

        private void for_address_TextChanged(object sender, EventArgs e)
        {
            SearchInTable();
        }

        private void for_telnumber_TextChanged(object sender, EventArgs e)
        {
            SearchInTable();
        }


        private void for_provider_TextChanged(object sender, EventArgs e)
        {
            SearchInTable();
        }

        private void button1_Click(object sender, EventArgs e)//добавить абонента
        {
            FormAddAb newform= new FormAddAb();
            var res=newform.ShowDialog();
            if(res==DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"INSERT INTO [Egorova_Abonents] 
                                                    (surname,name, patronymic, address, comment, b_date)
                                                    VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", newform.for_sn.Text, newform.for_n.Text, newform.for_p.Text, newform.for_a.Text, newform.for_c.Text, newform.for_d.Value.ToString("yyyy-MM-dd"));
                command.ExecuteReader();
                TableAbonents();
                conn.Close();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)//изменить абонента
        {
            if(dataGridView1.SelectedRows.Count==0)
                MessageBox.Show("Нужно выбрать строку");

            if(dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];//строка
                FormAddAb newform = new FormAddAb();
                var comment = (string)row.Cells["Комментарий"].Value.ToString();
                newform.for_sn.Text = row.Cells["Фамилия"].Value.ToString();
                newform.for_n.Text = row.Cells["Имя"].Value.ToString();
                newform.for_p.Text = row.Cells["Отчество"].Value.ToString();
                newform.for_a.Text = row.Cells["Адрес"].Value.ToString();
                newform.for_d.Text = row.Cells["День_рождения"].Value.ToString();
                newform.for_c.Text = (string)comment;
                var res = newform.ShowDialog();
                if (res == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = connection;
                    conn.Open();//Открываем соединение
                    //Создаем команду, ассоциированную с открытым соединением
                    SqlCommand command = conn.CreateCommand();

                    //Определяем саму команду и ее параметры
                   command.CommandText = string.Format(@"UPDATE [Egorova_Abonents] 
                                                       SET [Egorova_Abonents].surname='{0}',[Egorova_Abonents].name='{1}',
                                                       [Egorova_Abonents].patronymic='{2}',[Egorova_Abonents].address='{3}',
                                                       [Egorova_Abonents].comment='{4}',[Egorova_Abonents].b_date='{5}' 
                                                       WHERE [Egorova_Abonents].Id='{6}'", newform.for_sn.Text, newform.for_n.Text, newform.for_p.Text, newform.for_a.Text, newform.for_d.Value.ToString("yyyy-MM-dd"), newform.for_c.Text, row.Cells["Id"].Value 
                                                                                       );
                    command.ExecuteReader();
                    TableAbonents();
                    conn.Close();
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)//удаление
        {
            //также удалить упоминания в других таблицах
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");
            if (dataGridView1.SelectedRows.Count >0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];//строка
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"DELETE [Egorova_Abonents] 
                                                       WHERE [Egorova_Abonents].Id='{0}'", row.Cells["Id"].Value
                                                                                    );
                command.ExecuteReader();
                TableAbonents();
                conn.Close();
            }

        }
        


        private void button4_Click(object sender, EventArgs e)//добавить контакта
        {
            
                FormAddCo newform = new FormAddCo();
                var request = string.Format(@"SELECT * FROM [Egorova_Provider]");
                //Создаем объект адаптера
                SqlDataAdapter aOrder = new SqlDataAdapter(request, connection);
                //Создаем объект-таблицу
                DataTable provider = new DataTable();
                //Заполняем таблицу посредством адаптера
                aOrder.Fill(provider);
               //для выпадающего списка
                var dict = new Dictionary<int, string>();
                foreach (DataRow row in provider.Rows)
                {
                    dict.Add((int)row["id"], row["name"].ToString());
                }
                newform.ProviderData = dict;
                var res = newform.ShowDialog();
                var providerId = newform.ProviderId;
                TableAbonents();
                if (res == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = connection;
                    conn.Open();//Открываем соединение
                    //Создаем команду, ассоциированную с открытым соединением
                    SqlCommand command = conn.CreateCommand();
                    //Определяем саму команду и ее параметры
                    command.CommandText = string.Format(@"INSERT INTO [Egorova_Contact] 
                                                    (phone,type, provider_id)
                                                    VALUES ('{0}','{1}','{2}')", newform.for_tel.Text, newform.for_type.Text, newform.ProviderId);
                    command.ExecuteReader();
                    TableContacts();
                    conn.Close();
                }

            
                
            
        }

        private void button5_Click(object sender, EventArgs e)//изменить контакта
        {
            if (dataGridView2.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];//строка
                FormAddCo newform = new FormAddCo();
                var request = string.Format(@"SELECT * FROM [Egorova_Provider]");
                //Создаем объект адаптера
                SqlDataAdapter aOrder = new SqlDataAdapter(request, connection);
                //Создаем объект-таблицу
                DataTable provider = new DataTable();
                //Заполняем таблицу посредством адаптера
                aOrder.Fill(provider);
                //для выпадающего списка
                var dict = new Dictionary<int, string>();
                foreach (DataRow ro in provider.Rows)
                {
                    dict.Add((int)ro["id"], ro["name"].ToString());
                }
                newform.ProviderData = dict;
                var providerId = newform.ProviderId;
                TableAbonents();

                newform.for_tel.Text = row.Cells["Номер телефона"].Value.ToString();
                newform.for_type.Text = row.Cells["Тип"].Value.ToString();
                newform.ProviderId = (int)row.Cells["provider_id"].Value;
                var res = newform.ShowDialog();
                if (res == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = connection;
                    conn.Open();//Открываем соединение
                    //Создаем команду, ассоциированную с открытым соединением
                    SqlCommand command = conn.CreateCommand();

                    //Определяем саму команду и ее параметры
                    command.CommandText = string.Format(@"UPDATE [Egorova_Contact] 
                                                       SET [Egorova_Contact].phone='{0}',[Egorova_Contact].type='{1}',
                                                       [Egorova_Contact].provider_id='{2}' 
                                                       WHERE [Egorova_Contact].Id='{3}'", newform.for_tel.Text, newform.for_type.Text, newform.ProviderId, row.Cells["Id"].Value 
                                                                                        );
                    command.ExecuteReader();
                    TableContacts();
                    conn.Close();
                }
            }
           
        }

        private void button6_Click(object sender, EventArgs e)//удалить контакта
        {
            //также удалить упоминания в других таблицах
            if (dataGridView2.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];//строка
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"DELETE [Egorova_Contact] 
                                                       WHERE [Egorova_Contact].Id='{0}'", row.Cells["Id"].Value
                                                                                    );
                command.ExecuteReader();
                TableContacts();
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)//добавить провайдера
        {
            FormAddProv newform = new FormAddProv();
            var res = newform.ShowDialog();
            if (res == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"INSERT INTO [Egorova_Provider] 
                                                    (name, score)
                                                    VALUES ('{0}','{1}')", newform.for_n.Text, newform.for_s.Text);
                command.ExecuteReader();
                TableProviders();
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)//изменить провайдера
        {
            if (dataGridView3.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");

            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView3.SelectedRows[0];//строка
                FormAddProv newform = new FormAddProv();
                newform.for_n.Text = row.Cells["Имя"].Value.ToString();
                newform.for_s.Text = row.Cells["Счет"].Value.ToString();
                var res = newform.ShowDialog();
                if (res == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = connection;
                    conn.Open();//Открываем соединение
                    //Создаем команду, ассоциированную с открытым соединением
                    SqlCommand command = conn.CreateCommand();

                    //Определяем саму команду и ее параметры
                    command.CommandText = string.Format(@"UPDATE [Egorova_Provider] 
                                                       SET [Egorova_Provider].name='{0}',[Egorova_Provider].score='{1}'
                                                       WHERE [Egorova_Provider].Id='{2}'", newform.for_n.Text, newform.for_s.Text,row.Cells["Id"].Value
                                                                                        );
                    command.ExecuteReader();
                    TableProviders();
                    conn.Close();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)//удалить провайдера
        {
            if (dataGridView3.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView3.SelectedRows[0];//строка
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"DELETE [Egorova_Provider] 
                                                       WHERE [Egorova_Provider].Id='{0}'", row.Cells["Id"].Value
                                                                                    );
                command.ExecuteReader();
                TableProviders();
                conn.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)//добавить в каталог
        {
            FormAddCatCon newform = new FormAddCatCon();
            var request1 = string.Format(@"SELECT * FROM [Egorova_Abonents]");
            var request2 = string.Format(@"SELECT * FROM [Egorova_Contact]");
            //Создаем объект адаптера
            SqlDataAdapter aOrder1 = new SqlDataAdapter(request1, connection);
            SqlDataAdapter aOrder2 = new SqlDataAdapter(request2, connection);
            //Создаем объект-таблицу
            DataTable abon = new DataTable();
            DataTable cont = new DataTable();
            //Заполняем таблицу посредством адаптера
            aOrder1.Fill(abon);
            aOrder2.Fill(cont);
            //для выпадающего списка
            var dict1 = new Dictionary<int, string>();
            var dict2 = new Dictionary<int, string>();
            foreach (DataRow ro in abon.Rows)
            {
                dict1.Add((int)ro["id"], ro["name"]+ro["surname"].ToString());
            }
            foreach (DataRow row in cont.Rows)
            {
                dict2.Add((int)row["id"], row["phone"].ToString());
            }
            newform.AbData = dict1;
            newform.ConData = dict2;

            var res = newform.ShowDialog();
            if (res == DialogResult.OK)
            {
                var conId = newform.ConId;
                var abonId = newform.AbId;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();
                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"INSERT INTO [Egorova_Abonents_Has_Contact]
                                                    (abonents_id,contact_id)
                                                    VALUES ('{0}','{1}')", abonId, conId);
                command.ExecuteReader();
                TableCatalog();
                conn.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)//изменить в каталоге
        {
            if (dataGridView4.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");

            if (dataGridView4.SelectedRows.Count > 0)
            {
                DataGridViewRow row1 = dataGridView4.SelectedRows[0];//строка
                FormAddCatCon newform = new FormAddCatCon();
                var request1 = string.Format(@"SELECT * FROM [Egorova_Abonents]");
                var request2 = string.Format(@"SELECT * FROM [Egorova_Contact]");
                //Создаем объект адаптера
                SqlDataAdapter aOrder1 = new SqlDataAdapter(request1, connection);
                SqlDataAdapter aOrder2 = new SqlDataAdapter(request2, connection);
                //Создаем объект-таблицу
                DataTable abon = new DataTable();
                DataTable cont = new DataTable();
                //Заполняем таблицу посредством адаптера
                aOrder1.Fill(abon);
                aOrder2.Fill(cont);
                //для выпадающего списка
                var dict1 = new Dictionary<int, string>();
                var dict2 = new Dictionary<int, string>();
                foreach (DataRow ro in abon.Rows)
                {
                    dict1.Add((int)ro["id"], ro["name"] + ro["surname"].ToString());
                }
                foreach (DataRow row in cont.Rows)
                {
                    dict2.Add((int)row["id"], row["phone"].ToString());
                }
                newform.AbData = dict1;
                newform.ConData = dict2;
                //инициализация combobox
                var conId0 = (int)row1.Cells["contact_id"].Value;
                var abonId0 = (int)row1.Cells["abonents_id"].Value;
                //сохранение старых старых ид
                newform.ConId = conId0;
                newform.AbId = abonId0;

                var res = newform.ShowDialog();

                if (res == DialogResult.OK)
                {
                    //новые ид
                    var conId1 = newform.ConId;
                    var abonId1 = newform.AbId;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = connection;
                    conn.Open();//Открываем соединение
                    //Создаем команду, ассоциированную с открытым соединением
                    SqlCommand command = conn.CreateCommand();

                    //Определяем саму команду и ее параметры
                    command.CommandText = string.Format(@"UPDATE [Egorova_Abonents_Has_Contact]
                                                       SET [Egorova_Abonents_Has_Contact].abonents_id='{0}',[Egorova_Abonents_Has_Contact].contact_id='{1}'
                                                       WHERE [Egorova_Abonents_Has_Contact].abonents_id='{2}' AND [Egorova_Abonents_Has_Contact].contact_id='{3}'",abonId1, conId1,abonId0, conId0
                                                                                        );
                    command.ExecuteReader();
                    TableCatalog();
                    conn.Close();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)//удалить из каталога
        {
            if (dataGridView4.SelectedRows.Count == 0)
                MessageBox.Show("Нужно выбрать строку");
            if (dataGridView4.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView4.SelectedRows[0];//строка
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection;
                conn.Open();//Открываем соединение
                //Создаем команду, ассоциированную с открытым соединением
                SqlCommand command = conn.CreateCommand();

                //Определяем саму команду и ее параметры
                command.CommandText = string.Format(@"DELETE [Egorova_Abonents_Has_Contact]
                                                       WHERE [Egorova_Abonents_Has_Contact].abonents_id='{0}' AND [Egorova_Abonents_Has_Contact].contact_id='{1}'", row.Cells["abonents_id"].Value,row.Cells["contact_id"].Value
                                                                                    );
                command.ExecuteReader();
                TableCatalog();
                conn.Close();
            }
        }
      

       
    }
}
