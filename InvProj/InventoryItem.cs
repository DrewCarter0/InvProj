using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvProj
{
    class InventoryItem
    {
        private string UpcCode;
        private string description;
        private int quantityOnHand;
        private int reorderPoint;
        private int reorderQuantity;
        private int quantityOnOrder;

        public string UpcCode1 { get => UpcCode; set => UpcCode = value; }
        public string Description { get => description; set => description = value; }
        public int QuantityOnHand { get => quantityOnHand; set => quantityOnHand = value; }
        public int ReorderPoint { get => reorderPoint; set => reorderPoint = value; }
        public int ReorderQuantity { get => reorderQuantity; set => reorderQuantity = value; }
        public int QuantityOnOrder { get => quantityOnOrder; set => quantityOnOrder = value; }

        public InventoryItem()
        {
            UpcCode = "fff";
            description = "fff";
            quantityOnHand = 0;
            reorderPoint = 0;
            reorderQuantity = 0;
            quantityOnOrder = 0;
        }


    }
}
