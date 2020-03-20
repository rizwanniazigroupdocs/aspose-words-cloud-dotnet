// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MoveFileRequest.cs">
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
  /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.WordsApi.MoveFile" /> operation.
  /// </summary>  
  public class MoveFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFileRequest"/> class.
        /// </summary>        
        public MoveFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveFileRequest"/> class.
        /// </summary>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        /// <param name="srcPath">Source file&#39;s path e.g. &#39;/Folder 1/file.ext&#39; or &#39;/Bucket/Folder 1/file.ext&#39;</param>
        /// <param name="srcStorageName">Source storage name</param>
        /// <param name="destStorageName">Destination storage name</param>
        /// <param name="versionId">File version ID to move</param>
        public MoveFileRequest( destPath srcPath srcStorageName = null destStorageName = null versionId = null)             
        {
            this.DestPath = destPath;
            this.SrcPath = srcPath;
            this.SrcStorageName = srcStorageName;
            this.DestStorageName = destStorageName;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Destination file path e.g. '/dest.ext'
        /// </summary>  
        public  DestPath { get; set; }
        /// <summary>
        /// Source file's path e.g. '/Folder 1/file.ext' or '/Bucket/Folder 1/file.ext'
        /// </summary>  
        public  SrcPath { get; set; }
        /// <summary>
        /// Source storage name
        /// </summary>  
        public  SrcStorageName { get; set; }
        /// <summary>
        /// Destination storage name
        /// </summary>  
        public  DestStorageName { get; set; }
        /// <summary>
        /// File version ID to move
        /// </summary>  
        public  VersionId { get; set; }
  }
}
