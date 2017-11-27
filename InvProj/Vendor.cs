using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Vendor
    {
        private string vendorID;
        private string companyName;
        private string agentName;
        private string phoneNumber;

        public string VendorID { get => vendorID; set => vendorID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string AgentName { get => agentName; set => agentName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Vendor()
        {
            vendorID = "fdsa";
            companyName = "asdf";
            agentName = "steve";
            phoneNumber = "111-123-4567";
        }
    }
}
