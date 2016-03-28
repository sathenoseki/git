using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public void Index()
        {
            Response.Write("<h1>Hello github</h1>");
        }

        public void hello()
        {
            Response.Write("<h2>Hello</h2>");
        }
    }
}