using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    public class Rating
    {
        private string comment;
        private float star;
        public Rating() { }
        public Rating(string comment, float star)
        {
            this.comment = comment;
            this.star = star;
        }
        public string Comment { get =>  comment; set => comment = value; }
        public float Star { get => star; set => star = value; }
    }
}
