//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Personel_Listeleme.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PERSONEL
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public string Position { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<System.DateTime> Hire_Date { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }

    }
}