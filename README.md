# Reflexif

**Live demo: [http://reflexif.azurewebsites.net/](http://reflexif.azurewebsites.net/)** 


A .NET application that demonstrates HTML5 drag'n'drop file upload, instant image thumbnail display, working with EXIF metadata using System.Drawing, and watermarking images with copyright information based on embedded EXIF metadata.

When you upload a file, the server will extract the EXIF metadata (if present) and use it to pre-populate the file details form. You can add or change details before clicking 'Upload Photograph'. The details you supply aren't held in a separate database; they're embedded into the uploaded photograph as EXIF metadata.

## Drag'n'drop file upload

Copied from Remy Sharp's [HTML5 Drag and Drop demo](http://html5demos.com/dnd-upload). Interesting things to note here are using the `event.target.result` property of the HTML5 `FileReader` object to create an `Image` and add it to the browser DOM before it's even been uploaded to the server, which I thought was rather clever.

## Parsing EXIF metadata with C# and System.Drawing

The `System.Drawing.Bitmap` type provides a very rudimentary entry point for working with EXIF metadata - the `Bitmap.GetPropertyItem(int)` method, which returns a PropertyItem whose Value property might contain a string. Except it's up to you to determine the encoding of the string, which could be ASCII, UTF8 or UCS2 depending whose idea it was to add this tag to the EXIF spec.

Take a look at the code in [BitmapExtensions.cs](https://github.com/dylanbeattie/Reflexif/blob/master/src/Reflexif/BitmapExtensions.cs) to see how you can extend this into a much friendlier API. One thing to note in here is that `PropertyItem` is a sealed class with a private constructor, which means you can't just call `new PropertyItem()` if you need a fresh one. The [officially recommended workaround for this](https://msdn.microsoft.com/en-us/library/system.drawing.imaging.propertyitem(v=vs.110).aspx) is to read a `PropertyItem` off another `Image` instance and reuse it - but that's a bit horrible, so instead I'm using reflection to construct new PropertyItem instances as needed.

## Watermarking images with embedded metadata

In [HomeController](https://github.com/dylanbeattie/Reflexif/blob/master/src/Reflexif.WebDemo/Controllers/HomeController.cs) you'll find some code that does dynamic image resizing, and will draw the image copyright holder information directly onto the image that's returned - this is using GDI+, System.Drawing, and some funky graphics transforms to rotate the text that's draw on the image.

## Known Issues

Due to encoding differences between different EXIF data formats, some EXIF fields don't seem to be populated properly in this version.