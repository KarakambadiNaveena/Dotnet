//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_class
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int prodid { get; set; }
        public string prodname { get; set; }
        public int price { get; set; }
        public int customer_custid { get; set; }
    
        public virtual customer customer { get; set; }
    }
}