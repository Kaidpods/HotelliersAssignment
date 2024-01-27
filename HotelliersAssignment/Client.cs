using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoteliersAssignment
{
    public class Client
    {
        private string PrefCustID;
        private string Name;
        private string PhoneNumber;
        private Address Address;
        public Client(string PrefCustId, string Name, string PhoneNumber, Address Address)
        {
            this.PrefCustID = PrefCustId;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public override String ToString()
        {
            string tempAddress = this.Address.ToString();

                string test = (PrefCustID + ", " + Name + ", " + PhoneNumber + ", " + tempAddress);
                MessageBox.Show(test);
                return test;
            
        }
    }
}
