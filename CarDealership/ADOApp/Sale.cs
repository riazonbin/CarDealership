//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarDealership.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int Sale_Id { get; set; }
        public System.DateTime Sale_Date { get; set; }
        public int Employee_Id { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Request Request { get; set; }
    }
}
