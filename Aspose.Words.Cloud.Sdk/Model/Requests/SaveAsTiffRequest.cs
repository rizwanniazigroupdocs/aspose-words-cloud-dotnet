// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsTiffRequest.cs">
//   Copyright (c) 2020 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Model.Requests
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.SaveAsTiff" /> operation.
    /// </summary>
    public class SaveAsTiffRequest : IRequestModel, IWordDocumentRequest, ICanUseCustomFontsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsTiffRequest"/> class.
        /// </summary>
        public SaveAsTiffRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsTiffRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="saveOptions">Tiff save options.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="useAntiAliasing">Use antialiasing flag.</param>
        /// <param name="useHighQualityRendering">Use high quality flag.</param>
        /// <param name="imageBrightness">Brightness for the generated images.</param>
        /// <param name="imageColorMode">Color mode for the generated images.</param>
        /// <param name="imageContrast">The contrast for the generated images.</param>
        /// <param name="numeralFormat">The images numeral format.</param>
        /// <param name="pageCount">Number of pages to render.</param>
        /// <param name="pageIndex">Page index to start rendering.</param>
        /// <param name="paperColor">Background image color.</param>
        /// <param name="pixelFormat">The pixel format of generated images.</param>
        /// <param name="resolution">The resolution of generated images.</param>
        /// <param name="scale">Zoom factor for generated images.</param>
        /// <param name="tiffCompression">The compression tipe.</param>
        /// <param name="dmlRenderingMode">Optional, default is Fallback.</param>
        /// <param name="dmlEffectsRenderingMode">Optional, default is Simplified.</param>
        /// <param name="tiffBinarizationMethod">Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.</param>
        /// <param name="zipOutput">Optional. A value determining zip output or not.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public SaveAsTiffRequest(string name, TiffSaveOptionsData saveOptions, string folder = null, string storage = null, string loadEncoding = null, string password = null, bool? useAntiAliasing = null, bool? useHighQualityRendering = null, double? imageBrightness = null, string imageColorMode = null, double? imageContrast = null, string numeralFormat = null, int? pageCount = null, int? pageIndex = null, string paperColor = null, string pixelFormat = null, double? resolution = null, double? scale = null, string tiffCompression = null, string dmlRenderingMode = null, string dmlEffectsRenderingMode = null, string tiffBinarizationMethod = null, bool? zipOutput = null, string fontsLocation = null)
        {
            this.Name = name;
            this.SaveOptions = saveOptions;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.UseAntiAliasing = useAntiAliasing;
            this.UseHighQualityRendering = useHighQualityRendering;
            this.ImageBrightness = imageBrightness;
            this.ImageColorMode = imageColorMode;
            this.ImageContrast = imageContrast;
            this.NumeralFormat = numeralFormat;
            this.PageCount = pageCount;
            this.PageIndex = pageIndex;
            this.PaperColor = paperColor;
            this.PixelFormat = pixelFormat;
            this.Resolution = resolution;
            this.Scale = scale;
            this.TiffCompression = tiffCompression;
            this.DmlRenderingMode = dmlRenderingMode;
            this.DmlEffectsRenderingMode = dmlEffectsRenderingMode;
            this.TiffBinarizationMethod = tiffBinarizationMethod;
            this.ZipOutput = zipOutput;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The document name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tiff save options.
        /// </summary>
        public TiffSaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Use antialiasing flag.
        /// </summary>
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Use high quality flag.
        /// </summary>
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Brightness for the generated images.
        /// </summary>
        public double? ImageBrightness { get; set; }

        /// <summary>
        /// Color mode for the generated images.
        /// </summary>
        public string ImageColorMode { get; set; }

        /// <summary>
        /// The contrast for the generated images.
        /// </summary>
        public double? ImageContrast { get; set; }

        /// <summary>
        /// The images numeral format.
        /// </summary>
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Number of pages to render.
        /// </summary>
        public int? PageCount { get; set; }

        /// <summary>
        /// Page index to start rendering.
        /// </summary>
        public int? PageIndex { get; set; }

        /// <summary>
        /// Background image color.
        /// </summary>
        public string PaperColor { get; set; }

        /// <summary>
        /// The pixel format of generated images.
        /// </summary>
        public string PixelFormat { get; set; }

        /// <summary>
        /// The resolution of generated images.
        /// </summary>
        public double? Resolution { get; set; }

        /// <summary>
        /// Zoom factor for generated images.
        /// </summary>
        public double? Scale { get; set; }

        /// <summary>
        /// The compression tipe.
        /// </summary>
        public string TiffCompression { get; set; }

        /// <summary>
        /// Optional, default is Fallback.
        /// </summary>
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Optional, default is Simplified.
        /// </summary>
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold.
        /// </summary>
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Optional. A value determining zip output or not.
        /// </summary>
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>
        public string FontsLocation { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'name' is set
            if (this.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling SaveAsTiff");
            }

            // verify the required parameter 'saveOptions' is set
            if (this.SaveOptions == null)
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling SaveAsTiff");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/saveAs/tiff";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "useAntiAliasing", this.UseAntiAliasing);
            path = UrlHelper.AddQueryParameterToUrl(path, "useHighQualityRendering", this.UseHighQualityRendering);
            path = UrlHelper.AddQueryParameterToUrl(path, "imageBrightness", this.ImageBrightness);
            path = UrlHelper.AddQueryParameterToUrl(path, "imageColorMode", this.ImageColorMode);
            path = UrlHelper.AddQueryParameterToUrl(path, "imageContrast", this.ImageContrast);
            path = UrlHelper.AddQueryParameterToUrl(path, "numeralFormat", this.NumeralFormat);
            path = UrlHelper.AddQueryParameterToUrl(path, "pageCount", this.PageCount);
            path = UrlHelper.AddQueryParameterToUrl(path, "pageIndex", this.PageIndex);
            path = UrlHelper.AddQueryParameterToUrl(path, "paperColor", this.PaperColor);
            path = UrlHelper.AddQueryParameterToUrl(path, "pixelFormat", this.PixelFormat);
            path = UrlHelper.AddQueryParameterToUrl(path, "resolution", this.Resolution);
            path = UrlHelper.AddQueryParameterToUrl(path, "scale", this.Scale);
            path = UrlHelper.AddQueryParameterToUrl(path, "tiffCompression", this.TiffCompression);
            path = UrlHelper.AddQueryParameterToUrl(path, "dmlRenderingMode", this.DmlRenderingMode);
            path = UrlHelper.AddQueryParameterToUrl(path, "dmlEffectsRenderingMode", this.DmlEffectsRenderingMode);
            path = UrlHelper.AddQueryParameterToUrl(path, "tiffBinarizationMethod", this.TiffBinarizationMethod);
            path = UrlHelper.AddQueryParameterToUrl(path, "zipOutput", this.ZipOutput);
            path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            result.Content = ApiInvoker.GetBodyParameterData(this.SaveOptions);
            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return typeof(SaveResponse);
        }
    }
}
