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
    public partial class InvMgmt : Form
    {
        private InventoryItem invItem;

        public InvMgmt()
        {
            InitializeComponent();

            invItem = new InventoryItem();
        }

        private void ClearScreen()
        {
            textUPC.Clear();
            textDesc.Clear();
            textQTYoH.Clear();
            textReorderPt.Clear();
            textQtyoOrder.Clear();
            textReorderQty.Clear();
            textVendor.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            textUPC.Text = invItem.UpcCode1;
            textDesc.Text = invItem.Description;
            textQTYoH.Text = invItem.QuantityOnHand.ToString();
            textReorderPt.Text = invItem.ReorderPoint.ToString();
            textQtyoOrder.Text = invItem.QuantityOnOrder.ToString();
            textReorderQty.Text = invItem.ReorderQuantity.ToString();
            //textVendor.Text = vend.VendorID;
        }

        private void buttonVendOpen_Click(object sender, EventArgs e)
        {
            VendorForm vendform = new VendorForm(invItem);
            vendform.Show();
        }
    }
}
