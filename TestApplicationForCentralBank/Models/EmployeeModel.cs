using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForCentralBank.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Fio { get; set; }

        public List<SelectListItem> Employees { get; set; } 
    }
}
