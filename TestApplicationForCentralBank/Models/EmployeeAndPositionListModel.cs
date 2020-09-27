using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForCentralBank.Models
{
    public class EmployeeAndPositionListModel
    {
        public int EmployeeId { get; set; }

        public List<SelectListItem> Employees { get; set; }
        public int EmployeePositionId { get; set; }

        public List<SelectListItem> Positions { get; set; }
    }
}
