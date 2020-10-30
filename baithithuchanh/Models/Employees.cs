using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baithithuchanh.Models
{
    public class Employees
    {
       [Key]
       public int id { get; set; }
        public string Name { get; set; }
        public string PhongBan { get; set; }
        public string Sarary { get; set; }
    }
}