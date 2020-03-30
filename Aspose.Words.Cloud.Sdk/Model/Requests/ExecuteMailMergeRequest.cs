// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExecuteMailMergeRequest.cs">
//   Copyright (c) 2019 Aspose.Words for Cloud
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
  using Aspose.Words.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.ExecuteMailMerge" /> operation.
  /// </summary>  
  public class ExecuteMailMergeRequest : ICanModifyDocumentRequest, IWordDocumentRequest, ICanSpecifyMailMergeParametersRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteMailMergeRequest"/> class.
        /// </summary>        
        public ExecuteMailMergeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteMailMergeRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="data">Mail merge data</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="withRegions">With regions flag.</param>
        /// <param name="mailMergeDataFile">Mail merge data.</param>
        /// <param name="cleanup">Clean up options.</param>
        /// <param name="useWholeParagraphAsRegion">Gets or sets a value indicating whether paragraph with TableStart or.             TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.             The default value is true.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.</param>
        public ExecuteMailMergeRequest(string name, string data = null, string folder = null, string storage = null, string loadEncoding = null, string password = null, bool? withRegions = null, string mailMergeDataFile = null, string cleanup = null, bool? useWholeParagraphAsRegion = null, string destFileName = null)             
        {
            this.Name = name;
            this.Data = data;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.WithRegions = withRegions;
            this.MailMergeDataFile = mailMergeDataFile;
            this.Cleanup = cleanup;
            this.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
            this.DestFileName = destFileName;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Mail merge data
        /// </summary>  
        public string Data { get; set; }

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
        /// With regions flag.
        /// </summary>  
        public bool? WithRegions { get; set; }

        /// <summary>
        /// Mail merge data.
        /// </summary>  
        public string MailMergeDataFile { get; set; }

        /// <summary>
        /// Clean up options.
        /// </summary>  
        public string Cleanup { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether paragraph with TableStart or.             TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.             The default value is true.
        /// </summary>  
        public bool? UseWholeParagraphAsRegion { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved with autogenerated name.
        /// </summary>  
        public string DestFileName { get; set; }
  }
}
