using crudStoreProcedure.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudStoreProcedure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public JsonResult GetUserList()
        {

            Repository rep = new Repository();
            List<User> lstUser = new List<User>();
            lstUser = rep.QueryGetUserList();

            return Json(lstUser, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveUser(User user)
        {
            var redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "Home");
            if (ModelState.IsValid)
            {
                Repository rep = new Repository();
                try
                {
                    rep.QuerySaveUser(user);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("UserLastName", "Ha ocurrido un error al intentar guardar el usuario");
                }
            }
            return Json(new { Url = redirectUrl });
        }

        [HttpPost]
        public JsonResult UpdateUser(User user)
        {
            Repository rep = new Repository();
            rep.QueryEditUser(user);
            var redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "Home");
            return Json(new { Url = redirectUrl });
        }

        [HttpPost]
        public JsonResult DeleteUser(int UserID)
        {
            Repository rep = new Repository();
            rep.QueryDeleteUser(UserID);
            var redirectUrl = new UrlHelper(Request.RequestContext).Action("Index", "Home");
            return Json(new { Url = redirectUrl });
        }
    }
}