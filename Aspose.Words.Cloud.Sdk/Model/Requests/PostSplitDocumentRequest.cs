// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostSplitDocumentRequest.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.PostSplitDocument" /> operation.
  /// </summary>  
  public class PostSplitDocumentRequest : ICanModifyDocumentRequest, IWordDocumentRequest, ICanUseCustomFontsRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSplitDocumentRequest"/> class.
        /// </summary>        
        public PostSplitDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostSplitDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">Original document name.</param>
        /// <param name="destFileName">Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="fontsLocation">Folder in filestorage with custom fonts.</param>
        /// <param name="format">Format to split.</param>
        /// <param name="from">Start page.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="storage">File storage, which have to be used.</param>
        /// <param name="to">End page.</param>
        /// <param name="zipOutput">ZipOutput or not.</param>
        public PostSplitDocumentRequest(string name, string destFileName = null, string folder = null, string fontsLocation = null, string format = null, int? from = null, string loadEncoding = null, string password = null, string storage = null, int? to = null, bool? zipOutput = null)             
        {
            this.Name = name;
            this.DestFileName = destFileName;
            this.Folder = folder;
            this.FontsLocation = fontsLocation;
            this.Format = format;
            this.From = from;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.Storage = storage;
            this.To = to;
            this.ZipOutput = zipOutput;
        }

        /// <summary>
        /// Original document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        public string FontsLocation { get; set; }

        /// <summary>
        /// Format to split.
        /// </summary>  
        public string Format { get; set; }

        /// <summary>
        /// Start page.
        /// </summary>  
        public int? From { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// End page.
        /// </summary>  
        public int? To { get; set; }

        /// <summary>
        /// ZipOutput or not.
        /// </summary>  
        public bool? ZipOutput { get; set; }
  }
}