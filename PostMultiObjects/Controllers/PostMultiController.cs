using PostMultiObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


/// <summary>
/// See http://haacked.com/archive/2008/10/23/model-binding-to-a-list.aspx/
/// </summary>
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

        [HttpGet]
        public ActionResult UpdateProducts(ICollection<Book> books)
        {
            return this.View(books);
        }

        [HttpPost]
        public ActionResult UpdateProductsPost(ICollection<Book> books)
        {
            return this.View(books);
        }
    }
}