using System;
using System.Web.Mvc;

namespace YangKai.BlogEngine.Web.Mvc.Controllers
{
    public class AboutController : Controller
    {
        //
        // ���ڱ�վ
        // Get: /About
        public ActionResult Index()
        {
            return View();
        }

        //
        // Razir̽��
        // Get: /About/Probe
        public ActionResult Probe()
        {
            return View();
        }
    }
}
