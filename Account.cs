using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class Account
    {
        private int id;
        private string email;
        private string password;
        private string name;
        private string Phone;
        private DateTime Birthday;
        private string address;
        private byte[] avatar;

        public Account()
        {
        }

        public Account(int id, string email, string password, string name, string phone, DateTime birthday, string address, byte[] avatar)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            Phone = phone;
            Birthday = birthday;
            this.address = address;
            this.avatar = avatar;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public DateTime Birthday1 { get => Birthday; set => Birthday = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
