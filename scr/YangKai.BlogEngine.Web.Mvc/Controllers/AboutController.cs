using System;
using System.Web.Mvc;
using YangKai.BlogEngine.Web.Mvc.Filters;

namespace YangKai.BlogEngine.Web.Mvc.Controllers
{
    public class AboutController : Controller
    {
        //
        // ���ڱ�վ
        // Get: /about
        public ActionResult Index()
        {
            return View();
        }

    }
}
