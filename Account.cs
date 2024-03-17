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
        private string phone;
        private DateTime birthday;
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
            this.phone = phone;
            this.birthday = birthday;
            this.address = address;
            this.avatar = avatar;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
    }
}
