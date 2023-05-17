using MuMerch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Cus_Auth
{
    public class AdminAccess : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var user = httpContext.Session["UserType"];
            if (user.Equals("Admin")) return true;
            httpContext.Response.StatusCode = 401;
            httpContext.Response.Redirect("/Home/Login");
            return false;
        }
    }
}