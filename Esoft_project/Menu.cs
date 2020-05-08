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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form Menu = new FormClient();
            Menu.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenAgents_Click(object sender, EventArgs e)
        {
            Form formAgents = new FormAgents();
            formAgents.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formDemands = new Demands();
            formDemands.Show();
        }
     
       

        private void buttonOpenSupplies_Click_1(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
        }
    }
    
    }

