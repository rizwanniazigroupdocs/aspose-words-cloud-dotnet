﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="ParagraphTest.cs">
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
namespace Aspose.Words.Cloud.Sdk.Tests.Paragraph
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with paragraph
    /// </summary>
    [TestFixture]
    public class ParagraphTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Paragraphs");

        private readonly string fieldFolder = "DocumentElements/Fields/";

        /// <summary>
        /// Test for getting paragraph
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphByIndex()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphByIndex.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentParagraphRequest(remoteName, index, this.dataFolder, nodePath: "sections/0");
            var actual = this.WordsApi.GetDocumentParagraph(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting all paragraphs
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphs()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphs.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentParagraphsRequest(remoteName, this.dataFolder, nodePath: "sections/0");
            var actual = this.WordsApi.GetDocumentParagraphs(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting first paragraph
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphWithoutNodePath()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphWithoutNodePath.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentParagraphRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetDocumentParagraph(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting paragraph run
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRun()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphRun.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var runIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentParagraphRunRequest(remoteName, "paragraphs/0", runIndex, this.dataFolder);
            var actual = this.WordsApi.GetDocumentParagraphRun(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting paragraph run font
        /// </summary>
        [Test]
        public void TestGetDocumentParagraphRunFont()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestGetDocumentParagraphRunFont.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var runIndex = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new GetDocumentParagraphRunFontRequest(remoteName, "paragraphs/0", runIndex, this.dataFolder);
            var actual = this.WordsApi.GetDocumentParagraphRunFont(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for getting paragraph run
        /// </summary>
        [Test]
        public void TestGetParagraphRuns()
        {
            var localName = "GetField.docx";
            var remoteName = "TestGetParagraphRuns.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.fieldFolder) + localName));

            var request = new GetDocumentParagraphRunsRequest(remoteName, "sections/0/paragraphs/0", this.dataFolder);
            RunsResponse actual = this.WordsApi.GetDocumentParagraphRuns(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for updating paragraph run font
        /// </summary>
        [Test]
        public void TestPostDocumentParagraphRunFont()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPostDocumentParagraphRunFont.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var runIndex = 0;
            var destFileName = Path.Combine(BaseTestOutPath, remoteName);
            var fontDto = new Font { Bold = true };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PostDocumentParagraphRunFontRequest(remoteName, fontDto, "paragraphs/0", runIndex, this.dataFolder, destFileName: destFileName);
            var actual = this.WordsApi.PostDocumentParagraphRunFont(request);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for adding paragraph
        /// </summary>
        [Test]
        public void TestPutParagraph()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestPutParagraph.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var paragraph = new ParagraphInsert { Text = "This is a new paragraph for your document" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new PutParagraphRequest(remoteName, paragraph, this.dataFolder, nodePath: "sections/0");
            var actual = this.WordsApi.PutParagraph(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// Test for paragraph rendering
        /// </summary>
        [Test]
        public void TestRenderParagraph()
        {
            var localName = "test_multi_pages.docx";
            var remoteName = "TestRenderParagraph.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var format = "png";
            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(BaseTestContext.CommonFolder) + localName));

            var request = new RenderParagraphRequest(remoteName, format, index, this.dataFolder);
            var actual = this.WordsApi.RenderParagraph(request);

            Assert.IsTrue(actual.Length > 0, "Error has occurred while paragraph rendering");
        }
    }
}