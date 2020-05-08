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
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowAgent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentSet agentSet = new AgentSet();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.Procent = textBoxProcent.Text;
            Program.wftDb.AgentSet.Add(agentSet);
            Program.wftDb.SaveChanges();
            ShowAgent();
        }
        void ShowAgent()
        {
            listViewAgents.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    agentSet.id.ToString(), agentSet.FirstName, agentSet.MiddleName, agentSet.LastName, agentSet.Procent

                });
                item.Tag = agentSet;
                listViewAgents.Items.Add(item);
            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentSet;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.Procent = textBoxProcent.Text;
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
        }

        private void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentSet;
                textBoxFirstName.Text = agentSet.FirstName;
                textBoxMiddleName.Text = agentSet.MiddleName;
                textBoxLastName.Text = agentSet.LastName;
                textBoxProcent.Text = agentSet.Procent;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxProcent.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgents.SelectedItems[0].Tag as AgentSet;
                    Program.wftDb.AgentSet.Remove(agentSet);
                    Program.wftDb.SaveChanges();
                    ShowAgent();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxProcent.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
