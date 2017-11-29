using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProj
{
    public partial class VendorForm : Form
    {
        private Vendor vend;
        private InventoryItem invItem;

        public VendorForm()
        {
            InitializeComponent();

            vend = new Vendor();
        }

        public VendorForm(InventoryItem invItem)
        {
            this.invItem = invItem;
        }

        private void ClearScreen()
        {
            textVendor.Clear();
            textAgtName.Clear();
            textCoName.Clear();
            textPhone.Clear();

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            textVendor.Text = vend.VendorID;
            textAgtName.Text = vend.AgentName;
            textCoName.Text = vend.CompanyName;
            textPhone.Text = vend.PhoneNumber;
        }
    }
}
