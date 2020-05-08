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
    public partial class FormDeal : Form
    {
        public FormDeal()
        {
            InitializeComponent();
            ShowSupply();
            ShowDemand();
        }
        void ShowSupply()
        {
            comboBoxSupply.Items.Clear();
            foreach (SupplySet supplySet in Program.wftDb.SupplySet)
            {
                string[] item =
                {
                    supplySet.id.ToString()+ ". ",
                    "Pиелтор: "+ supplySet.AgentSet.LastName,
                    "Kлиент: "+supplySet.ClientSet.LastName
                };
                comboBoxSupply.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemand()
        {
            comboBoxDemand.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                string[] item =
                {
                    demandSet.id.ToString() + ". ",
                    "Риелтор: " + demandSet.AgentSet.LastName,
                    "Клиент: " + demandSet.ClientSet.LastName
                };
                comboBoxDemand.Items.Add(string.Join(" ", item));
            }
        }
        private void comboBoxSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        private void comboBoxDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        void Deductions()
        {

            if (comboBoxSupply.SelectedItem != null && comboBoxDemand.SelectedItem != null)
            {
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                DemandSet demandSet = Program.wftDb.DemandSet.Find(Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]));
                double customerCompanyDeductions = supplySet.Price * 0.03;
                textCustomerCompanyDeductions.Text = customerCompanyDeductions.ToString("0.00");
                if (demandSet.AgentSet.Procent != null)
                {
                    double agentCustomerDeductions = customerCompanyDeductions * Convert.ToDouble(demandSet.AgentSet.Procent) / 100;
                    textBoxAgentSellerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
                else
                {
                    double agentCustomerDeductions = customerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentCustomerDeductions.ToString("0.00");
                }
            }
            else
            {
                textCustomerCompanyDeductions.Text = " ";
                textBoxAgentSellerDeductions.Text = "";
            }
            if (comboBoxSupply.SelectedItem != null)
            {
                SupplySet supplySet = Program.wftDb.SupplySet.Find(Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]));
                double sellerCompanyDeductions;
                if (supplySet.RealEstateSet.Type == 0)
                {
                    sellerCompanyDeductions = 36000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else if (supplySet.RealEstateSet.Type == 1)
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.01;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                else
                {
                    sellerCompanyDeductions = 30000 + supplySet.Price * 0.02;
                    textBoxSellerCompanyDeductions.Text = sellerCompanyDeductions.ToString("0.00");
                }
                if (supplySet.AgentSet.Procent != null)
                {
                    double agentSellerDeductions = sellerCompanyDeductions * Convert.ToDouble(supplySet.AgentSet.Procent) / 100;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }
                else
                {
                    double agentSellerDeductions = sellerCompanyDeductions * 0.45;
                    textBoxAgentSellerDeductions.Text = agentSellerDeductions.ToString("0.00");
                }

            }
            else
            {
                textBoxAgentSellerDeductions.Text = "";
                textBoxSellerCompanyDeductions.Text = "";
                textCustomerCompanyDeductions.Text = "";
                textBoxAgentCustomerDeductions.Text = "";

            }
        }
        void ShowDealSet()
        {
            listViewDealSet.Items.Clear();
            foreach (DealSet deal in Program.wftDb.DealSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    deal.SupplySet.ClientSet.LastName,
                    deal.SupplySet.AgentSet.LastName,
                    deal.DemandSet.ClientSet.LastName,
                    deal.DemandSet.AgentSet.LastName,
                    deal.SupplySet.RealEstateSet.Address_City+ deal.SupplySet.RealEstateSet.Address_House+deal.SupplySet.RealEstateSet.Address_Street,
                    deal.SupplySet.Price.ToString()
                });
                item.Tag = deal;
                listViewDealSet.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDemand.SelectedItem != null && comboBoxSupply.SelectedItem != null)
            {
                DealSet deal = new DealSet();
                deal.idSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.idDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.DealSet.Add(deal);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                deal.idSupply = Convert.ToInt32(comboBoxSupply.SelectedItem.ToString().Split('.')[0]);
                deal.idDemand = Convert.ToInt32(comboBoxDemand.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowDealSet();
            }
        }

        private void listViewDealSet_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewDealSet.SelectedItems.Count == 1)
            {
                DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                comboBoxSupply.SelectedIndex = comboBoxSupply.FindString(deal.idSupply.ToString());
                comboBoxDemand.SelectedIndex = comboBoxDemand.FindString(deal.idSupply.ToString());

            }
            else
            {
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDealSet.SelectedItems.Count == 1)
                {
                    DealSet deal = listViewDealSet.SelectedItems[0].Tag as DealSet;
                    Program.wftDb.DealSet.Remove(deal);
                    Program.wftDb.SaveChanges();
                    ShowDealSet();
                }
                comboBoxSupply.SelectedItem = null;
                comboBoxDemand.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("не возможно удалить", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
