using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_project
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientSet in Program.wftDb.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientSet.id.ToString(), clientSet.FirstName, clientSet.MiddleName, clientSet.LastName, clientSet.Phone, clientSet.Email

                });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                Program.wftDb.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.wftDb.ClientSet.Remove(clientSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            ClientSet clientSet = new ClientSet();
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            Program.wftDb.ClientSet.Add(clientSet);
            Program.wftDb.SaveChanges();
        }

        
    }
}
