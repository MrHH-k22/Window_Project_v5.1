using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Window_Project_v5._1.Forms;

namespace Window_Project_v5._1
{
    public class Account
    {
        private AccountDAO accountDAO = new AccountDAO();
        private RatingDAO ratingDAO = new RatingDAO();
        private int id;
        private string email;
        private string password;
        private string name;
        private string phone;
        private DateTime birthday;
        private string address;
        private double money;
        private byte[] avatar;
        private List<Rating> ratingList = new List<Rating>(); 
        private List<int> cancelledList = new List<int>();
        private List<int> savedList = new List<int>();
        private List<int> cartList = new List<int>();
        private float avgRating;

        public Account()
        {
        }

        public Account(int id)
        {
            Account acc = accountDAO.Retrieve(id);
            if (acc != null)
            {
                PropertyInfo[] properties = typeof(Account).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    PropertyInfo thisProperty = typeof(Account).GetProperty(property.Name);
                    object value = property.GetValue(acc);
                    thisProperty.SetValue(this, value);
                }
                ratingList = ratingDAO.LoadList(acc);
                avgRating = AverageStar();
            }
        }

        public Account(int id, string email, string password, string name, string phone, DateTime birthday, string address, double money, byte[] avatar, List<int> cancelledList)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.phone = phone;
            this.birthday = birthday;
            this.address = address;
            this.money = money; 
            this.avatar = avatar;
            this.cancelledList = cancelledList;
            //this.savedList = savedList;
            //this.cartList = cartList;

        }

        public Account( string email, string password, string name, string phone, DateTime birthday, string address, byte[] avatar)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.phone = phone;
            this.birthday = birthday;
            this.address = address;
            this.avatar = avatar;
        }
        public Account(string username, string email, string password)
        {
            this.name = username;
            this.email = email;
            this.password = password;
            money = 0;
        }
        public Account(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public float AverageStar()
        {
            float avg = 0;
            if(this.ratingList.Count  > 0)
            {
                foreach (Rating rt in this.ratingList)
                {
                    avg += rt.Star;
                }
                float rs = avg / (float)this.ratingList.Count;
                rs = rs % 1 > 0.5f ? ((int)rs + 0.5f) : rs;
                avgRating = rs;
                return rs;
            }
            return 0;  
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }
        public byte[] Avatar { get => avatar; set => avatar = value; }
        public double Money { get => money; set => money = value; }
        public List<int> CancelledList { get => cancelledList; set => cancelledList = value; }
        public List<int> SavedList { get => savedList; set => savedList = value; }
        public List<int> CartList { get => cartList; set => cartList = value; }
        public List<Rating> RatingList { get => ratingList; set => ratingList = value; }
        public float AvgRating { get => avgRating; set => avgRating = value; }
    }
}
