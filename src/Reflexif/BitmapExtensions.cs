using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
// ReSharper disable InconsistentNaming

namespace Reflexif {
    public static class BitmapExtensions {
        private static Encoding GetEncoding(ExifTags tag) {
            switch (tag) {
                case ExifTags.XPAuthor:
                case ExifTags.XPTitle:
                case ExifTags.XPKeywords:
                case ExifTags.XPComment:
                case ExifTags.XPSubject:
                    return (Encoding.Unicode);
                default:
                    return (Encoding.UTF8);
            }
        }
        public static string ReadExifTag(this Bitmap bitmap, params ExifTags[] tags) {
            foreach (var tag in tags) {
                try {
                    var encoding = GetEncoding(tag);
                    return encoding.GetString(bitmap.GetPropertyItem((int)tag).Value).TrimEnd('\0');
                } catch (Exception) {
                    // ignored
                }
            }
            return (null);
        }
        public static void SetExifTag(this Bitmap bitmap, ExifTags tag, string value) {
            var t = typeof(PropertyItem);
            var types = new Type[0];
            var values = new object[0];
            var ci = t.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, types, null);
            var pi = (PropertyItem)ci.Invoke(values);
            pi.Id = (int)tag;
            pi.Type = 2;
            var encoding = GetEncoding(tag);
            var bytes = encoding.GetBytes(value + "\0");
            pi.Value = bytes;
            pi.Len = bytes.Length - 1;
            bitmap.SetPropertyItem(pi);
        }
        //public static void SetCopyrightExifData(this Bitmap bitmap, string copyright) {
        //    SetExifTag(bitmap, ExifTags.Copyright, copyright);
        //}

        //public static void SetArtistExifData(this Bitmap bitmap, string artist) {
        //    SetExifTag(bitmap, ExifTags.Artist, artist);
        //}
        //public static void SetTitleExifData(this Bitmap bitmap, string title) {
        //    SetExifTag(bitmap, ExifTags.Title, title);
        //}
    }
}
