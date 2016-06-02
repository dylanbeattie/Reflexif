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
using System.Text.RegularExpressions;
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

        public ActionResult CleanUp() {
            var files = Directory
                .GetFiles(Server.MapPath("~/App_Data/"), "*.jpg");
            foreach (var file in files) {
                try {
                    System.IO.File.Delete(file);
                } catch (Exception) {
                    //ignore
                }
            }
            return (RedirectToAction("Index"));
        }

        public ActionResult Upload(HttpPostedFileBase file) {
            var metadata = new Metadata();
            using (var bitmap = new Bitmap(file.InputStream)) {
                metadata.Title = bitmap.ReadExifTag(ExifTags.Image_XPTitle, ExifTags.Image_ImageDescription);
                metadata.Keywords = bitmap.ReadExifTag(ExifTags.Image_XPKeywords);
                metadata.Subject = bitmap.ReadExifTag(ExifTags.Image_XPSubject);
                metadata.Copyright = bitmap.ReadExifTag(ExifTags.Image_Copyright, ExifTags.Image_XPAuthor, ExifTags.Image_Artist);
                metadata.Authors = bitmap.ReadExifTag(ExifTags.Image_XPAuthor, ExifTags.Image_Artist);
                metadata.CameraMake = bitmap.ReadExifTag(ExifTags.Image_Make);
                metadata.CameraModel = bitmap.ReadExifTag(ExifTags.Image_Model);
                String filename;
                try {
                    filename = Regex.Replace(file.FileName.ToLowerInvariant().Split('.')[0], "[^a-z0-9]+", "-");
                } catch (Exception) {
                    filename = Guid.NewGuid().ToString();
                }
                metadata.Filename = filename;
                // var guid = Guid.NewGuid();
                bitmap.Save(Path.Combine(Server.MapPath("~/App_Data/"), "$" + metadata.Filename + ".jpg"), ImageFormat.Jpeg);
            }
            return (Json(metadata));
        }

        public ActionResult Update(string filename, string title, string subject, string keywords, string copyright) {
            using (var bitmap = new Bitmap(Path.Combine(Server.MapPath("~/App_Data/"), "$" + filename + ".jpg"))) {
                bitmap.SetExifTag(ExifTags.Image_XPTitle, title);
                bitmap.SetExifTag(ExifTags.Image_ImageDescription, title);
                bitmap.SetExifTag(ExifTags.Image_Copyright, copyright);
                //bitmap.SetExifTag(ExifTags.XPSubject, subject);
                //bitmap.SetExifTag(ExifTags.XPKeywords, keywords);
                bitmap.Save(Path.Combine(Server.MapPath("~/App_Data/"), filename + ".jpg"), ImageFormat.Jpeg);
            }
            return (RedirectToAction("Index"));
        }

        public ActionResult Render(string filename, int width = 200, int height = 200) {
            using (var bitmap = new Bitmap(Path.Combine(Server.MapPath("~/App_Data/"), filename))) {
                var text = "© " + DateTime.Now.Year + " " + bitmap.ReadExifTag(ExifTags.Image_Copyright);
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
                                if (targetHeight > 300) g.DrawString("reflexif.azurewebsites.net", font, brush, targetHeight - 118, targetWidth - 14);
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