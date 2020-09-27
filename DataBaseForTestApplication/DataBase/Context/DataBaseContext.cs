using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using DataBaseForTestApplication.DataBase.Entity;

namespace DataBaseForTestApplication.DataBase.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            if (!Database.CanConnect())
            {
                CreateTestDatabase();
            }
        }

        private void CreateTestDatabase()
        {
            Database.EnsureCreated();
            Positions.AddRange(new List<EmployeePositionEntity>() {
                new EmployeePositionEntity(){PositionName = "Бухгалтер"},
                new EmployeePositionEntity(){PositionName = "Программист"},
                new EmployeePositionEntity(){PositionName = "Инженер"}
                });
            this.SaveChanges();
            Employes.AddRange(new List<EmployeeEntity>()
            {
                new EmployeeEntity(){Fio = "Иванов Иван Иванович"},
                new EmployeeEntity(){Fio = "Петров Павел Сергеевич"},
                new EmployeeEntity(){Fio = "Павлова Татьяна Викторовна"},
                new EmployeeEntity(){Fio = "Иванова Мария Владимировна"}
            });
            this.SaveChanges();
            AbsenceReports.Add(new AbsenceReportEntity()
            {
                EmployeeId = Employes.First().Id,
                EmployeePositionId = Positions.First().Id,
                DateAbsence = new DateTime(2020, 06, 15),
                TimeAbsence = new TimeSpan(2, 0, 0),
                Reason = "Поход в банк"
            });
            this.SaveChanges();
        }

        public DbSet<EmployeeEntity> Employes { get; set; }
        public DbSet<EmployeePositionEntity> Positions { get; set; }
        public DbSet<AbsenceReportEntity> AbsenceReports { get; set; }
    }
}
