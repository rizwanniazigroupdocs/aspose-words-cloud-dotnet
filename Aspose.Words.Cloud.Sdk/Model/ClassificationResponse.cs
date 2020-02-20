// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ClassificationResponse.cs">
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

namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// This response should be returned by the service when handling: PUT https://api.aspose.cloud/v4.0/words/classify.
  /// </summary>  
  public class ClassificationResponse : WordsResponse 
  {                       
        /// <summary>
        /// Gets or sets best class name.
        /// </summary>  
        public string BestClassName { get; set; }

        /// <summary>
        /// Gets or sets best class probability.
        /// </summary>  
        public double? BestClassProbability { get; set; }

        /// <summary>
        /// Gets or sets array of best classes results.
        /// </summary>  
        public List<ClassificationResult> BestResults { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClassificationResponse {\n");
          sb.Append("  BestClassName: ").Append(this.BestClassName).Append("\n");
          sb.Append("  BestClassProbability: ").Append(this.BestClassProbability).Append("\n");
          sb.Append("  BestResults: ").Append(this.BestResults).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
