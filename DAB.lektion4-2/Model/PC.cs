using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class PC
    {
        public int id { get; set; }
        public int speed { get; set; }
        public int ram { get; set; }
        public int hd { get; set; }
        public double price { get; set; }

        public int productID { get; set; }
        public Product Product { get; set; }
    }
}
