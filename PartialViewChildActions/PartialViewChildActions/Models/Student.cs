using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewChildActions.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mpbile { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string Street { get; set; }
    }
}