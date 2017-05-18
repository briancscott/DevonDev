using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevonDev.Models
{
    public class DeveloperViewModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string JobTitle { get; set; }
        public bool Active { get; set; }
    }
}