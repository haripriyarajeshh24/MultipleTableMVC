//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultipleTableMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int OrderNumber { get; set; }
        public string PersonName { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
