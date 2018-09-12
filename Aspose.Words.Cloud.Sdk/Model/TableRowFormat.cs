// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TableRowFormat.cs">
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
  /// 
  /// </summary>  
  public class TableRowFormat : LinkElement 
  {                       
        /// <summary>
        /// Gets or sets HeightRule
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HeightRuleEnum
        { 
            /// <summary>
            /// Enum AtLeast for "AtLeast"
            /// </summary>            
            AtLeast,
            
            /// <summary>
            /// Enum Exactly for "Exactly"
            /// </summary>            
            Exactly,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>            
            Auto            
        }

        /// <summary>
        /// Gets or sets HeightRule
        /// </summary>
        public HeightRuleEnum? HeightRule { get; set; }

        /// <summary>
        /// Gets or sets AllowBreakAcrossPages
        /// </summary>  
        public bool? AllowBreakAcrossPages { get; set; }

        /// <summary>
        /// Gets or sets HeadingFormat
        /// </summary>  
        public bool? HeadingFormat { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>  
        public double? Height { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableRowFormat {\n");
          sb.Append("  AllowBreakAcrossPages: ").Append(this.AllowBreakAcrossPages).Append("\n");
          sb.Append("  HeadingFormat: ").Append(this.HeadingFormat).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  HeightRule: ").Append(this.HeightRule).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
