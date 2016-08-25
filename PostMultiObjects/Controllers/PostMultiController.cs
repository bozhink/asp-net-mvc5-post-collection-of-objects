/// <summary>
/// See http://haacked.com/archive/2008/10/23/model-binding-to-a-list.aspx/
/// </summary>
namespace PostMultiObjects.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Models;

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
        public ActionResult UpdateProducts()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult UpdateProductsPost(ICollection<Book> books)
        {
            return this.View(books);
        }

        [HttpGet]
        public ActionResult UpdateLibrary()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult UpdateLibraryPost(Library library)
        {
            return this.View(library);
        }
    }
}
