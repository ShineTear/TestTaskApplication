using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using DataBaseForTestApplication.DataBase.Context;
using TestApplicationForCentralBank.Models;
using DataBaseForTestApplication.DataBase.Code;
using DataBaseForTestApplication.DataBase.Entity;

namespace TestApplicationForCentralBank.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseCode _context;

        public HomeController(ILogger<HomeController> logger, DataBaseContext context)
        {
            _logger = logger;
            _context = new DataBaseCode(context);
        }

        public IActionResult Index(FilterModel model)
        {
            _logger.LogInformation("Action Index Home");
            if (model == null)
            {
                model = new FilterModel();
            }
            if (!model.TimeFrom.HasValue)
            {
                model.TimeFrom = new TimeSpan(0);
            }
            if (!model.TimeTo.HasValue)
            {
                model.TimeTo = new TimeSpan(23, 59, 0);
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogWarning("Error!!! " + HttpContext.Request);
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult AddEmployee()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddNewEmploee(string fio)
        {
            _logger.LogInformation("Adding Employee");
            _context.AddNewEmployee(fio);
            return RedirectToAction("Index");
        }

        public ActionResult AddEmployeePosition()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AddNewPosition(string position)
        {
            _logger.LogInformation("Adding Position");
            _context.AddNewPosition(position);
            return RedirectToAction("Index");
        }

        public ActionResult AddAbsenceReport()
        {
            var result = new EmployeeAndPositionListModel()
            {
                Employees = _context.GetEmployees().Select(x =>
            new SelectListItem() { Value = x.Id.ToString(), Text = x.Fio })
                .ToList(),
                Positions = _context.GetEmployeePosition().Select(x =>
            new SelectListItem() { Value = x.Id.ToString(), Text = x.PositionName })
                .ToList()
            };
            return PartialView(result);
        }

        [HttpPost]
        public ActionResult AddNewAbsenceReport(AbsenceReportModel model)
        {
            _logger.LogInformation("Adding Abscence Report");
            _context.AddAbsenceReport(new AbsenceReportEntity()
            {
                EmployeeId = model.EmployeeId,
                EmployeePositionId = model.EmployeePositionId,
                DateAbsence = model.DateAbsence,
                TimeAbsence = model.TimeAbsence,
                Reason = model.Reason
            });
            return RedirectToAction("Index");
        }

        public ActionResult EmployeeList()
        {
            var result = _context.GetEmployees().Select(x => new EmployeeModel()
            {
                EmployeeId = x.Id,
                Fio = x.Fio
            }).ToList();
            return PartialView(result);
        }

        public ActionResult EmployeePositionList()
        {
            var result = _context.GetEmployeePosition().Select(x => new EmployeePositionModel()
            {
                Id = x.Id,
                Position = x.PositionName
            }).ToList();
            return PartialView(result);
        }
    }
}
