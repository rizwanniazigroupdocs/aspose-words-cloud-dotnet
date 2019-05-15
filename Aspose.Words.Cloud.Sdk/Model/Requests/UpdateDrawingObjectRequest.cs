// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="UpdateDrawingObjectRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.UpdateDrawingObject" /> operation.
  /// </summary>  
  public class UpdateDrawingObjectRequest : ICanModifyDocumentRequest, ICanSaveRevisionRequest, IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrawingObjectRequest"/> class.
        /// </summary>        
        public UpdateDrawingObjectRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDrawingObjectRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="drawingObject">Drawing object parameters</param>
        /// <param name="imageFile">File with image</param>
        /// <param name="index">Object index.</param>
        /// <param name="nodePath">Path to the node, which contains collection of drawing objects.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        /// <param name="revisionAuthor">Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.</param>
        /// <param name="revisionDateTime">The date and time to use for revisions.</param>
        public UpdateDrawingObjectRequest(string name, string drawingObject, System.IO.Stream imageFile, int? index, string nodePath, string folder = null, string storage = null, string loadEncoding = null, string password = null, string destFileName = null, string revisionAuthor = null, string revisionDateTime = null)             
        {
            this.Name = name;
            this.DrawingObject = drawingObject;
            this.ImageFile = imageFile;
            this.Index = index;
            this.NodePath = nodePath;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
            this.RevisionAuthor = revisionAuthor;
            this.RevisionDateTime = revisionDateTime;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Drawing object parameters
        /// </summary>  
        public string DrawingObject { get; set; }

        /// <summary>
        /// File with image
        /// </summary>  
        public System.IO.Stream ImageFile { get; set; }

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

        /// <summary>
        /// Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        public string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public string RevisionDateTime { get; set; }
  }
}