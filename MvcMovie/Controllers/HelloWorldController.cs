using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld

        /*
        public ActionResult Index()
        {
            return View();
        }
         * */
        //
        //GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome/
        /* Primeiro exemplo da Action que não utiliza View e gera directamente a página
        public string Welcome(string name, int ID = 1)
        {

            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
         */
        public  ActionResult Welcome(string name, int numTimes= 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}