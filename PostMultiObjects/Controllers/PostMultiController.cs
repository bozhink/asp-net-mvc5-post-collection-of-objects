using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostMultiObjects.Controllers
{
    public class PostMultiController : Controller
    {
        // GET: PostMulti
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult UpdateInts()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult UpdateIntsPost(ICollection<int> ints)
        {
            return this.View(ints);
        }
    }
}