// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SplitDocumentRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.SplitDocument" /> operation.
    /// </summary>
    public class SplitDocumentRequest : IRequestModel, ICanModifyDocumentRequest, IWordDocumentRequest, ICanUseCustomFontsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentRequest"/> class.
        /// </summary>
        public SplitDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">The filename of the input document.</param>
        /// <param name="format">The format to split.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="from">The start page.</param>
        /// <param name="to">The end page.</param>
        /// <param name="zipOutput">The flag indicating whether to ZIP the output.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        public SplitDocumentRequest(string name, string format, string folder = null, string storage = null, string loadEncoding = null, string password = null, string destFileName = null, int? from = null, int? to = null, bool? zipOutput = null, string fontsLocation = null)
        {
            this.Name = name;
            this.Format = format;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
            this.From = from;
            this.To = to;
            this.ZipOutput = zipOutput;
            this.FontsLocation = fontsLocation;
        }

        /// <summary>
        /// The filename of the input document.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The format to split.
        /// </summary>
        public string Format { get; set; }

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
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>
        public string DestFileName { get; set; }

        /// <summary>
        /// The start page.
        /// </summary>
        public int? From { get; set; }

        /// <summary>
        /// The end page.
        /// </summary>
        public int? To { get; set; }

        /// <summary>
        /// The flag indicating whether to ZIP the output.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling SplitDocument");
            }

            // verify the required parameter 'format' is set
            if (this.Format == null)
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling SplitDocument");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/split";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddQueryParameterToUrl(path, "format", this.Format);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName);
            path = UrlHelper.AddQueryParameterToUrl(path, "from", this.From);
            path = UrlHelper.AddQueryParameterToUrl(path, "to", this.To);
            path = UrlHelper.AddQueryParameterToUrl(path, "zipOutput", this.ZipOutput);
            path = UrlHelper.AddQueryParameterToUrl(path, "fontsLocation", this.FontsLocation);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return typeof(SplitDocumentResponse);
        }
    }
}
