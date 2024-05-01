using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    public class Voucher
    {
        private int voucherId;
        private int sellerId;
        private string name;
        private double value;
        private DateTime beginday;
        private DateTime endday;

        public Voucher() { }
        public Voucher(int sellerId, string name, double value, DateTime beginday, DateTime endday)
        {
            this.sellerId = sellerId;
            this.name = name;
            this.value = value;
            this.beginday = beginday;
            this.endday = endday;
        }

        public int SellerId { get => sellerId; set => sellerId = value; }
        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
        public DateTime Beginday { get => beginday; set => beginday = value; }
        public DateTime Endday { get => endday; set => endday = value; }
        public int VoucherId { get => voucherId; set => voucherId = value; }
    }
}
