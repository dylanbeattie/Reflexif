using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Reflexif.Tests {
    [TestFixture]
    public class Class1 {
        [Test]
        public void Photoshop() {
            DumpTags(@"TestData\testcase_photoshop_cs3.jpg");
        }

        private static void DumpTags(string filePath) {
            using (var bitmap = new Bitmap(filePath)) {
                for (var tag = 0; tag < 0x10000; tag++) {
                    try {
                        string name;
                        var array = bitmap.GetPropertyItem((int)tag).Value;
                        name = "0x" + tag.ToString("X") + " " + Enum.GetName(typeof(ExifTags), tag);
                        Console.WriteLine(name + " " + String.Join(",", array.Take(200).Select(b => (char)b)));
                        Console.WriteLine(name + " RAW [" + String.Join(",", array.Take(200).Select(b => b.ToString("X"))) + "]");
                        Console.WriteLine(name + " ASCII \"" + Encoding.ASCII.GetString(array) + "\"");
                        Console.WriteLine(name + " Unicode \"" + Encoding.Unicode.GetString(array) + "\"");
                        Console.WriteLine(name + " UTF8 \"" + Encoding.UTF8.GetString(array) + "\"");
                        Console.WriteLine(name + " UTF7 \"" + Encoding.UTF7.GetString(array) + "\"");
                        Console.WriteLine(name + " UTF32 \"" + Encoding.UTF32.GetString(array) + "\"");
                    } catch {
                        //ignore
                    }
                }
            }
        }

        [Test]
        public void Windows() {
            DumpTags(@"TestData\testcase_windows_explorer.jpg");
        }

        [Test]
        public void Unicode() {
            DumpTags(@"TestData\testcase_photoshop_unicode.jpg");
        }
        [Test]
        public void Windows_Unicode() {
            DumpTags(@"TestData\testcase_windows_explorer_unicode.jpg");
        }
    }
}
