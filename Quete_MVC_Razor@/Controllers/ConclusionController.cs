using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Quete_MVC_Razor_.Controllers
{
    public class ConclusionController : Controller
    {
        public IActionResult Index()
        {
            String conclusion = String.Empty;
            IEnumerable<Int32> integers = new Int32[] { 1, 2, 3, 4 };
            Int32 sum = integers.Sum();
            if (sum > 10000000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }
            return View("Index", conclusion);
        }
    }
}
