using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1281647.Models
{
    public class Company: EntityBase
    {
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
