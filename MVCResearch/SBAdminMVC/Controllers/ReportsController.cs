using System.Collections.Generic;
using System.Web.Mvc;
using SBAdminMVC.Helpers;
using SBAdminMVC.Models;

namespace SBAdminMVC.Controllers
{
    public class ReportsController : Controller
    {
        private readonly List<ReportModel.Anual> _list = DataSeeding.AnualReportModels;

        public JsonResult OrdersByYear()
        {
            var list = _list;

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}