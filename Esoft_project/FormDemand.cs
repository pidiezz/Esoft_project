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
    public partial class Demands : Form
    {
        public Demands()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstateSet();
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentsSet in Program.wftDb.AgentSet)
            {
                string[] item =
                {
                    agentsSet.id.ToString()+".",
                    agentsSet.FirstName,
                    agentsSet.LastName
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
                    clientsSet.id.ToString()+".",
                    clientsSet.FirstName,
                     clientsSet.LastName
                };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSupplySet()
        {
            listViewRealEstateSet_Apartments.Items.Clear();
            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  demand.idAgent.ToString(),
                  demand.idClient.ToString(),
                  demand.Type.ToString(),
                  demand.MinPrice.ToString(),
                  demand.MaxPrice.ToString(),
                  demand.MaxRooms.ToString(),
                  demand.MinRooms.ToString(),
                  demand.MinArea.ToString(),
                  demand.MaxArea.ToString(),
                  demand.MinFloors.ToString(),
                });
                item.Tag = demand;
                listViewRealEstateSet_Apartments.Items.Add(item);
            }
        }
        void ShowRealEstateSet()
        {

            listViewRealEstateSet_Apartments.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            foreach (DemandSet demand in Program.wftDb.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demand.idAgent.ToString(),
                         demand.idClient.ToString(),
                         demand.MinPrice.ToString(),
                         demand.MaxPrice.ToString(),
                         demand.MinArea.ToString(),
                         demand.MaxArea .ToString(),
                         demand.MinRooms.ToString(),
                         demand.MaxRooms.ToString(),
                         demand.MinFloors.ToString(),
                         demand.MaxFloors.ToString(),
                     });
                    item.Tag = demand;
                    listViewRealEstateSet_Apartments.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         demand.idAgent.ToString(),
                         demand.idClient.ToString(),
                         demand.MinPrice.ToString(),
                         demand.MaxPrice.ToString(),
                         demand.MinArea.ToString(),
                         demand.MaxArea .ToString(),
                         demand.MinRooms.ToString(),
                         demand.MaxRooms.ToString(),
                         demand.MinFloors.ToString(),
                         demand.MaxFloors.ToString(),
                     });
                    item.Tag = demand;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else if (demand.Type == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                      {
                         demand.idAgent.ToString(),
                         demand.idClient.ToString(),
                         demand.MinPrice.ToString(),
                         demand.MaxPrice.ToString(),
                         demand.MinArea.ToString(),
                         demand.MaxArea .ToString(),
                       });
                    item.Tag = demand;
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            listViewRealEstateSet_Apartments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxAgents.SelectedItem != null &&
                comboBoxClients.SelectedItem != null &&
                comboBoxRealEstate.SelectedItem != null)

            {
                DemandSet demand = new DemandSet();
                demand.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                demand.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                if (comboBoxRealEstate.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                }
                else if (comboBoxRealEstate.SelectedIndex == 1)
                {
                    demand.Type = 1;
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMinFloors.Text);
                }
                else
                {
                    demand.Type = 2;
                }
                Program.wftDb.DemandSet.Add(demand);
                Program.wftDb.SaveChanges();
                ShowRealEstateSet();

            }

            else MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void comboBoxRealEstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRealEstate.SelectedIndex == 0)
            {
                listViewRealEstateSet_Apartments.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
            }
            else if (comboBoxRealEstate.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelMinRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                listViewRealEstateSet_Apartments.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
            }
            else
            {
                listViewRealEstateSet_Land.Visible = true;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                listViewRealEstateSet_Apartments.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxRealEstate.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartments.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Apartments.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();

                    }
                    comboBoxAgents.Text = "";
                    comboBoxClients.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = " ";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";

                }
                else if (comboBoxRealEstate.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    comboBoxAgents.Text = "";
                    comboBoxClients.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = " ";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demand);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    comboBoxAgents.Text = "";
                    comboBoxClients.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
            }
            catch
            {
                MessageBox.Show(" невозможно удалить");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxRealEstate.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartments.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Apartments.SelectedItems[0].Tag as DemandSet;
                        demand.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                        demand.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                        demand.Type = 0;
                        demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                        demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                        demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                        demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
                else if (comboBoxRealEstate.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_House.SelectedItems[0].Tag as DemandSet;
                        demand.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                        demand.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                        demand.Type = 1;
                        demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                        demand.MaxFloors = Convert.ToInt32(textBoxMinFloors.Text);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
                else
                {
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewRealEstateSet_Land.SelectedItems[0].Tag as DemandSet;
                        demand.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                        demand.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                        demand.Type = 2;
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
