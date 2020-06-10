// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffSaveOptionsData.cs">
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
    /// Container class for tiff save options.
    /// </summary>
    public class TiffSaveOptionsData : ImageSaveOptionsData
    {
        /// <summary>
        /// Gets or sets the threshold that determines the value of the binarization error in the Floyd-Steinberg method. when ImageBinarizationMethod is ImageBinarizationMethod.FloydSteinbergDithering.
        /// Default value is 128.
        /// </summary>  
        public int? ThresholdForFloydSteinbergDithering { get; set; }

        /// <summary>
        /// Gets or sets specifies method used while converting images to 1 bpp format.
        /// </summary>  
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Gets or sets type of compression.
        /// </summary>  
        public string TiffCompression { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TiffSaveOptionsData {\n");
            sb.Append("  ThresholdForFloydSteinbergDithering: ").Append(this.ThresholdForFloydSteinbergDithering).Append("\n");
            sb.Append("  TiffBinarizationMethod: ").Append(this.TiffBinarizationMethod).Append("\n");
            sb.Append("  TiffCompression: ").Append(this.TiffCompression).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
