using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class Product
    {
        private int id;
        private string name;
        private double originalPrice;
        private double salePrice;
        private string condition;
        private string status;
        private List<byte[]> images;

        public Product()
        {
        }

        public Product(int id, string name, double originalPrice, double salePrice, string condition, string status, List<byte[]> images)
        {
            this.id = id;
            this.name = name;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.condition = condition;
            this.status = status;
            this.images = images;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Status { get => status; set => status = value; }
        public List<byte[]> Images { get => images; set => images = value; }
    }




}
