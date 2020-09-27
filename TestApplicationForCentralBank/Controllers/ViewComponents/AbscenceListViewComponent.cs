using DataBaseForTestApplication.DataBase.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplicationForCentralBank.Models;

namespace TestApplicationForCentralBank.Controllers.ViewComponents
{
    public class AbscenceListViewComponent : ViewComponent
    {
        private readonly DataBaseContext _context;

        public AbscenceListViewComponent(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(
        FilterModel model)
        {
            var items = await GetItemsAsync(model);
            return View(items);
        }
        private Task<List<AbsenceReportModel>> GetItemsAsync(FilterModel filter)
        {
            var result = _context.AbsenceReports.Select(x => new AbsenceReportModel
            {
                DateAbsence = x.DateAbsence,
                Employee = x.Employee.Fio,
                EmployeePosition = x.EmployeePosition.PositionName,
                Reason = x.Reason,
                TimeAbsence = x.TimeAbsence
            });
            if (filter != null)
            {
                if (filter.DateFrom.HasValue)
                {
                    result = result.Where(x => x.DateAbsence >= filter.DateFrom);
                }
                if (filter.DateTo.HasValue)
                {
                    result = result.Where(x => x.DateAbsence <= filter.DateTo);
                }
                if (filter.TimeFrom.HasValue)
                {
                    result = result.Where(x => x.TimeAbsence >= filter.TimeFrom);
                }
                if (filter.TimeTo.HasValue)
                {
                    result = result.Where(x => x.TimeAbsence <= filter.TimeTo);
                }
                if (!string.IsNullOrEmpty(filter.EmployeeFio))
                {
                    result = result.Where(x => x.Employee.Contains(filter.EmployeeFio));
                }
                if (!string.IsNullOrEmpty(filter.Position))
                {
                    result = result.Where(x => x.EmployeePosition.Contains(filter.Position));
                }
                if (!string.IsNullOrEmpty(filter.Reason))
                {
                    result = result.Where(x => x.Reason.Contains(filter.Reason));
                }
            }
            return result.ToListAsync();
        }
    }
}
