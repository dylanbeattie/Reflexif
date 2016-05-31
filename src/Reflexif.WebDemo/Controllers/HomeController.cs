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
    public class Metadata {
        public string Filename { get; set; }
        public string Title { get; set; }
        public string Copyright { get; set; }
        public string Subject { get; set; }
        public string Keywords { get; set; }
    }
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            var files = Directory
                .GetFiles(Server.MapPath("~/App_Data/"), "*.jpg")
                .Select(Path.GetFileName)
                .Where(f => !f.StartsWith("$"));
            return View(files);
        }

        public ActionResult Upload(HttpPostedFileBase file) {
            var metadata = new Metadata();
            using (var bitmap = new Bitmap(file.InputStream)) {
                metadata.Title = bitmap.ReadExifTag(ExifTags.XPTitle, ExifTags.ImageDescription);
                metadata.Keywords = bitmap.ReadExifTag(ExifTags.XPKeywords);
                metadata.Subject = bitmap.ReadExifTag(ExifTags.XPSubject);
                metadata.Copyright = bitmap.ReadExifTag(ExifTags.Copyright);
                metadata.Filename = DateTime.Now.Ticks.ToString("X");
                // var guid = Guid.NewGuid();
                bitmap.Save(Path.Combine(Server.MapPath("~/App_Data/"), "$" + metadata.Filename + ".jpg"), ImageFormat.Jpeg);
            }
            return (Json(metadata));
        }

        public ActionResult Update(string filename, string title, string subject, string keywords, string copyright) {
            using (var bitmap = new Bitmap(Path.Combine(Server.MapPath("~/App_Data/"), "$" + filename + ".jpg"))) {
                bitmap.SetExifTag(ExifTags.XPTitle, title);
                 bitmap.SetExifTag(ExifTags.ImageDescription, title);
                bitmap.SetExifTag(ExifTags.Copyright, copyright);
                //bitmap.SetExifTag(ExifTags.XPSubject, subject);
                //bitmap.SetExifTag(ExifTags.XPKeywords, keywords);
                bitmap.Save(Path.Combine(Server.MapPath("~/App_Data/"), filename + ".jpg"), ImageFormat.Jpeg);
            }
            return (RedirectToAction("Index"));
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