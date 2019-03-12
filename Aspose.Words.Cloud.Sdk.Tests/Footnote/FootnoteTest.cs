﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Aspose" file="FootnoteTest.cs">
// //   Copyright (c) 2019 Aspose.Words for Cloud
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
namespace Aspose.Words.Cloud.Sdk.Tests.Footnote
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Model;
    using Aspose.Words.Cloud.Sdk.Model.Requests;
    using Aspose.Words.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;

    /// <summary>
    /// Example of how to work with footnotes
    /// </summary>
    [TestFixture]
    public class FootnoteTest : BaseTestContext
    {
        private readonly string dataFolder = Path.Combine(RemoteBaseTestDataFolder, "DocumentElements/Footnotes");

        private readonly string footnoteFolder = "DocumentElements/Footnotes/";

        /// <summary>
        /// Test for adding footnote
        /// </summary>
        [Test]
        public void TestPutFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestPutFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var footNote = new Footnote { FootnoteType = Footnote.FootnoteTypeEnum.Endnote, Text = "test endnote" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new PutFootnoteRequest(remoteName, footNote, this.dataFolder);
            var actual = this.WordsApi.PutFootnote(request);
        }

        /// <summary>
        /// Test for deleting footnote
        /// </summary>
        [Test]
        public void TestDeleteFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestDeleteFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new DeleteFootnoteRequest(remoteName, index, this.dataFolder);
            this.WordsApi.DeleteFootnote(request);
        }

        /// <summary>
        /// Test for getting footnotes
        /// </summary>
        [Test]
        public void TestGetFootnotes()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnotes.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnotesRequest(remoteName, this.dataFolder);
            var actual = this.WordsApi.GetFootnotes(request);
        }

        /// <summary>
        /// Test for getting footnote
        /// </summary>
        [Test]
        public void TestGetFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestGetFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new GetFootnoteRequest(remoteName, index, this.dataFolder);
            var actual = this.WordsApi.GetFootnote(request);
        }

        /// <summary>
        /// Test for updating footnote
        /// </summary>
        [Test]
        public void TestPostFootnote()
        {
            var localName = "Footnote.doc";
            var remoteName = "TestPostFootnote.docx";
            var fullName = Path.Combine(this.dataFolder, remoteName);
            var index = 0;
            var footnote = new Footnote { Text = "new text is here" };

            this.UploadFileToStorage(fullName, null, null, File.ReadAllBytes(BaseTestContext.GetDataDir(this.footnoteFolder) + localName));

            var request = new PostFootnoteRequest(remoteName, footnote, index, this.dataFolder);
            var actual = this.WordsApi.PostFootnote(request);
        }
    }
}