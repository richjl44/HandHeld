//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMS_COST_CENTER_PRODUCTS
    {
        public int ORIGREC { get; set; }
        public string ORIGSTS { get; set; }
        public Nullable<int> MINITEMLEVEL { get; set; }
        public Nullable<int> MAXITEMLEVEL { get; set; }
        public int COSTCENTERID { get; set; }
        public int PRODUCTID { get; set; }
        public string IS_STOCK_CONTROLLED { get; set; }
        public string MAKE_ORDER_SUGGESTIONS { get; set; }
        public Nullable<int> ALT_ORDERPRODUCTID { get; set; }
        public Nullable<int> CONSUMPTIONUNITS { get; set; }
        public string QUARANTINEMETHOD { get; set; }
        public string QUATANTINELOCATIONCODE { get; set; }
    
        public virtual IMS_COST_CENTERS IMS_COST_CENTERS { get; set; }
        public virtual IMS_PRODUCTS IMS_PRODUCTS { get; set; }
        public virtual IMS_PRODUCTS IMS_PRODUCTS1 { get; set; }
    }
}