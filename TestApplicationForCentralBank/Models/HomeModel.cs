using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForCentralBank.Models
{
    public class HomeModel
    {
        public List<EmployeeModel> Fio { get; set; }
        public List<EmployeePositionModel> Position { get; set; }
        public List<AbsenceReportModel> AbsenceReport {get; set;}
    }
}
