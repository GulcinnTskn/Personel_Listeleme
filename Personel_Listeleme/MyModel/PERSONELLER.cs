using System;
using System.Collections.Generic;

namespace Personel_Listeleme.MyModel
{
    public class PERSONELLER
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> Hire_Date { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
    }
}