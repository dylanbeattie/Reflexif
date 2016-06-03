using System;
using System.Collections.Generic;
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
                case ExifTags.Image_XPAuthor:
                case ExifTags.Image_XPTitle:
                case ExifTags.Image_XPKeywords:
                case ExifTags.Image_XPComment:
                case ExifTags.Image_XPSubject:
                    return (Encoding.Unicode);
                default:
                    return (Encoding.UTF8);
            }
        }

        private static byte[] ToBytes(ExifTags tag, string value) {
            var encoding = GetEncoding(tag);
            switch (tag) {
                case ExifTags.Image_XPAuthor:
                case ExifTags.Image_XPTitle:
                case ExifTags.Image_XPKeywords:
                case ExifTags.Image_XPComment:
                case ExifTags.Image_XPSubject:
                    return (encoding.GetBytes(value + "\0"));
                default:
                    return (encoding.GetBytes(value + "\0"));
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
            pi.Type = TagTypes.FromTag(tag);
            var bytes = ToBytes(tag, value);
            pi.Value = bytes;
            pi.Len = bytes.Length - 1;
            bitmap.SetPropertyItem(pi);
        }
    }
}
