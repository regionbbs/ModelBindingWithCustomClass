using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomClassModelBinding.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
    }
}