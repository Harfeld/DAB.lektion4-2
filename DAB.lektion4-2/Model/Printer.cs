using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Printer
    {
        public int id { get; set; }
        public string color { get; set; }
        public string type { get; set; }
        public double price { get; set; }

        public int productID { get; set; }
        public Product Product { get; set; }

    }
}
