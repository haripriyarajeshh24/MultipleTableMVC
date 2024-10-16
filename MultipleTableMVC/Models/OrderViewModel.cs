using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleTableMVC.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public int OrderNumber { get; set; }
        public string PersonName { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string ProductName { get; set; }
        public virtual Product Product { get; set; }
       
    }

    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public string Category { get; set; }

        public int OrderNumber { get; set; }
        public string PersonName { get; set; }

        public int OrderID { get; set; }

    }
}