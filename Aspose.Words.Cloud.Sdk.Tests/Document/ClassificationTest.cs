﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ClassificationTest.cs">
// //   Copyright (c) 2018 Aspose.Words for Cloud
// // </copyright>
// // <summary>
// //   Permission is hereby granted, free of charge, to any person obtaining a copy
// //  of this software and associated documentation files (the "Software"), to deal
// //  in the Software without restriction, including without limitation the rights
// //  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// //  copies of the Software, and to permit persons to whom the Software is
// //  furnished to do so, subject to the following conditions:
// // 
// //  The above copyright notice and this permission notice shall be included in all
// //  copies or substantial portions of the Software.
// // 
// //  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// //  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// //  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// //  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// //  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// //  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// //  SOFTWARE.
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Tests.Document
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to classify text.
    /// </summary>
    [TestFixture]
    public class ClassificationTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "Common");

        /// <summary>
        /// Test for raw text classification.
        /// </summary>
        [Test]
        public void TestClassify()
        {
            var request = new ClassifyRequest("Try text classification", "3");
            var actual = this.WordsApi.Classify(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for document classification.
        /// </summary>
        [Test]
        public void TestClassifyDocument()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "Source.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new ClassifyDocumentRequest(remoteName,
                this.dataFolder,
                bestClassesCount: "3");

            var actual = this.WordsApi.ClassifyDocument(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}