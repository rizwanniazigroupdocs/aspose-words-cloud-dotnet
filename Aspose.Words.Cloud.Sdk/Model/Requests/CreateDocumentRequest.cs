// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CreateDocumentRequest.cs">
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
    using System.IO;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Responses;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.CreateDocument" /> operation.
    /// </summary>
    public class CreateDocumentRequest : IRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest"/> class.
        /// </summary>
        public CreateDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentRequest"/> class.
        /// </summary>
        /// <param name="fileName">The filename of the document.</param>
        /// <param name="folder">The path to the document folder.</param>
        /// <param name="storage">Original document storage.</param>
        public CreateDocumentRequest(string fileName = null, string folder = null, string storage = null)
        {
            this.FileName = fileName;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The filename of the document.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The path to the document folder.
        /// </summary>
        public string Folder { get; set; }

        /// <summary>
        /// Original document storage.
        /// </summary>
        public string Storage { get; set; }

        /// <summary>
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            var path = configuration.GetApiRootUrl() + "/words/create";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddQueryParameterToUrl(path, "fileName", this.FileName);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public object DeserializeResponse(HttpResponseMessage message)
        {
            return SerializationHelper.Deserialize(message.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(DocumentResponse));
        }
    }
}
