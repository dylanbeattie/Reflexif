// ReSharper disable InconsistentNaming
namespace Reflexif {
    public enum ExifTags {
        ///<summary>The name and version of the software used to post-process the picture.</summary>
        ProcessingSoftware = 0x000b,
        ///<summary>The name of the document from which this image was scanned</summary>
        DocumentName = 0x010d,
        ///<summary>A character string giving the title of the image. It may be a comment such as "1988 company picnic" or the like. Two-bytes character codes cannot be used. When a 2-bytes code is necessary, the Exif Private tag <UserComment> is to be used.</summary>
        ImageDescription = 0x010e,
        ///<summary>The manufacturer of the recording equipment. This is the manufacturer of the DSC, scanner, video digitizer or other equipment that generated the image. When the field is left blank, it is treated as unknown.</summary>
        Make = 0x010f,
        ///<summary>The model name or model number of the equipment. This is the model name or number of the DSC, scanner, video digitizer or other equipment that generated the image. When the field is left blank, it is treated as unknown.</summary>
        Model = 0x0110,
        ///<summary>This tag records the name and version of the software or firmware of the camera or image input device used to generate the image. The detailed format is not specified, but it is recommended that the example shown below be followed. When the field is left blank, it is treated as unknown.</summary>
        Software = 0x0131,
        ///<summary>The date and time of image creation. In Exif standard, it is the date and time the file was changed.</summary>
        DateTime = 0x0132,
        ///<summary>This tag records the name of the camera owner, photographer or image creator. The detailed format is not specified, but it is recommended that the information be written as in the example below for ease of Interoperability. When the field is left blank, it is treated as unknown. Ex.) "Camera owner, John Smith; Photographer, Michael Brown; Image creator, Ken James"</summary>
        Artist = 0x013b,
        ///<summary>This tag records information about the host computer used to generate the image.</summary>
        HostComputer = 0x013c,
        ///<summary>The name of each ink used in a separated (PhotometricInterpretation=5) image.</summary>
        InkNames = 0x014d,
        ///<summary>A description of the printing environment for which this separation is intended.</summary>
        TargetPrinter = 0x0151,
        ///<summary>ImageID is the full pathname of the original, high-resolution image, or any other identifying string that uniquely identifies the original image (Adobe OPI).</summary>
        ImageID = 0x800d,
        ///<summary>Copyright information. In this standard the tag is used to indicate both the photographer and editor copyrights. It is the copyright notice of the person or organization claiming rights to the image. The Interoperability copyright statement including date and rights should be written in this field; e.g., "Copyright, John Smith, 19xx. All rights reserved.". In this standard the field records both the photographer and editor copyrights, with each recorded in a separate part of the statement. When there is a clear distinction between the photographer and editor copyrights, these are to be written in the order of photographer followed by editor copyright, separated by NULL (in this case since the statement also ends with a NULL, there are two NULL codes). When only the photographer copyright is given, it is terminated by one NULL code. When only the editor copyright is given, the photographer copyright part consists of one space followed by a terminating NULL code, then the editor copyright is given. When the field is left blank, it is treated as unknown.</summary>
        Copyright = 0x8298,
        ///<summary>Indicates the spectral sensitivity of each channel of the camera used.</summary>
        SpectralSensitivity = 0x8824,
        ///<summary>The date and time when the original image data was generated.</summary>
        DateTimeOriginal = 0x9003,
        ///<summary>The date and time when the image was stored as digital data.</summary>
        DateTimeDigitized = 0x9004,
        ///<summary>Security classification assigned to the image.</summary>
        SecurityClassification = 0x9212,
        ///<summary>Record of what has been done to the image.</summary>
        ImageHistory = 0x9213,
        ///<summary>A tag used to record fractions of seconds for the DateTime tag.</summary>
        SubSecTime = 0x9290,
        ///<summary>A tag used to record fractions of seconds for the DateTimeOriginal tag.</summary>
        SubSecTimeOriginal = 0x9291,
        ///<summary>A tag used to record fractions of seconds for the DateTimeDigitized tag.</summary>
        SubSecTimeDigitized = 0x9292,
        ///<summary>This tag is used to record the name of an audio file related to the image data. The only relational information recorded here is the Exif audio file name and extension (an ASCII string consisting of 8 characters + '.' + 3 characters). The path is not recorded.</summary>
        RelatedSoundFile = 0xa004,
        ///<summary>This tag records the owner of a camera used in photography as an ASCII string.</summary>
        CameraOwnerName = 0xa430,
        ///<summary>This tag records the serial number of the body of the camera that was used in photography as an ASCII string.</summary>
        BodySerialNumber = 0xa431,
        ///<summary>This tag records the lens manufactor as an ASCII string.</summary>
        LensMake = 0xa433,
        ///<summary>This tag records the lens's model name and model number as an ASCII string.</summary>
        LensModel = 0xa434,
        ///<summary>This tag records the serial number of the interchangeable lens that was used in photography as an ASCII string.</summary>
        LensSerialNumber = 0xa435,
        ///<summary>Defines a unique, non-localized name for the camera model that created the image in the raw file. This name should include the manufacturer's name to avoid conflicts, and should not be localized, even if the camera name itself is localized for different markets (see LocalizedCameraModel). This string may be used by reader software to index into per-model preferences and replacement profiles.</summary>
        UniqueCameraModel = 0xc614,
        ///<summary>CameraSerialNumber contains the serial number of the camera or camera body that captured the image.</summary>
        CameraSerialNumber = 0xc62f,
        ///<summary>This tag is an ASCII string containing the name of the date/time at which the preview stored in the IFD was rendered. The date/time is encoded using ISO 8601 format.</summary>
        PreviewDateTime = 0xc71b,
        ///<summary>The Title property used by Windows Explorer. Windows will use ImageDescription if XPTitle is not present.</summary>
        XPTitle = 0x9C9B,
        /// The Subject property used by Windows Explorer. Windows will use ImageDescription if XPSubject is not present.
        XPSubject = 0x9C9F,
        /// <summary>The Tags property used by Windows Explorer.</summary>
        XPKeywords = 0x9c9e,
        /// <summary>The Comments property displayed by Windows Explorer.</summary>
        XPComment = 0x9c9c,
        /// <summary>The Author property used by Windows Explorer.</summary>
        XPAuthor = 0x9C9D
    }
}