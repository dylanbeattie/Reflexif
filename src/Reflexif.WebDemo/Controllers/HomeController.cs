using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reflexif.WebDemo.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            var files = Directory.GetFiles(Server.MapPath("~/App_Data/"), "*.jpg").Select(Path.GetFileName);
            return View(files);
        }

        public ActionResult Upload(HttpPostedFileBase file, string title, string copyright) {
            using (var bitmap = new Bitmap(file.InputStream)) {
                var guid = Guid.NewGuid();
                bitmap.Save(Path.Combine(Server.MapPath("~/App_Data/"), guid + ".jpg"), ImageFormat.Jpeg);
                return (RedirectToAction("Index"));
            }
        }
    }
}