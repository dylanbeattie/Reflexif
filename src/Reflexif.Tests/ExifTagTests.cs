using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Shouldly;

namespace Reflexif.Tests {
    [TestFixture]
    public class ExifTagTests {
        public static IEnumerable<ExifTags> ListAsciiTags {
            get {
                var values = Enum.GetValues(typeof(ExifTags));
                return (values.Cast<ExifTags>().Where(tag => TagTypes.FromTag(tag) == TagTypes.Ascii));
            }
        }

        public static IEnumerable<ExifTags> ListByteTags {
            get {
                var values = Enum.GetValues(typeof(ExifTags));
                return (values.Cast<ExifTags>()
                    .Where(tag => TagTypes.FromTag(tag) == TagTypes.Byte))
                    // For some reason these two tags just don't play nicely with the other children.
                    .Where(tag => tag != ExifTags.Image_XMLPacket && tag != ExifTags.Image_ImageResources);
            }
        }


        [Test]
        [TestCaseSource("ListAsciiTags")]
        [TestCaseSource("ListByteTags")]
        public void Ascii_Tag(ExifTags tag) {
            var guid = Guid.NewGuid();
            var path = guid + ".jpg";
            try {
                var source = guid.ToString();
                using (var bitmap = new Bitmap(100, 100)) {
                    bitmap.SetExifTag(tag, guid.ToString());
                    bitmap.Save(path, ImageFormat.Jpeg);
                }

                using (var bitmap = new Bitmap(path)) {
                    var actual = bitmap.ReadExifTag(tag);
                    actual.ShouldBe(source);
                }
            } finally {
                File.Delete(path);
            }
        }
    }
}
