using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // Public methods inside controllers are called Action
        public string Test()
        {
            return DateTime.Now.ToString();
        }

        // localhost/Helloworld/foo?name=Souriya
        //public string Foo(string name)
        //{
        //    return "Hello "+name;
        //}

        // localhost/helloworld/foo?name1=Souriya&name2=Roy
        public string Foo(string name1, string name2)
        {
            return "Hello " + name1 + ":" + name2;
        }

        // localhost/HelloWorld/bar/12
        public string Bar(int id)
        {
            return id.ToString();
        }

        public string Shows(string id)
        {
            return id;
        }

        public ActionResult Display1()
        {
            return View(); //html+css
        }

        public ActionResult Display2()
        {
            var emp = new { id = 10, name = "Souriya", city = "Pune" };
            return Json(emp, JsonRequestBehavior.AllowGet); //json format
        }
    }
}