using System;
using System.ComponentModel;

namespace TestApplicationForCentralBank.Models
{
    public class FilterModel
    {
        [DisplayName("Фио")]
        public string EmployeeFio { get; set; }

        [DisplayName("Должность")]
        public string Position { get; set; }

        [DisplayName("Дата с")]
        public DateTime? DateFrom { get; set; }

        [DisplayName("Дата по")]
        public DateTime? DateTo { get; set; }

        [DisplayName("Время от")]
        public TimeSpan? TimeFrom { get; set; }

        [DisplayName("Время до")]
        public TimeSpan? TimeTo { get; set; }

        [DisplayName("Причина")]
        public string Reason { get; set; }
    }
}
