using System;
using System.Web.Mvc;

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

        //
        // ̽��
        // Get: /about/probe
        public ActionResult Probe()
        {
            return View();
        }
    }
}
