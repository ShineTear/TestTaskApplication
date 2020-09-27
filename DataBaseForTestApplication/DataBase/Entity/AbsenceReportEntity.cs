using System;

namespace DataBaseForTestApplication.DataBase.Entity
{
    public class AbsenceReportEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeEntity Employee { get; set; }
        public int EmployeePositionId { get; set; }
        public EmployeePositionEntity EmployeePosition { get; set; }
        public DateTime DateAbsence { get; set; }
        public TimeSpan TimeAbsence { get; set; }
        public string Reason { get; set; }
    }
}
