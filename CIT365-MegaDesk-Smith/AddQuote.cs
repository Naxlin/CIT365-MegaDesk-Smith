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

            // cmbMaterialTypes.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            cmbMaterialTypes.DataSource = materials;
            cmbMaterialTypes.SelectedIndex = -1;

            List<RushShipping> shipping = Enum.GetValues(typeof(RushShipping)).Cast<RushShipping>().ToList();
            cmbShippingType.DataSource = shipping;
            cmbShippingType.SelectedIndex = -1;
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
