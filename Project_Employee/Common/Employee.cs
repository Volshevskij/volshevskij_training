using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Common
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
        public string DepPhone { get; set; }
        public string DepAdress { get; set; }
        public string DepDescription { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public byte[] Photo { get; set; }
        public string WorkPeriod { get; set; }
        public string MaritalStatus { get; set; }

        public string PhotoUrl { get; set; }
    }
}