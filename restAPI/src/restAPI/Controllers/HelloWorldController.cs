using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public IActionResult Index()
        {
            //return View("../HelloWorld/Index2");
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public string Puppies()
        {
            return Puppies.GetAll();
        }
    }
}