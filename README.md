![](https://img.shields.io/badge/api-v2.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.Words-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.Words-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-words-cloud/aspose-words-cloud-dotnet)](https://github.com/aspose-words-cloud/aspose-words-cloud-dotnet/blob/master/LICENSE) 

Cloud SDK for .Net wraps Aspose.Words REST API so you could seamlessly integrate Microsoft Word® document generation, manipulation, conversion & inspection features into your own .Net applications.

# .NET SDK for Word Documents Processing in the Cloud

[Aspose.Words Cloud SDK for .Net](https://products.aspose.cloud/words/net) allows to work with document headers, footers, page numbering, tables, sections, document comments, drawing objects, FormFields, fonts, hyperlinks, ranges, paragraphs, math objects, watermarks, track changes and document protection. It also assists in appending documents, splitting documents as well as converting document to other supported file formats. 

Feel free to explore the [Developer's Guide](https://docs.aspose.cloud/display/wordscloud/Developer+Guide) & [API Reference](https://apireference.aspose.cloud/words/) to know all about Aspose.Words Cloud API. 

## Document Processing Services in REST

- Convert between various document-related formats, including Word to PDF & vice versa.
- Mail merge and report generation in the Cloud.
- Split & merge Word documents.
- Access Word document metadata.
- Find and replace text.
- Add & remove watermarks and protection.
- Read & write access to Document Object Model.

Check out the [Developer's Guide](https://docs.aspose.cloud/display/wordscloud/Developer+Guide) to know more about Aspose Words Cloud REST API.

## Read & Write Document Formats

**Microsoft Word:** DOC, DOCX, RTF, DOT, DOTX, DOTM, FlatOPC (XML)
**OpenOffice:** ODT, OTT
**WordprocessingML:** XML
**Web:** HTML, MHTML, HtmlFixed
**Text:** TXT
**Fixed Layout:** PDF

## Save Document As

**Fixed Layout:** PDF/A, XPS, OpenXPS, PS
**Images:** JPEG, PNG, BMP, SVG, TIFF, EMF
**Others:** PCL

## Getting Started with Aspose.Words Cloud SDK for .NET
First create an account at [Aspose for Cloud](https://dashboard.aspose.cloud/) and get your application information. Next,  execute `Install-Package Aspose.Words-Cloud` from Package Manager Console in Visual Studio to fetch & reference the SDK in your project. If you already have the package and wish to upgrade it, please execute `Update-Package Aspose.Words-Cloud` to get the latest version.


#### Install Aspose.Words-Cloud via NuGet

From the command line:

	nuget install Aspose.Words-Cloud

From Package Manager:

	PM> Install-Package Aspose.Words-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.Words-Cloud".
5. Click on the Aspose.Words-Cloud package, select the appropriate version in the right-tab and click *Install*.

The complete source code is available at [GitHub Repository](https://github.com/aspose-words-cloud/aspose-words-cloud-node).

### SDK Dependencies

- [.NET Framework 2.0 or later](https://dotnet.microsoft.com/download ".NET Framework 2.0 or later")
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Convert DOC to PDF via the SDK

```csharp
            // Start README example
            var config = new Configuration
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                ApiBaseUrl = baseUrl,
            };

            var wordsApi = new WordsApi(config);
            using (var inputStream = new FileStream(pathToDocFile, FileMode.Open))
            {
                var uploadFileRequest = new UploadFileRequest(inputStream, "fileStoredInCloud.doc");
                wordsApi.UploadFile(uploadFileRequest);
            }

            var saveOptionsData = new SaveOptionsData { SaveFormat = "pdf", FileName = "destStoredInCloud.pdf" };
            var request = new SaveAsRequest("fileStoredInCloud.doc", saveOptionsData);
            wordsApi.SaveAs(request);

            // End README example
```

[Product Page](https://products.aspose.cloud/words/net) | [Documentation](https://docs.aspose.cloud/display/wordscloud/Home) | [API Reference](https://apireference.aspose.cloud/words/) | [Code Samples](https://github.com/aspose-words-cloud/aspose-words-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/words/) | [Free Support](https://forum.aspose.cloud/c/words) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
