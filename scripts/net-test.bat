dotnet restore c:\build\Aspose.Words.Cloud.Sdk\Aspose.Words.Cloud.Sdk.csproj
dotnet restore c:\build\Aspose.Words.Cloud.Sdk.%1\Aspose.Words.Cloud.Sdk.%1.csproj
c:\build\tools\nunit\nunit3-console.exe c:\build\Aspose.Words.Cloud.Sdk.%1\bin\Debug\net462\Aspose.Words.Cloud.Sdk.%1.dll  --result="c:\build\testResults\%1%2-results-net452.xml;transform=c:\build\tools\nunit\nunit3-junit.xslt"
Powershell.exe -executionpolicy remotesigned -File "c:\build\scripts\fix-test-result.ps1" -filepath "c:\build\testResults\%1%2-results-net452.xml"