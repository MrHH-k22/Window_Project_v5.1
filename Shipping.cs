using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    public class Shipping
    {
        private int id;
        private int accountId;
        private string recipientName;
        private string phoneNo;
        private string address;

        public Shipping()
        {

        }
        public Shipping(int accountId, string recipientName, string phoneNo, string address)
        {
            this.accountId = accountId;
            this.recipientName = recipientName;
            this.phoneNo = phoneNo;
            this.address = address;
        }

        public string RecipientName { get => recipientName; set => recipientName = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Address { get => address; set => address = value; }
        public int AccountId { get => accountId; set => accountId = value; }
        public int Id { get => id; set => id = value; }
    }
}
