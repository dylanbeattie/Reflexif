using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
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
                bitmap.SetExifTag(ExifTags.XPTitle, title);
                bitmap.SetExifTag(ExifTags.ImageDescription, title);
                bitmap.SetExifTag(ExifTags.XPAuthor, copyright);
                bitmap.SetExifTag(ExifTags.Copyright, copyright);
                var guid = DateTime.Now.Ticks.ToString("X");
                // var guid = Guid.NewGuid();
                bitmap.Save(Path.Combine(Server.MapPath("~/App_Data/"), guid + ".jpg"), ImageFormat.Jpeg);
                return (RedirectToAction("Index"));
            }
        }

        public ActionResult Details(string filename) {
            Dictionary<string, string> data = new Dictionary<String, String>();
            using (var bitmap = new Bitmap(Path.Combine(Server.MapPath("~/App_Data/"), filename))) {
                foreach (ExifTags tag in Enum.GetValues(typeof(ExifTags))) {
                    try {
                        var key = Enum.GetName(typeof(ExifTags), tag);
                        var value = Encoding.UTF8.GetString(bitmap.GetPropertyItem((int)tag).Value);
                        data.Add(key, value);
                    } catch (Exception) { }
                }
            }
            return (View(data));
        }
    }
}