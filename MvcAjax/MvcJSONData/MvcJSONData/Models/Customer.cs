﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcJSONData.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
