//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvisionAGreenLife.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class clothes_dryer
    {
        public int Clothes_Dryer_Id { get; set; }
        public string ApplStandard { get; set; }
        public string Brand { get; set; }
        public Nullable<decimal> Cap { get; set; }
        public string Combination { get; set; }
        public string Control { get; set; }
        public string Country { get; set; }
        public Nullable<decimal> Depth { get; set; }
        public Nullable<decimal> Height { get; set; }
        public string Model_No { get; set; }
        public string Family_Name { get; set; }
        public string N_Standard { get; set; }
        public Nullable<int> New_CEC { get; set; }
        public Nullable<decimal> New_SRI { get; set; }
        public Nullable<decimal> New_Star { get; set; }
        public string Prog_Name { get; set; }
        public Nullable<decimal> Prog_Time { get; set; }
        public string Sold_in { get; set; }
        public string SubmitStatus { get; set; }
        public Nullable<int> Submit_ID { get; set; }
        public Nullable<decimal> Test_Moist_Remove { get; set; }
        public Nullable<decimal> Tot_Wat_Cons { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<System.DateTime> ExpDate { get; set; }
        public Nullable<int> GrandDate { get; set; }
        public string Product_Class { get; set; }
        public string Availability_Status { get; set; }
        public string Product_Website { get; set; }
        public string Representative_Brand_URL { get; set; }
        public Nullable<int> Star_Rating_old { get; set; }
        public string Star_Image_Large { get; set; }
        public string Star_Image_Small { get; set; }
        public Nullable<int> Type_Id { get; set; }
    
        public virtual appliance_types appliance_types { get; set; }
    }
}