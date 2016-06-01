using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Reflexif.WebDemo.Controllers {
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

        public ActionResult Render(string filename, int width = 200, int height = 200) {
            using (var bitmap = new Bitmap(Path.Combine(Server.MapPath("~/App_Data/"), filename))) {
                var text = "© " + DateTime.Now.Year + " " + bitmap.ReadExifTag(ExifTags.Copyright);
                var result = RenderImage(bitmap, width, height, text);
                using (var ms = new MemoryStream()) {
                    result.Save(ms, ImageFormat.Jpeg);
                    Response.ContentType = "image/jpeg";
                    ms.WriteTo(Response.OutputStream);
                }
            }
            return (null);
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

        public Bitmap RenderImage(Bitmap sourceBitmap, int width, int height, string text) {
            int x = 0, y = 0;
            double scaleFactor = Math.Min(((double)width) / sourceBitmap.Width, ((double)height) / (sourceBitmap.Height));
            var targetWidth = Convert.ToInt32(sourceBitmap.Width * scaleFactor);
            var targetHeight = Convert.ToInt32(sourceBitmap.Height * scaleFactor);
            // Do NOT wrap this canvas in a using block otherwise it'll be disposed before the calling method can use it.
            var canvas = new Bitmap(targetWidth, targetHeight);
            try {
                using (var g = Graphics.FromImage(canvas)) {
                    g.Clear(Color.Black);
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighSpeed;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(sourceBitmap, x - 1, y - 1, targetWidth + 2, targetHeight + 2);
                    if (targetHeight > 200) {
                        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                        g.TranslateTransform(0, targetHeight);
                        g.RotateTransform(-90);
                        using (var brush = new SolidBrush(Color.FromArgb(128, 0, 0, 0))) {
                            g.FillRectangle(brush, -1, targetWidth - 16, targetHeight + 1, 16);
                        }
                        using (var brush = new SolidBrush(Color.White)) {
                            using (var font = new Font("Arial", 8, FontStyle.Regular)) {
                                g.DrawString(text, font, brush, 1, targetWidth - 14);
                                if (targetHeight > 300) g.DrawString("www.spotlight.com", font, brush, targetHeight - 98, targetWidth - 14);
                            }
                        }
                        g.ResetTransform();
                    }
                }
            } catch (Exception) {
                canvas.Dispose();
                throw;
            }
            return (canvas);
        }
    }
}