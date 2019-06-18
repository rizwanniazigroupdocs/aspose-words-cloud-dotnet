// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDocumentDrawingObjectOleDataRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetDocumentDrawingObjectOleData" /> operation.
  /// </summary>  
  public class GetDocumentDrawingObjectOleDataRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectOleDataRequest"/> class.
        /// </summary>        
        public GetDocumentDrawingObjectOleDataRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentDrawingObjectOleDataRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="index">Object index.</param>
        /// <param name="nodePath">Path to the node, which contains collection of drawing objects.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetDocumentDrawingObjectOleDataRequest(string name, int? index, string nodePath, string folder = null, string storage = null, string loadEncoding = null, string password = null)             
        {
            this.Name = name;
            this.Index = index;
            this.NodePath = nodePath;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Object index.
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Path to the node, which contains collection of drawing objects.
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
  }
}
