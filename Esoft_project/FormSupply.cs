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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentsSet in Program.wftDb.AgentSet)
            {
                string[] item =
                {
                    agentsSet.id.ToString()+".",agentsSet.FirstName, agentsSet.LastName
                };
                comboBoxAgents.Items.Add(string.Join(" ", item));

            }

        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientSet clientsSet in Program.wftDb.ClientSet)
            {
                string[] item =
                {
                    clientsSet.id.ToString()+".", clientsSet.FirstName, clientsSet.LastName
                };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }

        }
        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstatesSet in Program.wftDb.RealEstateSet)
            {
                string[] item =
                {
                   realEstatesSet.id.ToString()+".", realEstatesSet.Address_City+",", realEstatesSet.Address_Street, realEstatesSet.Address_House,
                   realEstatesSet.Address_Number
                };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));

            }

        }
        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.idAgent.ToString(), supply.AgentSet.LastName+" "+supply.AgentSet.FirstName+" ", supply.idClient.ToString(),
                    supply.ClientSet.LastName+" "+supply.ClientSet.FirstName, supply.idRealEstate.ToString(), supply.RealEstateSet.Address_City+""+supply.RealEstateSet.Address_Street+""+supply.RealEstateSet.Address_House+""+supply.RealEstateSet.Address_Number,
                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void comboBoxAgents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate.SelectedItem != null && textBoxPrice.Text != " ")
            {
                SupplySet supply = new SupplySet();
                supply.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]); supply.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.idRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]); supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SupplySet.Add(supply);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate.SelectedItem != null && textBoxPrice.Text != " ")
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    supply.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    supply.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    supply.idRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                    supply.Price = Convert.ToInt64(textBoxPrice.Text);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
            }
            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.idAgent.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.idClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.idRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();

            }
            else
            {
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = " ";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.wftDb.SupplySet.Remove(supply);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("данные не удаляются", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
