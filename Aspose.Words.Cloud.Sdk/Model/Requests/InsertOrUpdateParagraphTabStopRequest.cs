// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InsertOrUpdateParagraphTabStopRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertOrUpdateParagraphTabStop" /> operation.
    /// </summary>
    public class InsertOrUpdateParagraphTabStopRequest : IRequestModel, IWordDocumentRequest, ICanModifyDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertOrUpdateParagraphTabStopRequest"/> class.
        /// </summary>
        public InsertOrUpdateParagraphTabStopRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertOrUpdateParagraphTabStopRequest"/> class.
        /// </summary>
        /// <param name="name">The filename of the input document.</param>
        /// <param name="index">Object index.</param>
        /// <param name="tabStopInsertDto">TabStopInsert dto.</param>
        /// <param name="nodePath">The path to the node in the document tree.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        public InsertOrUpdateParagraphTabStopRequest(string name, int index, TabStopInsert tabStopInsertDto, string nodePath = null, string folder = null, string storage = null, string loadEncoding = null, string password = null, string destFileName = null)
        {
            this.Name = name;
            this.Index = index;
            this.TabStopInsertDto = tabStopInsertDto;
            this.NodePath = nodePath;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
        }

        /// <summary>
        /// The filename of the input document.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Object index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// TabStopInsert dto.
        /// </summary>
        public TabStopInsert TabStopInsertDto { get; set; }

        /// <summary>
        /// The path to the node in the document tree.
        /// </summary>
        public string NodePath { get; set; }

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
        /// Creates the http request based on this request.
        /// </summary>
        /// <param name="configuration">SDK configuration.</param>
        /// <returns>The http request instance.</returns>
        public HttpRequestMessage CreateHttpRequest(Configuration configuration)
        {
            // verify the required parameter 'name' is set
            if (this.Name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling InsertOrUpdateParagraphTabStop");
            }

            // verify the required parameter 'tabStopInsertDto' is set
            if (this.TabStopInsertDto == null)
            {
                throw new ApiException(400, "Missing required parameter 'tabStopInsertDto' when calling InsertOrUpdateParagraphTabStop");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/{nodePath}/paragraphs/{index}/tabstops";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddPathParameter(path, "index", this.Index);
            path = UrlHelper.AddPathParameter(path, "nodePath", this.NodePath);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName);

            var result = new HttpRequestMessage(HttpMethod.Post, path);
            result.Content = ApiInvoker.GetBodyParameterData(this.TabStopInsertDto);
            return result;
        }

        /// <summary>
        /// Deserialize response object.
        /// </summary>
        /// <param name="message">Response message.</param>
        /// <returns>Response type.</returns>
        public object DeserializeResponse(HttpResponseMessage message)
        {
            return SerializationHelper.Deserialize(message.Content.ReadAsStringAsync().GetAwaiter().GetResult(), typeof(TabStopsResponse));
        }
    }
}
