using Microsoft.AspNetCore.Mvc;

namespace class7.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult student(int org, int name, int batchno)
        {
            try
            {
                ViewBag.or = "organization name " + org.ToString();
                ViewBag.na = "student name " + name.ToString();
                ViewBag.batc = "student batch" + batchno.ToString();
                ViewBag.err = false;
                return View();

            }
            catch
            {
                ViewBag.err = true;
                ViewBag.msg = "please valid info again";
                return View();
            }
         }   


    }
}
