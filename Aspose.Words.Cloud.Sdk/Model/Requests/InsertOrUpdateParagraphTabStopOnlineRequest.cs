// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="InsertOrUpdateParagraphTabStopOnlineRequest.cs">
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
    using Aspose.Words.Cloud.Sdk.Model;

    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.InsertOrUpdateParagraphTabStopOnline" /> operation.
    /// </summary>
    public class InsertOrUpdateParagraphTabStopOnlineRequest : ICanModifyDocumentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertOrUpdateParagraphTabStopOnlineRequest"/> class.
        /// </summary>        
        public InsertOrUpdateParagraphTabStopOnlineRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertOrUpdateParagraphTabStopOnlineRequest"/> class.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="tabStopInsertDto">TabStopInsert dto.</param>
        /// <param name="index">Object index.</param>
        /// <param name="nodePath">Path to the node which contains paragraph.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        /// <param name="destFileName">Result path of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.</param>
        public InsertOrUpdateParagraphTabStopOnlineRequest(System.IO.Stream document, TabStopInsert tabStopInsertDto, int index, string nodePath = null, string loadEncoding = null, string password = null, string destFileName = null)
        {
            this.Document = document;
            this.TabStopInsertDto = tabStopInsertDto;
            this.Index = index;
            this.NodePath = nodePath;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
            this.DestFileName = destFileName;
        }

        /// <summary>
        /// The document.
        /// </summary>
        public System.IO.Stream Document { get; set; }

        /// <summary>
        /// TabStopInsert dto.
        /// </summary>
        public TabStopInsert TabStopInsertDto { get; set; }

        /// <summary>
        /// Object index.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// Path to the node which contains paragraph.
        /// </summary>
        public string NodePath { get; set; }

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
    }
}
