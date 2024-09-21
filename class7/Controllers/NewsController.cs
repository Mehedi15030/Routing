using Microsoft.AspNetCore.Mvc;

namespace class7.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult articale(int year,int month, int day, int pageno, int contentid)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);
                ViewBag.date = "date show :" + dt.ToString(" MMMM dd yyyy");
                ViewBag.page = "pageno :" + pageno.ToString();
                ViewBag.content = "content show " + contentid.ToString();
                ViewBag.err = false;
                return View();
            }
            catch 
            {
                ViewBag.err = true;
                ViewBag.msg = "please valid date again";
                return View();

            }
        }
        public IActionResult page(int year, int month, int day, int pageno)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);
                ViewBag.date = "date show :" + dt.ToString(" MMMM dd yyyy");
                ViewBag.page = "pageno :" + pageno.ToString();
              
                ViewBag.err = false;
                return View();
            }
            catch
            {
                ViewBag.err = true;
                ViewBag.msg = "please valid date again";
                return View();

            }
        }
    }
}
