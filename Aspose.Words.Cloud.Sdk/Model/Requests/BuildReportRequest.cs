// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BuildReportRequest.cs">
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
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.BuildReport" /> operation.
    /// </summary>
    public class BuildReportRequest : IRequestModel, ICanModifyDocumentRequest, IWordDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildReportRequest"/> class.
        /// </summary>
        public BuildReportRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildReportRequest"/> class.
        /// </summary>
        /// <param name="name">The filename of the input document.</param>
        /// <param name="data">A string providing a data to populate the specified template. The string must be of one of the following types: xml, json, csv.</param>
        /// <param name="reportEngineSettings">An object providing a settings of report engine.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">The filename of the output document. If this parameter is omitted, the result will be saved with autogenerated name.</param>
        public BuildReportRequest(string name, string data, ReportEngineSettings reportEngineSettings, string folder = null, string storage = null, string loadEncoding = null, string password = null, string destFileName = null)
        {
            this.Name = name;
            this.Data = data;
            this.ReportEngineSettings = reportEngineSettings;
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
        /// A string providing a data to populate the specified template. The string must be of one of the following types: xml, json, csv.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// An object providing a settings of report engine.
        /// </summary>
        public ReportEngineSettings ReportEngineSettings { get; set; }

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
        /// The filename of the output document. If this parameter is omitted, the result will be saved with autogenerated name.
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
                throw new ApiException(400, "Missing required parameter 'name' when calling BuildReport");
            }

            // verify the required parameter 'data' is set
            if (this.Data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling BuildReport");
            }

            // verify the required parameter 'reportEngineSettings' is set
            if (this.ReportEngineSettings == null)
            {
                throw new ApiException(400, "Missing required parameter 'reportEngineSettings' when calling BuildReport");
            }

            var path = configuration.GetApiRootUrl() + "/words/{name}/buildReport";
            path = Regex
                    .Replace(path, "\\*", string.Empty)
                    .Replace("&amp;", "&")
                    .Replace("/?", "?");
            path = UrlHelper.AddPathParameter(path, "name", this.Name);
            path = UrlHelper.AddQueryParameterToUrl(path, "folder", this.Folder);
            path = UrlHelper.AddQueryParameterToUrl(path, "storage", this.Storage);
            path = UrlHelper.AddQueryParameterToUrl(path, "loadEncoding", this.LoadEncoding);
            path = UrlHelper.AddQueryParameterToUrl(path, "password", this.Password);
            path = UrlHelper.AddQueryParameterToUrl(path, "destFileName", this.DestFileName);

            var result = new HttpRequestMessage(HttpMethod.Put, path);
            var formData = new Dictionary<string, object>();
            if (this.Data != null)
            {
                formData.Add("Data", this.Data);
            }

            if (this.ReportEngineSettings != null)
            {
                formData.Add("ReportEngineSettings", this.ReportEngineSettings);
            }

            if (formData.Count > 0)
            {
                result.Content = ApiInvoker.GetMultipartFormData(formData);
            }

            return result;
        }

        /// <summary>
        /// Returns type of operation response.
        /// </summary>
        /// <returns>Response type.</returns>
        public Type GetResponseType()
        {
            return typeof(DocumentResponse);
        }
    }
}
