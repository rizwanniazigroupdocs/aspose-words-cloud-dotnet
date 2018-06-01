﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="HyperlinkTest.cs">
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
// //  --------------------------------------------------------------------------------------------------------------------
namespace Aspose.Words.Cloud.Sdk.Tests.Hyperlink
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with hyperlinks
    /// </summary>
    [TestFixture]
    public class HyperlinkTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Hyperlink");

        /// <summary>
        /// Test for getting hyperlink by specified index
        /// </summary>
        [Test]
        public void TestGetDocumentHyperlinkByIndex()
        {
            var localName = "test_doc.docx";
            var remoteName = "TestGetDocumentHyperlinkByIndex.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var hyperlinkIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentHyperlinkByIndexRequest(remoteName, hyperlinkIndex, this.dataFolder);
            var actual = this.WordsApi.GetDocumentHyperlinkByIndex(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting hyperlinks
        /// </summary>
        [Test]
        public void TestGetDocumentHyperlinks()
        {
            var localName = "test_doc.docx";
            var remoteName = "TestGetDocumentHyperlinks.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentHyperlinksRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetDocumentHyperlinks(request);

            Assert.AreEqual(200, actual.Code);
        }
    }
}