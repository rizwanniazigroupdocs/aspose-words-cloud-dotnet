dotnet test c:\build\Aspose.Words.Cloud.Sdk.%1\Aspose.Words.Cloud.Sdk.%1.csproj --framework net462 --logger "junit;LogFilePath=c:\Build\testResults\%1%2-results-net462.xml"
Powershell.exe -executionpolicy remotesigned -File "c:\build\scripts\fix-test-result.ps1" -filepath "c:\build\testResults\%1%2-results-net462.xml"