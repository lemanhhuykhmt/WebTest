﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanMyPham.Common;

namespace WebBanMyPham.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            AccountLogin accSession = Session["AccountSession"] as AccountLogin;
            if(accSession == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    System.Web.Routing.RouteValueDictionary(new { controller = "Login", action = "Index", area = "Admin" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}