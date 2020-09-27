using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplicationForCentralBank.Models
{
    public class AbsenceReportModel
    {
        [DisplayName("ИД сотрудника")]
        public int EmployeeId { get; set; }

        [DisplayName("ФИО сотрудника")]
        public string Employee { get; set; }

        [DisplayName("ИД Должности")]
        public int EmployeePositionId { get; set; }

        [DisplayName("Должность")]
        public string EmployeePosition { get; set; }

        [DisplayName("Дата отсутствия")]
        public DateTime DateAbsence { get; set; }

        [DisplayName("Время отсутствия")]
        public TimeSpan TimeAbsence { get; set; }

        [DisplayName("Причина")]
        public string Reason { get; set; }
    }
}
