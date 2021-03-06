﻿
namespace QTsys.DataObjects
{
    class Customer : QiaotaiObject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OriginalId { get; set; } 
        public string DefaultContact { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string PaymentMode { get; set; }
        public string Serial { get; set; }
        public string Remarks { get; set; }
    }
}
