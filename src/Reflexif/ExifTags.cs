// ReSharper disable InconsistentNaming
namespace Reflexif {
    public enum ExifTags {
        ///<summary>Ascii - The name and version of the software used to post-process the picture.</summary>
        Image_ProcessingSoftware = 0x000b,

        ///<summary>Long - A general indication of the kind of data contained in this subfile.</summary>
        Image_NewSubfileType = 0x00fe,

        ///<summary>Short - A general indication of the kind of data contained in this subfile. This field is deprecated. The NewSubfileType field should be used instead.</summary>
        Image_SubfileType = 0x00ff,

        ///<summary>Long - The number of columns of image data, equal to the number of pixels per row. In JPEG compressed data a JPEG marker is used instead of this tag.</summary>
        Image_ImageWidth = 0x0100,

        ///<summary>Long - The number of rows of image data. In JPEG compressed data a JPEG marker is used instead of this tag.</summary>
        Image_ImageLength = 0x0101,

        ///<summary>Short - The number of bits per image component. In this standard each component of the image is 8 bits, so the value for this tag is 8. See also SamplesPerPixel. In JPEG compressed data a JPEG marker is used instead of this tag.</summary>
        Image_BitsPerSample = 0x0102,

        ///<summary>Short - The compression scheme used for the image data. When a primary image is JPEG compressed, this designation is not necessary and is omitted. When thumbnails use JPEG compression, this tag value is set to 6.</summary>
        Image_Compression = 0x0103,

        ///<summary>Short - The pixel composition. In JPEG compressed data a JPEG marker is used instead of this tag.</summary>
        Image_PhotometricInterpretation = 0x0106,

        ///<summary>Short - For black and white TIFF files that represent shades of gray, the technique used to convert from gray to black and white pixels.</summary>
        Image_Thresholding = 0x0107,

        ///<summary>Short - The width of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.</summary>
        Image_CellWidth = 0x0108,

        ///<summary>Short - The length of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.</summary>
        Image_CellLength = 0x0109,

        ///<summary>Short - The logical order of bits within a byte</summary>
        Image_FillOrder = 0x010a,

        ///<summary>Ascii - The name of the document from which this image was scanned</summary>
        Image_DocumentName = 0x010d,

        ///<summary>Ascii - A character string giving the title of the image. It may be a comment such as "1988 company picnic" or the like. Two-bytes character codes cannot be used. When a 2-bytes code is necessary, the Exif Private tag UserComment is to be used.</summary>
        Image_ImageDescription = 0x010e,

        ///<summary>Ascii - The manufacturer of the recording equipment. This is the manufacturer of the DSC, scanner, video digitizer or other equipment that generated the image. When the field is left blank, it is treated as unknown.</summary>
        Image_Make = 0x010f,

        ///<summary>Ascii - The model name or model number of the equipment. This is the model name or number of the DSC, scanner, video digitizer or other equipment that generated the image. When the field is left blank, it is treated as unknown.</summary>
        Image_Model = 0x0110,

        ///<summary>Long - For each strip, the byte offset of that strip. It is recommended that this be selected so the number of strip bytes does not exceed 64 Kbytes. With JPEG compressed data this designation is not needed and is omitted. See also RowsPerStrip and StripByteCounts.</summary>
        Image_StripOffsets = 0x0111,

        ///<summary>Short - The image orientation viewed in terms of rows and columns.</summary>
        Image_Orientation = 0x0112,

        ///<summary>Short - The number of components per pixel. Since this standard applies to RGB and YCbCr images, the value set for this tag is 3. In JPEG compressed data a JPEG marker is used instead of this tag.</summary>
        Image_SamplesPerPixel = 0x0115,

        ///<summary>Long - The number of rows per strip. This is the number of rows in the image of one strip when an image is divided into strips. With JPEG compressed data this designation is not needed and is omitted. See also <StripOffsets> and <StripByteCounts>.</summary>
        Image_RowsPerStrip = 0x0116,

        ///<summary>Long - The total number of bytes in each strip. With JPEG compressed data this designation is not needed and is omitted.</summary>
        Image_StripByteCounts = 0x0117,

        ///<summary>Rational - The number of pixels per ResolutionUnit> in the ImageWidth direction. When the image resolution is unknown, 72 [dpi] is designated.</summary>
        Image_XResolution = 0x011a,

        ///<summary>Rational - The number of pixels per ResolutionUnit in the ImageLength direction. The same value as XResolution is designated.</summary>
        Image_YResolution = 0x011b,

        ///<summary>Short - Indicates whether pixel components are recorded in a chunky or planar format. In JPEG compressed files a JPEG marker is used instead of this tag. If this field does not exist, the TIFF default of 1 (chunky) is assumed.</summary>
        Image_PlanarConfiguration = 0x011c,

        ///<summary>Short - The precision of the information contained in the GrayResponseCurve.</summary>
        Image_GrayResponseUnit = 0x0122,

        ///<summary>Short - For grayscale data, the optical density of each possible pixel value.</summary>
        Image_GrayResponseCurve = 0x0123,

        ///<summary>Long - T.4-encoding options.</summary>
        Image_T4Options = 0x0124,

        ///<summary>Long - T.6-encoding options.</summary>
        Image_T6Options = 0x0125,

        ///<summary>Short - The unit for measuring XResolution and YResolution. The same unit is used for both XResolution and YResolution. If the image resolution is unknown, 2 (inches) is designated.</summary>
        Image_ResolutionUnit = 0x0128,

        ///<summary>Short - The page number of the page from which this image was scanned.</summary>
        Image_PageNumber = 0x0129,

        ///<summary>Short - A transfer function for the image, described in tabular style. Normally this tag is not necessary, since color space is specified in the color space information tag (<ColorSpace>).</summary>
        Image_TransferFunction = 0x012d,

        ///<summary>Ascii - This tag records the name and version of the software or firmware of the camera or image input device used to generate the image. The detailed format is not specified, but it is recommended that the example shown below be followed. When the field is left blank, it is treated as unknown.</summary>
        Image_Software = 0x0131,

        ///<summary>Ascii - The date and time of image creation. In Exif standard, it is the date and time the file was changed.</summary>
        Image_DateTime = 0x0132,

        ///<summary>Ascii - This tag records the name of the camera owner, photographer or image creator. The detailed format is not specified, but it is recommended that the information be written as in the example below for ease of Interoperability. When the field is left blank, it is treated as unknown. Ex.) "Camera owner, John Smith, Photographer, Michael Brown, Image creator, Ken James"</summary>
        Image_Artist = 0x013b,

        ///<summary>Ascii - This tag records information about the host computer used to generate the image.</summary>
        Image_HostComputer = 0x013c,

        ///<summary>Short - A predictor is a mathematical operator that is applied to the image data before an encoding scheme is applied.</summary>
        Image_Predictor = 0x013d,

        ///<summary>Rational - The chromaticity of the white point of the image. Normally this tag is not necessary, since color space is specified in the colorspace information tag (<ColorSpace>).</summary>
        Image_WhitePoint = 0x013e,

        ///<summary>Rational - The chromaticity of the three primary colors of the image. Normally this tag is not necessary, since colorspace is specified in the colorspace information tag (<ColorSpace>).</summary>
        Image_PrimaryChromaticities = 0x013f,

        ///<summary>Short - A color map for palette color images. This field defines a Red-Green-Blue color map (often called a lookup table) for palette-color images. In a palette-color image, a pixel value is used to index into an RGB lookup table.</summary>
        Image_ColorMap = 0x0140,

        ///<summary>Short - The purpose of the HalftoneHints field is to convey to the halftone function the range of gray levels within a colorimetrically-specified image that should retain tonal detail.</summary>
        Image_HalftoneHints = 0x0141,

        ///<summary>Short - The tile width in pixels. This is the number of columns in each tile.</summary>
        Image_TileWidth = 0x0142,

        ///<summary>Short - The tile length (height) in pixels. This is the number of rows in each tile.</summary>
        Image_TileLength = 0x0143,

        ///<summary>Short - For each tile, the byte offset of that tile, as compressed and stored on disk. The offset is specified with respect to the beginning of the TIFF file. Note that this implies that each tile has a location independent of the locations of other tiles.</summary>
        Image_TileOffsets = 0x0144,

        ///<summary>Short - For each tile, the number of (compressed) bytes in that tile. See TileOffsets for a description of how the byte counts are ordered.</summary>
        Image_TileByteCounts = 0x0145,

        ///<summary>Long - Defined by Adobe Corporation to enable TIFF Trees within a TIFF file.</summary>
        Image_SubIFDs = 0x014a,

        ///<summary>Short - The set of inks used in a separated (PhotometricInterpretation=5) image.</summary>
        Image_InkSet = 0x014c,

        ///<summary>Ascii - The name of each ink used in a separated (PhotometricInterpretation=5) image.</summary>
        Image_InkNames = 0x014d,

        ///<summary>Short - The number of inks. Usually equal to SamplesPerPixel, unless there are extra samples.</summary>
        Image_NumberOfInks = 0x014e,

        ///<summary>Byte - The component values that correspond to a 0% dot and 100% dot.</summary>
        Image_DotRange = 0x0150,

        ///<summary>Ascii - A description of the printing environment for which this separation is intended.</summary>
        Image_TargetPrinter = 0x0151,

        ///<summary>Short - Specifies that each pixel has m extra components whose interpretation is defined by one of the values listed below.</summary>
        Image_ExtraSamples = 0x0152,

        ///<summary>Short - This field specifies how to interpret each data sample in a pixel.</summary>
        Image_SampleFormat = 0x0153,

        ///<summary>Short - This field specifies the minimum sample value.</summary>
        Image_SMinSampleValue = 0x0154,

        ///<summary>Short - This field specifies the maximum sample value.</summary>
        Image_SMaxSampleValue = 0x0155,

        ///<summary>Short - Expands the range of the TransferFunction</summary>
        Image_TransferRange = 0x0156,

        ///<summary>Byte - A TIFF ClipPath is intended to mirror the essentials of PostScript's path creation functionality.</summary>
        Image_ClipPath = 0x0157,

        ///<summary>SShort - The number of units that span the width of the image, in terms of integer ClipPath coordinates.</summary>
        Image_XClipPathUnits = 0x0158,

        ///<summary>SShort - The number of units that span the height of the image, in terms of integer ClipPath coordinates.</summary>
        Image_YClipPathUnits = 0x0159,

        ///<summary>Short - Indexed images are images where the 'pixels' do not represent color values, but rather an index (usually 8-bit) into a separate color table, the ColorMap.</summary>
        Image_Indexed = 0x015a,

        ///<summary>Undefined - This optional tag may be used to encode the JPEG quantization and Huffman tables for subsequent use by the JPEG decompression process.</summary>
        Image_JPEGTables = 0x015b,

        ///<summary>Short - OPIProxy gives information concerning whether this image is a low-resolution proxy of a high-resolution image (Adobe OPI).</summary>
        Image_OPIProxy = 0x015f,

        ///<summary>Long - This field indicates the process used to produce the compressed data</summary>
        Image_JPEGProc = 0x0200,

        ///<summary>Long - The offset to the start byte (SOI) of JPEG compressed thumbnail data. This is not used for primary image JPEG data.</summary>
        Image_JPEGInterchangeFormat = 0x0201,

        ///<summary>Long - The number of bytes of JPEG compressed thumbnail data. This is not used for primary image JPEG data. JPEG thumbnails are not divided but are recorded as a continuous JPEG bitstream from SOI to EOI. Appn and COM markers should not be recorded. Compressed thumbnails must be recorded in no more than 64 Kbytes, including all other data to be recorded in APP1.</summary>
        Image_JPEGInterchangeFormatLength = 0x0202,

        ///<summary>Short - This Field indicates the length of the restart interval used in the compressed image data.</summary>
        Image_JPEGRestartInterval = 0x0203,

        ///<summary>Short - This Field points to a list of lossless predictor-selection values, one per component.</summary>
        Image_JPEGLosslessPredictors = 0x0205,

        ///<summary>Short - This Field points to a list of point transform values, one per component.</summary>
        Image_JPEGPointTransforms = 0x0206,

        ///<summary>Long - This Field points to a list of offsets to the quantization tables, one per component.</summary>
        Image_JPEGQTables = 0x0207,

        ///<summary>Long - This Field points to a list of offsets to the DC Huffman tables or the lossless Huffman tables, one per component.</summary>
        Image_JPEGDCTables = 0x0208,

        ///<summary>Long - This Field points to a list of offsets to the Huffman AC tables, one per component.</summary>
        Image_JPEGACTables = 0x0209,

        ///<summary>Rational - The matrix coefficients for transformation from RGB to YCbCr image data. No default is given in TIFF, but here the value given in Appendix E, "Color Space Guidelines", is used as the default. The color space is declared in a color space information tag, with the default being the value that gives the optimal image characteristics Interoperability this condition.</summary>
        Image_YCbCrCoefficients = 0x0211,

        ///<summary>Short - The sampling ratio of chrominance components in relation to the luminance component. In JPEG compressed data a JPEG marker is used instead of this tag.</summary>
        Image_YCbCrSubSampling = 0x0212,

        ///<summary>Short - The position of chrominance components in relation to the luminance component. This field is designated only for JPEG compressed data or uncompressed YCbCr data. The TIFF default is 1 (centered), but when Y:Cb:Cr = 4:2:2 it is recommended in this standard that 2 (co-sited) be used to record data, in order to improve the image quality when viewed on TV systems. When this field does not exist, the reader shall assume the TIFF default. In the case of Y:Cb:Cr = 4:2:0, the TIFF default (centered) is recommended. If the reader does not have the capability of supporting both kinds of <YCbCrPositioning>, it shall follow the TIFF default regardless of the value in this field. It is preferable that readers be able to support both centered and co-sited positioning.</summary>
        Image_YCbCrPositioning = 0x0213,

        ///<summary>Rational - The reference black point value and reference white point value. No defaults are given in TIFF, but the values below are given as defaults here. The color space is declared in a color space information tag, with the default being the value that gives the optimal image characteristics Interoperability these conditions.</summary>
        Image_ReferenceBlackWhite = 0x0214,

        ///<summary>Byte - XMP Metadata (Adobe technote 9-14-02)</summary>
        Image_XMLPacket = 0x02bc,

        ///<summary>Short - Rating tag used by Windows</summary>
        Image_Rating = 0x4746,

        ///<summary>Short - Rating tag used by Windows, value in percent</summary>
        Image_RatingPercent = 0x4749,

        ///<summary>Ascii - ImageID is the full pathname of the original, high-resolution image, or any other identifying string that uniquely identifies the original image (Adobe OPI).</summary>
        Image_ImageID = 0x800d,

        ///<summary>Short - Contains two values representing the minimum rows and columns to define the repeating patterns of the color filter array</summary>
        Image_CFARepeatPatternDim = 0x828d,

        ///<summary>Byte - Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods</summary>
        Image_CFAPattern = 0x828e,

        ///<summary>Rational - Contains a value of the battery level as a fraction or string</summary>
        Image_BatteryLevel = 0x828f,

        ///<summary>Ascii - Copyright information. In this standard the tag is used to indicate both the photographer and editor copyrights. It is the copyright notice of the person or organization claiming rights to the image. The Interoperability copyright statement including date and rights should be written in this field, e.g., "Copyright, John Smith, 19xx. All rights reserved.". In this standard the field records both the photographer and editor copyrights, with each recorded in a separate part of the statement. When there is a clear distinction between the photographer and editor copyrights, these are to be written in the order of photographer followed by editor copyright, separated by NULL (in this case since the statement also ends with a NULL, there are two NULL codes). When only the photographer copyright is given, it is terminated by one NULL code. When only the editor copyright is given, the photographer copyright part consists of one space followed by a terminating NULL code, then the editor copyright is given. When the field is left blank, it is treated as unknown.</summary>
        Image_Copyright = 0x8298,

        ///<summary>Rational - Exposure time, given in seconds.</summary>
        Image_ExposureTime = 0x829a,

        ///<summary>Rational - The F number.</summary>
        Image_FNumber = 0x829d,

        ///<summary>Long - Contains an IPTC/NAA record</summary>
        Image_IPTCNAA = 0x83bb,

        ///<summary>Byte - Contains information embedded by the Adobe Photoshop application</summary>
        Image_ImageResources = 0x8649,

        ///<summary>Long - A pointer to the Exif IFD. Interoperability, Exif IFD has the same structure as that of the IFD specified in TIFF. ordinarily, however, it does not contain image data as in the case of TIFF.</summary>
        Image_ExifTag = 0x8769,

        ///<summary>Undefined - Contains an InterColor Consortium (ICC) format color space characterization/profile</summary>
        Image_InterColorProfile = 0x8773,

        ///<summary>Short - The class of the program used by the camera to set exposure when the picture is taken.</summary>
        Image_ExposureProgram = 0x8822,

        ///<summary>Ascii - Indicates the spectral sensitivity of each channel of the camera used.</summary>
        Image_SpectralSensitivity = 0x8824,

        ///<summary>Long - A pointer to the GPS Info IFD. The Interoperability structure of the GPS Info IFD, like that of Exif IFD, has no image data.</summary>
        Image_GPSTag = 0x8825,

        ///<summary>Short - Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.</summary>
        Image_ISOSpeedRatings = 0x8827,

        ///<summary>Undefined - Indicates the Opto-Electric Conversion Function (OECF) specified in ISO 14524.</summary>
        Image_OECF = 0x8828,

        ///<summary>Short - Indicates the field number of multifield images.</summary>
        Image_Interlace = 0x8829,

        ///<summary>SShort - This optional tag encodes the time zone of the camera clock (relativeto Greenwich Mean Time) used to create the DataTimeOriginal tag-valuewhen the picture was taken. It may also contain the time zone offsetof the clock used to create the DateTime tag-value when the image wasmodified.</summary>
        Image_TimeZoneOffset = 0x882a,

        ///<summary>Short - Number of seconds image capture was delayed from button press.</summary>
        Image_SelfTimerMode = 0x882b,

        ///<summary>Ascii - The date and time when the original image data was generated.</summary>
        Image_DateTimeOriginal = 0x9003,

        ///<summary>Rational - Specific to compressed data, states the compressed bits per pixel.</summary>
        Image_CompressedBitsPerPixel = 0x9102,

        ///<summary>SRational - Shutter speed.</summary>
        Image_ShutterSpeedValue = 0x9201,

        ///<summary>Rational - The lens aperture.</summary>
        Image_ApertureValue = 0x9202,

        ///<summary>SRational - The value of brightness.</summary>
        Image_BrightnessValue = 0x9203,

        ///<summary>SRational - The exposure bias.</summary>
        Image_ExposureBiasValue = 0x9204,

        ///<summary>Rational - The smallest F number of the lens.</summary>
        Image_MaxApertureValue = 0x9205,

        ///<summary>SRational - The distance to the subject, given in meters.</summary>
        Image_SubjectDistance = 0x9206,

        ///<summary>Short - The metering mode.</summary>
        Image_MeteringMode = 0x9207,

        ///<summary>Short - The kind of light source.</summary>
        Image_LightSource = 0x9208,

        ///<summary>Short - Indicates the status of flash when the image was shot.</summary>
        Image_Flash = 0x9209,

        ///<summary>Rational - The actual focal length of the lens, in mm.</summary>
        Image_FocalLength = 0x920a,

        ///<summary>Rational - Amount of flash energy (BCPS).</summary>
        Image_FlashEnergy = 0x920b,

        ///<summary>Undefined - SFR of the camera.</summary>
        Image_SpatialFrequencyResponse = 0x920c,

        ///<summary>Undefined - Noise measurement values.</summary>
        Image_Noise = 0x920d,

        ///<summary>Rational - Number of pixels per FocalPlaneResolutionUnit (37392) in ImageWidth direction for main image.</summary>
        Image_FocalPlaneXResolution = 0x920e,

        ///<summary>Rational - Number of pixels per FocalPlaneResolutionUnit (37392) in ImageLength direction for main image.</summary>
        Image_FocalPlaneYResolution = 0x920f,

        ///<summary>Short - Unit of measurement for FocalPlaneXResolution(37390) and FocalPlaneYResolution(37391).</summary>
        Image_FocalPlaneResolutionUnit = 0x9210,

        ///<summary>Long - Number assigned to an image, e.g., in a chained image burst.</summary>
        Image_ImageNumber = 0x9211,

        ///<summary>Ascii - Security classification assigned to the image.</summary>
        Image_SecurityClassification = 0x9212,

        ///<summary>Ascii - Record of what has been done to the image.</summary>
        Image_ImageHistory = 0x9213,

        ///<summary>Short - Indicates the location and area of the main subject in the overall scene.</summary>
        Image_SubjectLocation = 0x9214,

        ///<summary>Rational - Encodes the camera exposure index setting when image was captured.</summary>
        Image_ExposureIndex = 0x9215,

        ///<summary>Byte - Contains four ASCII characters representing the TIFF/EP standard version of a TIFF/EP file, eg '1', '0', '0', '0'</summary>
        Image_TIFFEPStandardID = 0x9216,

        ///<summary>Short - Type of image sensor.</summary>
        Image_SensingMethod = 0x9217,

        ///<summary>Byte - Title tag used by Windows, encoded in UCS2</summary>
        Image_XPTitle = 0x9c9b,

        ///<summary>Byte - Comment tag used by Windows, encoded in UCS2</summary>
        Image_XPComment = 0x9c9c,

        ///<summary>Byte - Author tag used by Windows, encoded in UCS2</summary>
        Image_XPAuthor = 0x9c9d,

        ///<summary>Byte - Keywords tag used by Windows, encoded in UCS2</summary>`
        Image_XPKeywords = 0x9c9e,

        ///<summary>Byte - Subject tag used by Windows, encoded in UCS2</summary>
        Image_XPSubject = 0x9c9f,

        ///<summary>Undefined - Print Image Matching, description needed.</summary>
        Image_PrintImageMatching = 0xc4a5,

        ///<summary>Byte - This tag encodes the DNG four-tier version number. For files compliant with version 1.1.0.0 of the DNG specification, this tag should contain the bytes: 1, 1, 0, 0.</summary>
        Image_DNGVersion = 0xc612,

        ///<summary>Byte - This tag specifies the oldest version of the Digital Negative specification for which a file is compatible. Readers shouldnot attempt to read a file if this tag specifies a version number that is higher than the version number of the specification the reader was based on. In addition to checking the version tags, readers should, for all tags, check the types, counts, and values, to verify it is able to correctly read the file.</summary>
        Image_DNGBackwardVersion = 0xc613,

        ///<summary>Ascii - Defines a unique, non-localized name for the camera model that created the image in the raw file. This name should include the manufacturer's name to avoid conflicts, and should not be localized, even if the camera name itself is localized for different markets (see LocalizedCameraModel). This string may be used by reader software to index into per-model preferences and replacement profiles.</summary>
        Image_UniqueCameraModel = 0xc614,

        ///<summary>Byte - Similar to the UniqueCameraModel field, except the name can be localized for different markets to match the localization of the camera name.</summary>
        Image_LocalizedCameraModel = 0xc615,

        ///<summary>Byte - Provides a mapping between the values in the CFAPattern tag and the plane numbers in LinearRaw space. This is a required tag for non-RGB CFA images.</summary>
        Image_CFAPlaneColor = 0xc616,

        ///<summary>Short - Describes the spatial layout of the CFA.</summary>
        Image_CFALayout = 0xc617,

        ///<summary>Short - Describes a lookup table that maps stored values into linear values. This tag is typically used to increase compression ratios by storing the raw data in a non-linear, more visually uniform space with fewer total encoding levels. If SamplesPerPixel is not equal to one, this single table applies to all the samples for each pixel.</summary>
        Image_LinearizationTable = 0xc618,

        ///<summary>Short - Specifies repeat pattern size for the BlackLevel tag.</summary>
        Image_BlackLevelRepeatDim = 0xc619,

        ///<summary>Rational - Specifies the zero light (a.k.a. thermal black or black current) encoding level, as a repeating pattern. The origin of this pattern is the top-left corner of the ActiveArea rectangle. The values are stored in row-column-sample scan order.</summary>
        Image_BlackLevel = 0xc61a,

        ///<summary>SRational - If the zero light encoding level is a function of the image column, BlackLevelDeltaH specifies the difference between the zero light encoding level for each column and the baseline zero light encoding level. If SamplesPerPixel is not equal to one, this single table applies to all the samples for each pixel.</summary>
        Image_BlackLevelDeltaH = 0xc61b,

        ///<summary>SRational - If the zero light encoding level is a function of the image row, this tag specifies the difference between the zero light encoding level for each row and the baseline zero light encoding level. If SamplesPerPixel is not equal to one, this single table applies to all the samples for each pixel.</summary>
        Image_BlackLevelDeltaV = 0xc61c,

        ///<summary>Short - This tag specifies the fully saturated encoding level for the raw sample values. Saturation is caused either by the sensor itself becoming highly non-linear in response, or by the camera's analog to digital converter clipping.</summary>
        Image_WhiteLevel = 0xc61d,

        ///<summary>Rational - DefaultScale is required for cameras with non-square pixels. It specifies the default scale factors for each direction to convert the image to square pixels. Typically these factors are selected to approximately preserve total pixel count. For CFA images that use CFALayout equal to 2, 3, 4, or 5, such as the Fujifilm SuperCCD, these two values should usually differ by a factor of 2.0.</summary>
        Image_DefaultScale = 0xc61e,

        ///<summary>Short - Raw images often store extra pixels around the edges of the final image. These extra pixels help prevent interpolation artifacts near the edges of the final image. DefaultCropOrigin specifies the origin of the final image area, in raw image coordinates (i.e., before the DefaultScale has been applied), relative to the top-left corner of the ActiveArea rectangle.</summary>
        Image_DefaultCropOrigin = 0xc61f,

        ///<summary>Short - Raw images often store extra pixels around the edges of the final image. These extra pixels help prevent interpolation artifacts near the edges of the final image. DefaultCropSize specifies the size of the final image area, in raw image coordinates (i.e., before the DefaultScale has been applied).</summary>
        Image_DefaultCropSize = 0xc620,

        ///<summary>SRational - ColorMatrix1 defines a transformation matrix that converts XYZ values to reference camera native color space values, under the first calibration illuminant. The matrix values are stored in row scan order. The ColorMatrix1 tag is required for all non-monochrome DNG files.</summary>
        Image_ColorMatrix1 = 0xc621,

        ///<summary>SRational - ColorMatrix2 defines a transformation matrix that converts XYZ values to reference camera native color space values, under the second calibration illuminant. The matrix values are stored in row scan order.</summary>
        Image_ColorMatrix2 = 0xc622,

        ///<summary>SRational - CameraCalibration1 defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the first calibration illuminant. The matrix is stored in row scan order. This matrix is stored separately from the matrix specified by the ColorMatrix1 tag to allow raw converters to swap in replacement color matrices based on UniqueCameraModel tag, while still taking advantage of any per-individual camera calibration performed by the camera manufacturer.</summary>
        Image_CameraCalibration1 = 0xc623,

        ///<summary>SRational - CameraCalibration2 defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the second calibration illuminant. The matrix is stored in row scan order. This matrix is stored separately from the matrix specified by the ColorMatrix2 tag to allow raw converters to swap in replacement color matrices based on UniqueCameraModel tag, while still taking advantage of any per-individual camera calibration performed by the camera manufacturer.</summary>
        Image_CameraCalibration2 = 0xc624,

        ///<summary>SRational - ReductionMatrix1 defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values, under the first calibration illuminant. This tag may only be used if ColorPlanes is greater than 3. The matrix is stored in row scan order.</summary>
        Image_ReductionMatrix1 = 0xc625,

        ///<summary>SRational - ReductionMatrix2 defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values, under the second calibration illuminant. This tag may only be used if ColorPlanes is greater than 3. The matrix is stored in row scan order.</summary>
        Image_ReductionMatrix2 = 0xc626,

        ///<summary>Rational - Normally the stored raw values are not white balanced, since any digital white balancing will reduce the dynamic range of the final image if the user decides to later adjust the white balance, however, if camera hardware is capable of white balancing the color channels before the signal is digitized, it can improve the dynamic range of the final image. AnalogBalance defines the gain, either analog (recommended) or digital (not recommended) that has been applied the stored raw values.</summary>
        Image_AnalogBalance = 0xc627,

        ///<summary>Short - Specifies the selected white balance at time of capture, encoded as the coordinates of a perfectly neutral color in linear reference space values. The inclusion of this tag precludes the inclusion of the AsShotWhiteXY tag.</summary>
        Image_AsShotNeutral = 0xc628,

        ///<summary>Rational - Specifies the selected white balance at time of capture, encoded as x-y chromaticity coordinates. The inclusion of this tag precludes the inclusion of the AsShotNeutral tag.</summary>
        Image_AsShotWhiteXY = 0xc629,

        ///<summary>SRational - Camera models vary in the trade-off they make between highlight headroom and shadow noise. Some leave a significant amount of highlight headroom during a normal exposure. This allows significant negative exposure compensation to be applied during raw conversion, but also means normal exposures will contain more shadow noise. Other models leave less headroom during normal exposures. This allows for less negative exposure compensation, but results in lower shadow noise for normal exposures. Because of these differences, a raw converter needs to vary the zero point of its exposure compensation control from model to model. BaselineExposure specifies by how much (in EV units) to move the zero point. Positive values result in brighter default results, while negative values result in darker default results.</summary>
        Image_BaselineExposure = 0xc62a,

        ///<summary>Rational - Specifies the relative noise level of the camera model at a baseline ISO value of 100, compared to a reference camera model. Since noise levels tend to vary approximately with the square root of the ISO value, a raw converter can use this value, combined with the current ISO, to estimate the relative noise level of the current image.</summary>
        Image_BaselineNoise = 0xc62b,

        ///<summary>Rational - Specifies the relative amount of sharpening required for this camera model, compared to a reference camera model. Camera models vary in the strengths of their anti-aliasing filters. Cameras with weak or no filters require less sharpening than cameras with strong anti-aliasing filters.</summary>
        Image_BaselineSharpness = 0xc62c,

        ///<summary>Long - Only applies to CFA images using a Bayer pattern filter array. This tag specifies, in arbitrary units, how closely the values of the green pixels in the blue/green rows track the values of the green pixels in the red/green rows. A value of zero means the two kinds of green pixels track closely, while a non-zero value means they sometimes diverge. The useful range for this tag is from 0 (no divergence) to about 5000 (quite large divergence).</summary>
        Image_BayerGreenSplit = 0xc62d,

        ///<summary>Rational - Some sensors have an unpredictable non-linearity in their response as they near the upper limit of their encoding range. This non-linearity results in color shifts in the highlight areas of the resulting image unless the raw converter compensates for this effect. LinearResponseLimit specifies the fraction of the encoding range above which the response may become significantly non-linear.</summary>
        Image_LinearResponseLimit = 0xc62e,

        ///<summary>Ascii - CameraSerialNumber contains the serial number of the camera or camera body that captured the image.</summary>
        Image_CameraSerialNumber = 0xc62f,

        ///<summary>Rational - Contains information about the lens that captured the image. If the minimum f-stops are unknown, they should be encoded as 0/0.</summary>
        Image_LensInfo = 0xc630,

        ///<summary>Rational - ChromaBlurRadius provides a hint to the DNG reader about how much chroma blur should be applied to the image. If this tag is omitted, the reader will use its default amount of chroma blurring. Normally this tag is only included for non-CFA images, since the amount of chroma blur required for mosaic images is highly dependent on the de-mosaic algorithm, in which case the DNG reader's default value is likely optimized for its particular de-mosaic algorithm.</summary>
        Image_ChromaBlurRadius = 0xc631,

        ///<summary>Rational - Provides a hint to the DNG reader about how strong the camera's anti-alias filter is. A value of 0.0 means no anti-alias filter (i.e., the camera is prone to aliasing artifacts with some subjects), while a value of 1.0 means a strong anti-alias filter (i.e., the camera almost never has aliasing artifacts).</summary>
        Image_AntiAliasStrength = 0xc632,

        ///<summary>SRational - This tag is used by Adobe Camera Raw to control the sensitivity of its 'Shadows' slider.</summary>
        Image_ShadowScale = 0xc633,

        ///<summary>Byte - Provides a way for camera manufacturers to store private data in the DNG file for use by their own raw converters, and to have that data preserved by programs that edit DNG files.</summary>
        Image_DNGPrivateData = 0xc634,

        ///<summary>Short - MakerNoteSafety lets the DNG reader know whether the EXIF MakerNote tag is safe to preserve along with the rest of the EXIF data. File browsers and other image management software processing an image with a preserved MakerNote should be aware that any thumbnail image embedded in the MakerNote may be stale, and may not reflect the current state of the full size image.</summary>
        Image_MakerNoteSafety = 0xc635,

        ///<summary>Short - The illuminant used for the first set of color calibration tags (ColorMatrix1, CameraCalibration1, ReductionMatrix1). The legal values for this tag are the same as the legal values for the LightSource EXIF tag.</summary>
        Image_CalibrationIlluminant1 = 0xc65a,

        ///<summary>Short - The illuminant used for an optional second set of color calibration tags (ColorMatrix2, CameraCalibration2, ReductionMatrix2). The legal values for this tag are the same as the legal values for the CalibrationIlluminant1 tag, however, if both are included, neither is allowed to have a value of 0 (unknown).</summary>
        Image_CalibrationIlluminant2 = 0xc65b,

        ///<summary>Rational - For some cameras, the best possible image quality is not achieved by preserving the total pixel count during conversion. For example, Fujifilm SuperCCD images have maximum detail when their total pixel count is doubled. This tag specifies the amount by which the values of the DefaultScale tag need to be multiplied to achieve the best quality image size.</summary>
        Image_BestQualityScale = 0xc65c,

        ///<summary>Byte - This tag contains a 16-byte unique identifier for the raw image data in the DNG file. DNG readers can use this tag to recognize a particular raw image, even if the file's name or the metadata contained in the file has been changed. If a DNG writer creates such an identifier, it should do so using an algorithm that will ensure that it is very unlikely two different images will end up having the same identifier.</summary>
        Image_RawDataUniqueID = 0xc65d,

        ///<summary>Byte - If the DNG file was converted from a non-DNG raw file, then this tag contains the file name of that original raw file.</summary>
        Image_OriginalRawFileName = 0xc68b,

        ///<summary>Undefined - If the DNG file was converted from a non-DNG raw file, then this tag contains the compressed contents of that original raw file. The contents of this tag always use the big-endian byte order. The tag contains a sequence of data blocks. Future versions of the DNG specification may define additional data blocks, so DNG readers should ignore extra bytes when parsing this tag. DNG readers should also detect the case where data blocks are missing from the end of the sequence, and should assume a default value for all the missing blocks. There are no padding or alignment bytes between data blocks.</summary>
        Image_OriginalRawFileData = 0xc68c,

        ///<summary>Short - This rectangle defines the active (non-masked) pixels of the sensor. The order of the rectangle coordinates is: top, left, bottom, right.</summary>
        Image_ActiveArea = 0xc68d,

        ///<summary>Short - This tag contains a list of non-overlapping rectangle coordinates of fully masked pixels, which can be optionally used by DNG readers to measure the black encoding level. The order of each rectangle's coordinates is: top, left, bottom, right. If the raw image data has already had its black encoding level subtracted, then this tag should not be used, since the masked pixels are no longer useful.</summary>
        Image_MaskedAreas = 0xc68e,

        ///<summary>Undefined - This tag contains an ICC profile that, in conjunction with the AsShotPreProfileMatrix tag, provides the camera manufacturer with a way to specify a default color rendering from camera color space coordinates (linear reference values) into the ICC profile connection space. The ICC profile connection space is an output referred colorimetric space, whereas the other color calibration tags in DNG specify a conversion into a scene referred colorimetric space. This means that the rendering in this profile should include any desired tone and gamut mapping needed to convert between scene referred values and output referred values.</summary>
        Image_AsShotICCProfile = 0xc68f,

        ///<summary>SRational - This tag is used in conjunction with the AsShotICCProfile tag. It specifies a matrix that should be applied to the camera color space coordinates before processing the values through the ICC profile specified in the AsShotICCProfile tag. The matrix is stored in the row scan order. If ColorPlanes is greater than three, then this matrix can (but is not required to) reduce the dimensionality of the color data down to three components, in which case the AsShotICCProfile should have three rather than ColorPlanes input components.</summary>
        Image_AsShotPreProfileMatrix = 0xc690,

        ///<summary>Undefined - This tag is used in conjunction with the CurrentPreProfileMatrix tag. The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as the AsShotICCProfile and AsShotPreProfileMatrix tag pair, except they are for use by raw file editors rather than camera manufacturers.</summary>
        Image_CurrentICCProfile = 0xc691,

        ///<summary>SRational - This tag is used in conjunction with the CurrentICCProfile tag. The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as the AsShotICCProfile and AsShotPreProfileMatrix tag pair, except they are for use by raw file editors rather than camera manufacturers.</summary>
        Image_CurrentPreProfileMatrix = 0xc692,

        ///<summary>Short - The DNG color model documents a transform between camera colors and CIE XYZ values. This tag describes the colorimetric reference for the CIE XYZ values. 0 = The XYZ values are scene-referred. 1 = The XYZ values are output-referred, using the ICC profile perceptual dynamic range. This tag allows output-referred data to be stored in DNG files and still processed correctly by DNG readers.</summary>
        Image_ColorimetricReference = 0xc6bf,

        ///<summary>Byte - A UTF-8 encoded string associated with the CameraCalibration1 and CameraCalibration2 tags. The CameraCalibration1 and CameraCalibration2 tags should only be used in the DNG color transform if the string stored in the CameraCalibrationSignature tag exactly matches the string stored in the ProfileCalibrationSignature tag for the selected camera profile.</summary>
        Image_CameraCalibrationSignature = 0xc6f3,

        ///<summary>Byte - A UTF-8 encoded string associated with the camera profile tags. The CameraCalibration1 and CameraCalibration2 tags should only be used in the DNG color transfer if the string stored in the CameraCalibrationSignature tag exactly matches the string stored in the ProfileCalibrationSignature tag for the selected camera profile.</summary>
        Image_ProfileCalibrationSignature = 0xc6f4,

        ///<summary>Byte - A UTF-8 encoded string containing the name of the "as shot" camera profile, if any.</summary>
        Image_AsShotProfileName = 0xc6f6,

        ///<summary>Rational - This tag indicates how much noise reduction has been applied to the raw data on a scale of 0.0 to 1.0. A 0.0 value indicates that no noise reduction has been applied. A 1.0 value indicates that the "ideal" amount of noise reduction has been applied, i.e. that the DNG reader should not apply additional noise reduction by default. A value of 0/0 indicates that this parameter is unknown.</summary>
        Image_NoiseReductionApplied = 0xc6f7,

        ///<summary>Byte - A UTF-8 encoded string containing the name of the camera profile. This tag is optional if there is only a single camera profile stored in the file but is required for all camera profiles if there is more than one camera profile stored in the file.</summary>
        Image_ProfileName = 0xc6f8,

        ///<summary>Long - This tag specifies the number of input samples in each dimension of the hue/saturation/value mapping tables. The data for these tables are stored in ProfileHueSatMapData1 and ProfileHueSatMapData2 tags. The most common case has ValueDivisions equal to 1, so only hue and saturation are used as inputs to the mapping table.</summary>
        Image_ProfileHueSatMapDims = 0xc6f9,

        ///<summary>Float - This tag contains the data for the first hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees, the second entry is saturation scale factor, and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order, with the value divisions in the outer loop, the hue divisions in the middle loop, and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.</summary>
        Image_ProfileHueSatMapData1 = 0xc6fa,

        ///<summary>Float - This tag contains the data for the second hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees, the second entry is a saturation scale factor, and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order, with the value divisions in the outer loop, the hue divisions in the middle loop, and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.</summary>
        Image_ProfileHueSatMapData2 = 0xc6fb,

        ///<summary>Float - This tag contains a default tone curve that can be applied while processing the image as a starting point for user adjustments. The curve is specified as a list of 32-bit IEEE floating-point value pairs in linear gamma. Each sample has an input value in the range of 0.0 to 1.0, and an output value in the range of 0.0 to 1.0. The first sample is required to be (0.0, 0.0), and the last sample is required to be (1.0, 1.0). Interpolated the curve using a cubic spline.</summary>
        Image_ProfileToneCurve = 0xc6fc,

        ///<summary>Long - This tag contains information about the usage rules for the associated camera profile.</summary>
        Image_ProfileEmbedPolicy = 0xc6fd,

        ///<summary>Byte - A UTF-8 encoded string containing the copyright information for the camera profile. This string always should be preserved along with the other camera profile tags.</summary>
        Image_ProfileCopyright = 0xc6fe,

        ///<summary>SRational - This tag defines a matrix that maps white balanced camera colors to XYZ D50 colors.</summary>
        Image_ForwardMatrix1 = 0xc714,

        ///<summary>SRational - This tag defines a matrix that maps white balanced camera colors to XYZ D50 colors.</summary>
        Image_ForwardMatrix2 = 0xc715,

        ///<summary>Byte - A UTF-8 encoded string containing the name of the application that created the preview stored in the IFD.</summary>
        Image_PreviewApplicationName = 0xc716,

        ///<summary>Byte - A UTF-8 encoded string containing the version number of the application that created the preview stored in the IFD.</summary>
        Image_PreviewApplicationVersion = 0xc717,

        ///<summary>Byte - A UTF-8 encoded string containing the name of the conversion settings (for example, snapshot name) used for the preview stored in the IFD.</summary>
        Image_PreviewSettingsName = 0xc718,

        ///<summary>Byte - A unique ID of the conversion settings (for example, MD5 digest) used to render the preview stored in the IFD.</summary>
        Image_PreviewSettingsDigest = 0xc719,

        ///<summary>Long - This tag specifies the color space in which the rendered preview in this IFD is stored. The default value for this tag is sRGB for color previews and Gray Gamma 2.2 for monochrome previews.</summary>
        Image_PreviewColorSpace = 0xc71a,

        ///<summary>Ascii - This tag is an ASCII string containing the name of the date/time at which the preview stored in the IFD was rendered. The date/time is encoded using ISO 8601 format.</summary>
        Image_PreviewDateTime = 0xc71b,

        ///<summary>Undefined - This tag is an MD5 digest of the raw image data. All pixels in the image are processed in row-scan order. Each pixel is zero padded to 16 or 32 bits deep (16-bit for data less than or equal to 16 bits deep, 32-bit otherwise). The data for each pixel is processed in little-endian byte order.</summary>
        Image_RawImageDigest = 0xc71c,

        ///<summary>Undefined - This tag is an MD5 digest of the data stored in the OriginalRawFileData tag.</summary>
        Image_OriginalRawFileDigest = 0xc71d,

        ///<summary>Long - Normally, the pixels within a tile are stored in simple row-scan order. This tag specifies that the pixels within a tile should be grouped first into rectangular blocks of the specified size. These blocks are stored in row-scan order. Within each block, the pixels are stored in row-scan order. The use of a non-default value for this tag requires setting the DNGBackwardVersion tag to at least 1.2.0.0.</summary>
        Image_SubTileBlockSize = 0xc71e,

        ///<summary>Long - This tag specifies that rows of the image are stored in interleaved order. The value of the tag specifies the number of interleaved fields. The use of a non-default value for this tag requires setting the DNGBackwardVersion tag to at least 1.2.0.0.</summary>
        Image_RowInterleaveFactor = 0xc71f,

        ///<summary>Long - This tag specifies the number of input samples in each dimension of a default "look" table. The data for this table is stored in the ProfileLookTableData tag.</summary>
        Image_ProfileLookTableDims = 0xc725,

        ///<summary>Float - This tag contains a default "look" table that can be applied while processing the image as a starting point for user adjustment. This table uses the same format as the tables stored in the ProfileHueSatMapData1 and ProfileHueSatMapData2 tags, and is applied in the same color space. However, it should be applied later in the processing pipe, after any exposure compensation and/or fill light stages, but before any tone curve stage. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees, the second entry is a saturation scale factor, and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order, with the value divisions in the outer loop, the hue divisions in the middle loop, and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.</summary>
        Image_ProfileLookTableData = 0xc726,

        ///<summary>Undefined - Specifies the list of opcodes that should be applied to the raw image, as read directly from the file.</summary>
        Image_OpcodeList1 = 0xc740,

        ///<summary>Undefined - Specifies the list of opcodes that should be applied to the raw image, just after it has been mapped to linear reference values.</summary>
        Image_OpcodeList2 = 0xc741,

        ///<summary>Undefined - Specifies the list of opcodes that should be applied to the raw image, just after it has been demosaiced.</summary>
        Image_OpcodeList3 = 0xc74e,

        ///<summary>Double - NoiseProfile describes the amount of noise in a raw image. Specifically, this tag models the amount of signal-dependent photon (shot) noise and signal-independent sensor readout noise, two common sources of noise in raw images. The model assumes that the noise is white and spatially independent, ignoring fixed pattern effects and other sources of noise (e.g., pixel response non-uniformity, spatially-dependent thermal effects, etc.).</summary>
        Image_NoiseProfile = 0xc761,

        ///<summary>Rational - Exposure time, given in seconds (sec).</summary>
        Photo_ExposureTime = 0x829a,

        ///<summary>Rational - The F number.</summary>
        Photo_FNumber = 0x829d,

        ///<summary>Short - The class of the program used by the camera to set exposure when the picture is taken.</summary>
        Photo_ExposureProgram = 0x8822,

        ///<summary>Ascii - Indicates the spectral sensitivity of each channel of the camera used. The tag value is an ASCII string compatible with the standard developed by the ASTM Technical Committee.</summary>
        Photo_SpectralSensitivity = 0x8824,

        ///<summary>Short - Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.</summary>
        Photo_ISOSpeedRatings = 0x8827,

        ///<summary>Undefined - Indicates the Opto-Electoric Conversion Function (OECF) specified in ISO 14524. <OECF> is the relationship between the camera optical input and the image values.</summary>
        Photo_OECF = 0x8828,

        ///<summary>Short - The SensitivityType tag indicates which one of the parameters of ISO12232 is the PhotographicSensitivity tag. Although it is an optional tag, it should be recorded when a PhotographicSensitivity tag is recorded. Value = 4, 5, 6, or 7 may be used in case that the values of plural parameters are the same.</summary>
        Photo_SensitivityType = 0x8830,

        ///<summary>Long - This tag indicates the standard output sensitivity value of a camera or input device defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.</summary>
        Photo_StandardOutputSensitivity = 0x8831,

        ///<summary>Long - This tag indicates the recommended exposure index value of a camera or input device defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.</summary>
        Photo_RecommendedExposureIndex = 0x8832,

        ///<summary>Long - This tag indicates the ISO speed value of a camera or input device that is defined in ISO 12232. When recording this tag, the PhotographicSensitivity and SensitivityType tags shall also be recorded.</summary>
        Photo_ISOSpeed = 0x8833,

        ///<summary>Long - This tag indicates the ISO speed latitude yyy value of a camera or input device that is defined in ISO 12232. However, this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudezzz.</summary>
        Photo_ISOSpeedLatitudeyyy = 0x8834,

        ///<summary>Long - This tag indicates the ISO speed latitude zzz value of a camera or input device that is defined in ISO 12232. However, this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudeyyy.</summary>
        Photo_ISOSpeedLatitudezzz = 0x8835,

        ///<summary>Undefined - The version of this standard supported. Nonexistence of this field is taken to mean nonconformance to the standard.</summary>
        Photo_ExifVersion = 0x9000,

        ///<summary>Ascii - The date and time when the original image data was generated. For a digital still camera the date and time the picture was taken are recorded.</summary>
        Photo_DateTimeOriginal = 0x9003,

        ///<summary>Ascii - The date and time when the image was stored as digital data.</summary>
        Photo_DateTimeDigitized = 0x9004,

        ///<summary>Undefined - Information specific to compressed data. The channels of each component are arranged in order from the 1st component to the 4th. For uncompressed data the data arrangement is given in the <PhotometricInterpretation> tag. However, since <PhotometricInterpretation> can only express the order of Y, Cb and Cr, this tag is provided for cases when compressed data uses components other than Y, Cb, and Cr and to enable support of other sequences.</summary>
        Photo_ComponentsConfiguration = 0x9101,

        ///<summary>Rational - Information specific to compressed data. The compression mode used for a compressed image is indicated in unit bits per pixel.</summary>
        Photo_CompressedBitsPerPixel = 0x9102,

        ///<summary>SRational - Shutter speed. The unit is the APEX (Additive System of Photographic Exposure) setting.</summary>
        Photo_ShutterSpeedValue = 0x9201,

        ///<summary>Rational - The lens aperture. The unit is the APEX value.</summary>
        Photo_ApertureValue = 0x9202,

        ///<summary>SRational - The value of brightness. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.</summary>
        Photo_BrightnessValue = 0x9203,

        ///<summary>SRational - The exposure bias. The units is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.</summary>
        Photo_ExposureBiasValue = 0x9204,

        ///<summary>Rational - The smallest F number of the lens. The unit is the APEX value. Ordinarily it is given in the range of 00.00 to 99.99, but it is not limited to this range.</summary>
        Photo_MaxApertureValue = 0x9205,

        ///<summary>Rational - The distance to the subject, given in meters.</summary>
        Photo_SubjectDistance = 0x9206,

        ///<summary>Short - The metering mode.</summary>
        Photo_MeteringMode = 0x9207,

        ///<summary>Short - The kind of light source.</summary>
        Photo_LightSource = 0x9208,

        ///<summary>Short - This tag is recorded when an image is taken using a strobe light (flash).</summary>
        Photo_Flash = 0x9209,

        ///<summary>Rational - The actual focal length of the lens, in mm. Conversion is not made to the focal length of a 35 mm film camera.</summary>
        Photo_FocalLength = 0x920a,

        ///<summary>Short - This tag indicates the location and area of the main subject in the overall scene.</summary>
        Photo_SubjectArea = 0x9214,

        ///<summary>Undefined - A tag for manufacturers of Exif writers to record any desired information. The contents are up to the manufacturer.</summary>
        Photo_MakerNote = 0x927c,

        ///<summary>Comment - A tag for Exif users to write keywords or comments on the image besides those in ImageDescription, and without the character code limitations of the <ImageDescription> tag.</summary>
        Photo_UserComment = 0x9286,

        ///<summary>Ascii - A tag used to record fractions of seconds for the DateTime tag.</summary>
        Photo_SubSecTime = 0x9290,

        ///<summary>Ascii - A tag used to record fractions of seconds for the DateTimeOriginal tag.</summary>
        Photo_SubSecTimeOriginal = 0x9291,

        ///<summary>Ascii - A tag used to record fractions of seconds for the DateTimeDigitized tag.</summary>
        Photo_SubSecTimeDigitized = 0x9292,

        ///<summary>Undefined - The FlashPix format version supported by a FPXR file.</summary>
        Photo_FlashpixVersion = 0xa000,

        ///<summary>Short - The color space information tag is always recorded as the color space specifier. Normally sRGB is used to define the color space based on the PC monitor conditions and environment. If a color space other than sRGB is used, Uncalibrated is set. Image data recorded as Uncalibrated can be treated as sRGB when it is converted to FlashPix.</summary>
        Photo_ColorSpace = 0xa001,

        ///<summary>Long - Information specific to compressed data. When a compressed file is recorded, the valid width of the meaningful image must be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file.</summary>
        Photo_PixelXDimension = 0xa002,

        ///<summary>Long - Information specific to compressed data. When a compressed file is recorded, the valid height of the meaningful image must be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file. Since data padding is unnecessary in the vertical direction, the number of lines recorded in this valid image height tag will in fact be the same as that recorded in the SOF.</summary>
        Photo_PixelYDimension = 0xa003,

        ///<summary>Ascii - This tag is used to record the name of an audio file related to the image data. The only relational information recorded here is the Exif audio file name and extension (an ASCII string consisting of 8 characters + '.' + 3 characters). The path is not recorded.</summary>
        Photo_RelatedSoundFile = 0xa004,

        ///<summary>Long - Interoperability IFD is composed of tags which stores the information to ensure the Interoperability and pointed by the following tag located in Exif IFD. The Interoperability structure of Interoperability IFD is the same as TIFF defined IFD structure but does not contain the image data characteristically compared with normal TIFF IFD.</summary>
        Photo_InteroperabilityTag = 0xa005,

        ///<summary>Rational - Indicates the strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds (BCPS).</summary>
        Photo_FlashEnergy = 0xa20b,

        ///<summary>Undefined - This tag records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.</summary>
        Photo_SpatialFrequencyResponse = 0xa20c,

        ///<summary>Rational - Indicates the number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.</summary>
        Photo_FocalPlaneXResolution = 0xa20e,

        ///<summary>Rational - Indicates the number of pixels in the image height (V) direction per FocalPlaneResolutionUnit on the camera focal plane.</summary>
        Photo_FocalPlaneYResolution = 0xa20f,

        ///<summary>Short - Indicates the unit for measuring FocalPlaneXResolution and FocalPlaneYResolution. This value is the same as the ResolutionUnit.</summary>
        Photo_FocalPlaneResolutionUnit = 0xa210,

        ///<summary>Short - Indicates the location of the main subject in the scene. The value of this tag represents the pixel at the center of the main subject relative to the left edge, prior to rotation processing as per the <Rotation> tag. The first value indicates the X column number and second indicates the Y row number.</summary>
        Photo_SubjectLocation = 0xa214,

        ///<summary>Rational - Indicates the exposure index selected on the camera or input device at the time the image is captured.</summary>
        Photo_ExposureIndex = 0xa215,

        ///<summary>Short - Indicates the image sensor type on the camera or input device.</summary>
        Photo_SensingMethod = 0xa217,

        ///<summary>Undefined - Indicates the image source. If a DSC recorded the image, this tag value of this tag always be set to 3, indicating that the image was recorded on a DSC.</summary>
        Photo_FileSource = 0xa300,

        ///<summary>Undefined - Indicates the type of scene. If a DSC recorded the image, this tag value must always be set to 1, indicating that the image was directly photographed.</summary>
        Photo_SceneType = 0xa301,

        ///<summary>Undefined - Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods.</summary>
        Photo_CFAPattern = 0xa302,

        ///<summary>Short - This tag indicates the use of special processing on image data, such as rendering geared to output. When special processing is performed, the reader is expected to disable or minimize any further processing.</summary>
        Photo_CustomRendered = 0xa401,

        ///<summary>Short - This tag indicates the exposure mode set when the image was shot. In auto-bracketing mode, the camera shoots a series of frames of the same scene at different exposure settings.</summary>
        Photo_ExposureMode = 0xa402,

        ///<summary>Short - This tag indicates the white balance mode set when the image was shot.</summary>
        Photo_WhiteBalance = 0xa403,

        ///<summary>Rational - This tag indicates the digital zoom ratio when the image was shot. If the numerator of the recorded value is 0, this indicates that digital zoom was not used.</summary>
        Photo_DigitalZoomRatio = 0xa404,

        ///<summary>Short - This tag indicates the equivalent focal length assuming a 35mm film camera, in mm. A value of 0 means the focal length is unknown. Note that this tag differs from the <FocalLength> tag.</summary>
        Photo_FocalLengthIn35mmFilm = 0xa405,

        ///<summary>Short - This tag indicates the type of scene that was shot. It can also be used to record the mode in which the image was shot. Note that this differs from the <SceneType> tag.</summary>
        Photo_SceneCaptureType = 0xa406,

        ///<summary>Short - This tag indicates the degree of overall image gain adjustment.</summary>
        Photo_GainControl = 0xa407,

        ///<summary>Short - This tag indicates the direction of contrast processing applied by the camera when the image was shot.</summary>
        Photo_Contrast = 0xa408,

        ///<summary>Short - This tag indicates the direction of saturation processing applied by the camera when the image was shot.</summary>
        Photo_Saturation = 0xa409,

        ///<summary>Short - This tag indicates the direction of sharpness processing applied by the camera when the image was shot.</summary>
        Photo_Sharpness = 0xa40a,

        ///<summary>Undefined - This tag indicates information on the picture-taking conditions of a particular camera model. The tag is used only to indicate the picture-taking conditions in the reader.</summary>
        Photo_DeviceSettingDescription = 0xa40b,

        ///<summary>Short - This tag indicates the distance to the subject.</summary>
        Photo_SubjectDistanceRange = 0xa40c,

        ///<summary>Ascii - This tag indicates an identifier assigned uniquely to each image. It is recorded as an ASCII string equivalent to hexadecimal notation and 128-bit fixed length.</summary>
        Photo_ImageUniqueID = 0xa420,

        ///<summary>Ascii - This tag records the owner of a camera used in photography as an ASCII string.</summary>
        Photo_CameraOwnerName = 0xa430,

        ///<summary>Ascii - This tag records the serial number of the body of the camera that was used in photography as an ASCII string.</summary>
        Photo_BodySerialNumber = 0xa431,

        ///<summary>Rational - This tag notes minimum focal length, maximum focal length, minimum F number in the minimum focal length, and minimum F number in the maximum focal length, which are specification information for the lens that was used in photography. When the minimum F number is unknown, the notation is 0/0</summary>
        Photo_LensSpecification = 0xa432,

        ///<summary>Ascii - This tag records the lens manufactor as an ASCII string.</summary>
        Photo_LensMake = 0xa433,

        ///<summary>Ascii - This tag records the lens's model name and model number as an ASCII string.</summary>
        Photo_LensModel = 0xa434,

        ///<summary>Ascii - This tag records the serial number of the interchangeable lens that was used in photography as an ASCII string.</summary>
        Photo_LensSerialNumber = 0xa435,

        ///<summary>Ascii - Indicates the identification of the Interoperability rule. Use "R98" for stating ExifR98 Rules. Four bytes used including the termination code (NULL). see the separate volume of Recommended Exif Interoperability Rules (ExifR98) for other tags used for ExifR98.</summary>
        Iop_InteroperabilityIndex = 0x0001,

        ///<summary>Undefined - Interoperability version</summary>
        Iop_InteroperabilityVersion = 0x0002,

        ///<summary>Ascii - File format of image file</summary>
        Iop_RelatedImageFileFormat = 0x1000,

        ///<summary>Long - Image width</summary>
        Iop_RelatedImageWidth = 0x1001,

        ///<summary>Long - Image height</summary>
        Iop_RelatedImageLength = 0x1002,

        ///<summary>Byte - Indicates the version of GPSInfoIF>. The version is given as 2.0.0.0. This tag is mandatory when GPSInfo tag is present. (Note: The GPSVersionID tag is given in bytes, unlike the ExifVersion tag. When the version is 2.0.0.0, the tag value is 02000000.H).</summary>
        GPSInfo_GPSVersionID = 0x0000,

        ///<summary>Ascii - Indicates whether the latitude is north or south latitude. The ASCII value 'N' indicates north latitude, and 'S' is south latitude.</summary>
        GPSInfo_GPSLatitudeRef = 0x0001,

        ///<summary>Rational - Indicates the latitude. The latitude is expressed as three RATIONAL values giving the degrees, minutes, and seconds, respectively. When degrees, minutes and seconds are expressed, the format is dd/1,mm/1,ss/1. When degrees and minutes are used and, for example, fractions of minutes are given up to two decimal places, the format is dd/1,mmmm/100,0/1.</summary>
        GPSInfo_GPSLatitude = 0x0002,

        ///<summary>Ascii - Indicates whether the longitude is east or west longitude. ASCII 'E' indicates east longitude, and 'W' is west longitude.</summary>
        GPSInfo_GPSLongitudeRef = 0x0003,

        ///<summary>Rational - Indicates the longitude. The longitude is expressed as three RATIONAL values giving the degrees, minutes, and seconds, respectively. When degrees, minutes and seconds are expressed, the format is ddd/1,mm/1,ss/1. When degrees and minutes are used and, for example, fractions of minutes are given up to two decimal places, the format is ddd/1,mmmm/100,0/1.</summary>
        GPSInfo_GPSLongitude = 0x0004,

        ///<summary>Byte - Indicates the altitude used as the reference altitude. If the reference is sea level and the altitude is above sea level, 0 is given. If the altitude is below sea level, a value of 1 is given and the altitude is indicated as an absolute value in the GSPAltitude tag. The reference unit is meters. Note that this tag is BYTE type, unlike other reference tags.</summary>
        GPSInfo_GPSAltitudeRef = 0x0005,

        ///<summary>Rational - Indicates the altitude based on the reference in GPSAltitudeRef. Altitude is expressed as one RATIONAL value. The reference unit is meters.</summary>
        GPSInfo_GPSAltitude = 0x0006,

        ///<summary>Rational - Indicates the time as UTC (Coordinated Universal Time). TimeStamp is expressed as three RATIONAL values giving the hour, minute, and second (atomic clock).</summary>
        GPSInfo_GPSTimeStamp = 0x0007,

        ///<summary>Ascii - Indicates the GPS satellites used for measurements. This tag can be used to describe the number of satellites, their ID number, angle of elevation, azimuth, SNR and other information in ASCII notation. The format is not specified. If the GPS receiver is incapable of taking measurements, value of the tag is set to NULL.</summary>
        GPSInfo_GPSSatellites = 0x0008,

        ///<summary>Ascii - Indicates the status of the GPS receiver when the image is recorded. "A" means measurement is in progress, and "V" means the measurement is Interoperability.</summary>
        GPSInfo_GPSStatus = 0x0009,

        ///<summary>Ascii - Indicates the GPS measurement mode. "2" means two-dimensional measurement and "3" means three-dimensional measurement is in progress.</summary>
        GPSInfo_GPSMeasureMode = 0x000a,

        ///<summary>Rational - Indicates the GPS DOP (data degree of precision). An HDOP value is written during two-dimensional measurement, and PDOP during three-dimensional measurement.</summary>
        GPSInfo_GPSDOP = 0x000b,

        ///<summary>Ascii - Indicates the unit used to express the GPS receiver speed of movement. "K" "M" and "N" represents kilometers per hour, miles per hour, and knots.</summary>
        GPSInfo_GPSSpeedRef = 0x000c,

        ///<summary>Rational - Indicates the speed of GPS receiver movement.</summary>
        GPSInfo_GPSSpeed = 0x000d,

        ///<summary>Ascii - Indicates the reference for giving the direction of GPS receiver movement. "T" denotes true direction and "M" is magnetic direction.</summary>
        GPSInfo_GPSTrackRef = 0x000e,

        ///<summary>Rational - Indicates the direction of GPS receiver movement. The range of values is from 0.00 to 359.99.</summary>
        GPSInfo_GPSTrack = 0x000f,

        ///<summary>Ascii - Indicates the reference for giving the direction of the image when it is captured. "T" denotes true direction and "M" is magnetic direction.</summary>
        GPSInfo_GPSImgDirectionRef = 0x0010,

        ///<summary>Rational - Indicates the direction of the image when it was captured. The range of values is from 0.00 to 359.99.</summary>
        GPSInfo_GPSImgDirection = 0x0011,

        ///<summary>Ascii - Indicates the geodetic survey data used by the GPS receiver. If the survey data is restricted to Japan, the value of this tag is "TOKYO" or "WGS-84".</summary>
        GPSInfo_GPSMapDatum = 0x0012,

        ///<summary>Ascii - Indicates whether the latitude of the destination point is north or south latitude. The ASCII value "N" indicates north latitude, and "S" is south latitude.</summary>
        GPSInfo_GPSDestLatitudeRef = 0x0013,

        ///<summary>Rational - Indicates the latitude of the destination point. The latitude is expressed as three RATIONAL values giving the degrees, minutes, and seconds, respectively. If latitude is expressed as degrees, minutes and seconds, a typical format would be dd/1,mm/1,ss/1. When degrees and minutes are used and, for example, fractions of minutes are given up to two decimal places, the format would be dd/1,mmmm/100,0/1.</summary>
        GPSInfo_GPSDestLatitude = 0x0014,

        ///<summary>Ascii - Indicates whether the longitude of the destination point is east or west longitude. ASCII "E" indicates east longitude, and "W" is west longitude.</summary>
        GPSInfo_GPSDestLongitudeRef = 0x0015,

        ///<summary>Rational - Indicates the longitude of the destination point. The longitude is expressed as three RATIONAL values giving the degrees, minutes, and seconds, respectively. If longitude is expressed as degrees, minutes and seconds, a typical format would be ddd/1,mm/1,ss/1. When degrees and minutes are used and, for example, fractions of minutes are given up to two decimal places, the format would be ddd/1,mmmm/100,0/1.</summary>
        GPSInfo_GPSDestLongitude = 0x0016,

        ///<summary>Ascii - Indicates the reference used for giving the bearing to the destination point. "T" denotes true direction and "M" is magnetic direction.</summary>
        GPSInfo_GPSDestBearingRef = 0x0017,

        ///<summary>Rational - Indicates the bearing to the destination point. The range of values is from 0.00 to 359.99.</summary>
        GPSInfo_GPSDestBearing = 0x0018,

        ///<summary>Ascii - Indicates the unit used to express the distance to the destination point. "K", "M" and "N" represent kilometers, miles and knots.</summary>
        GPSInfo_GPSDestDistanceRef = 0x0019,

        ///<summary>Rational - Indicates the distance to the destination point.</summary>
        GPSInfo_GPSDestDistance = 0x001a,

        ///<summary>Undefined - A character string recording the name of the method used for location finding. The first byte indicates the character code used, and this is followed by the name of the method.</summary>
        GPSInfo_GPSProcessingMethod = 0x001b,

        ///<summary>Undefined - A character string recording the name of the GPS area. The first byte indicates the character code used, and this is followed by the name of the GPS area.</summary>
        GPSInfo_GPSAreaInformation = 0x001c,

        ///<summary>Ascii - A character string recording date and time information relative to UTC (Coordinated Universal Time). The format is "YYYY:MM:DD.".</summary>
        GPSInfo_GPSDateStamp = 0x001d,

        ///<summary>Short - Indicates whether differential correction is applied to the GPS receiver.</summary>
        GPSInfo_GPSDifferential = 0x001e


    }
}