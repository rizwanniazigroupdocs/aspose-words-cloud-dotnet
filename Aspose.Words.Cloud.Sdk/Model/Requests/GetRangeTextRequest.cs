// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetRangeTextRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.GetRangeText" /> operation.
  /// </summary>  
  public class GetRangeTextRequest : IWordDocumentRequest   
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetRangeTextRequest"/> class.
        /// </summary>        
        public GetRangeTextRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRangeTextRequest"/> class.
        /// </summary>
        /// <param name="name">The document.</param>
        /// <param name="rangeStartIdentifier">The range start identifier. Identifier is the value of the &quot;nodeId&quot; field, which every document node has, extended with the prefix &quot;id&quot;. It looks like &quot;id0.0.7&quot;. Also values like &quot;image5&quot; and &quot;table3&quot; can be used as an identifier for images and tables, where the number is an index of the image/table.</param>
        /// <param name="rangeEndIdentifier">The range end identifier.</param>
        /// <param name="folder">Original document folder.</param>
        /// <param name="storage">Original document storage.</param>
        /// <param name="loadEncoding">Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.</param>
        /// <param name="password">Password for opening an encrypted document.</param>
        public GetRangeTextRequest( name rangeStartIdentifier rangeEndIdentifier = null folder = null storage = null loadEncoding = null password = null)             
        {
            this.Name = name;
            this.RangeStartIdentifier = rangeStartIdentifier;
            this.RangeEndIdentifier = rangeEndIdentifier;
            this.Folder = folder;
            this.Storage = storage;
            this.LoadEncoding = loadEncoding;
            this.Password = password;
        }

        /// <summary>
        /// The document.
        /// </summary>  
        public  Name { get; set; }
        /// <summary>
        /// The range start identifier. Identifier is the value of the "nodeId" field, which every document node has, extended with the prefix "id". It looks like "id0.0.7". Also values like "image5" and "table3" can be used as an identifier for images and tables, where the number is an index of the image/table.
        /// </summary>  
        public  RangeStartIdentifier { get; set; }
        /// <summary>
        /// The range end identifier.
        /// </summary>  
        public  RangeEndIdentifier { get; set; }
        /// <summary>
        /// Original document folder.
        /// </summary>  
        public  Folder { get; set; }
        /// <summary>
        /// Original document storage.
        /// </summary>  
        public  Storage { get; set; }
        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        public  LoadEncoding { get; set; }
        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        public  Password { get; set; }
  }
}
