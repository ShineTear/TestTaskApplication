using DataBaseForTestApplication.DataBase.Context;
using DataBaseForTestApplication.DataBase.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseForTestApplication.DataBase.Code
{
    public class DataBaseCode
    {
        private DataBaseContext _context;
        private ILogger _logger;
        public DataBaseCode(DataBaseContext context)
        {
            _context = context;
            _logger = new Logger<DataBaseCode>(new LoggerFactory());
        }

        public void AddNewEmployee(string fio)
        {
            _context.Employes.Add(new EmployeeEntity() { Fio = fio });
            _context.SaveChanges();
            _logger.LogInformation("Employee is adding");
        }

        public void AddNewPosition(string position)
        {
            _context.Positions.Add(new EmployeePositionEntity() { PositionName = position });
            _context.SaveChanges();
            _logger.LogInformation("Position is adding");
        }

       public List<EmployeeEntity> GetEmployees()
        {
            return _context.Employes.ToList();
        }

        public List<EmployeePositionEntity> GetEmployeePosition()
        {
            return _context.Positions.ToList();
        }

        public void AddAbsenceReport(AbsenceReportEntity newAbsenceReport)
        {
            _context.AbsenceReports.Add(newAbsenceReport);
            _context.SaveChanges();
            _logger.LogInformation("Abscence Report is adding");
        }
    }
}
