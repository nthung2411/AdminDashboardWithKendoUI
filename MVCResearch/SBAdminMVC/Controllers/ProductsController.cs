using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SBAdminMVC.Helpers;
using SBAdminMVC.Models;

namespace SBAdminMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HttpRequest _request = System.Web.HttpContext.Current.Request;
        private readonly List<ProductModel> _list = DataSeeding.ProductModels;

        public JsonResult Read()
        {
            var skip = _request["skip"] == null ? 0 : int.Parse(_request["skip"]);
            var take = _request["take"];

            var list = _list.Skip(skip);


            if (take != null)
                list = list.Take(int.Parse(take));

            return Json(new
            {
                Data = list,
                Total = list.Count()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Update(ProductModel model)
        {
            HttpStatusCode statusCode;
            var content = string.Empty;

            var index = _list.FindIndex(p => p.ID == model.ID);
            if (index == -1)
            {
                statusCode = HttpStatusCode.NotFound;
            }
            else
            {
                statusCode = HttpStatusCode.OK;
                _list[index] = model;
            }

            return Json(new
            {
                StatusCode = statusCode.ToString(),
                Content = content,
            });
        }

        [HttpPost]
        public JsonResult Destroy(ProductModel model)
        {
            var deletedCount = _list.RemoveAll(p => p.ID == model.ID);
            var statusCode = HttpStatusCode.InternalServerError;
            string content;
            if (deletedCount > 0)
            {
                statusCode = HttpStatusCode.OK;
                content = string.Format("{0} items were deleted", deletedCount);
            }
            else
            {
                content = "Delete Item Fail";
            }

            return Json(new
            {
                StatusCode = statusCode.ToString(),
                Content = content
            });
        }

        [HttpPost]
        public JsonResult Create(ProductModel model)
        {
            model.ID = _list.Last().ID + 1;
            _list.Add(model);
            return Json(_list);
        }
    }
}