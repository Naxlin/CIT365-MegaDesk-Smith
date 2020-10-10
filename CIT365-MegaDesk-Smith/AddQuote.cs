using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT365_MegaDesk_Smith
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            // Dynamically assigning ComboBox (drop down) options:
            // cmbMaterialTypes.DataSource = Enum.GetValues(typeof(DesktopMaterial)); // Possible short way
            // Materials:
            List<DesktopMaterial> materials;
            try
            {
                materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
                cmbMaterialTypes.DataSource = materials;
                cmbMaterialTypes.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error casting value to DesktopMaterial at materials variable");
            }
            // Shipping Options:
            List<RushShipping> shipping = Enum.GetValues(typeof(RushShipping)).Cast<RushShipping>().ToList();
            cmbShippingType.DataSource = shipping;
            cmbShippingType.SelectedIndex = -1;

            // Dynamically assigning NumericUpDown range limits:
            nudWidth.Maximum = Desk.MAX_WIDTH;
            nudWidth.Minimum = Desk.MIN_WIDTH;
            nudDepth.Maximum = Desk.MAX_DEPTH;
            nudDepth.Minimum = Desk.MIN_DEPTH;
            nudDrawers.Maximum = Desk.MAX_DRAWERS;
            nudDrawers.Minimum = Desk.MIN_DRAWERS;
            // Initializing defaults:
            nudWidth.Text = "";
            nudDepth.Text = "";
            nudDrawers.Text = "";
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form mainMenu = (Form)this.Tag;
            mainMenu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
