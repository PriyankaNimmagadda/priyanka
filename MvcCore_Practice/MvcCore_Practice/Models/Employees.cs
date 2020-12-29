using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore_Practice.Models
{
    [Table ("Employees")]
    public class Employees
    {
        [Key]
        public  int empId { get; set; }
        public string empFirstName { get; set; }
        public string empLastName { get; set; }
    }
}
