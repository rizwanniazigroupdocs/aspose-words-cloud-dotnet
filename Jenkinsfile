properties([
	gitLabConnection('gitlab'),
	parameters([string(defaultValue: 'refs/heads/master', description: 'the branch to build', name: 'branch', trim: true)])
])

node('words-windows') {
	try {
		gitlabCommitStatus("checkout") {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/words-cloud/words-cloud-dotnet.git']]])
			}
		}
		gitlabCommitStatus("build") {
			stage('build') {
				bat 'docker build scripts -f scripts\\build.Dockerfile -t netsdkbuild'
				bat 'docker run -v %CD%:C:\\Build\\ netsdkbuild c:\\build\\scripts\\build.bat' 
			}
		}
		
		gitlabCommitStatus("tests") {
			stage('tests') {	
				bat 'mkdir testResults'
				bat 'mkdir Settings'
				withCredentials([usernamePassword(credentialsId: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
					bat "echo {\"AppSid\":\"%AppSid%\",\"AppKey\":\"%AppKey%\" } > Settings\\servercreds.json"
				}
				
				try {
					bat 'tools\\nunit\\nunit3-console.exe Aspose.Words.Cloud.Sdk.Tests\\bin\\Debug\\net452\\Aspose.Words.Cloud.Sdk.Tests.dll  --result="testResults\\tests-result-net452.xml;transform=tools\\nunit\\nunit3-junit.xslt"'
				} finally {
					junit 'testResults\\tests-result-net452.xml'
				}
				
				try {
					bat 'dotnet test Aspose.Words.Cloud.Sdk.Tests\\Aspose.Words.Cloud.Sdk.Tests.csproj --framework netcoreapp2.1 --logger "junit;LogFilePath=%CD%\\testResults\\tests-result-netcoreapp2.xml" --no-restore --no-build'
				} finally {
					junit 'testResults\\tests-result-netcoreapp2.xml'
				}
				
				try {
					bat 'tools\\nunit\\nunit3-console.exe Aspose.Words.Cloud.Sdk.BddTests\\bin\\Debug\\net452\\Aspose.Words.Cloud.Sdk.BddTests.dll --result="testResults\\bddtests-result-net452.xml;transform=tools\\nunit\\nunit3-junit.xslt"'
				} finally {
					junit 'testResults\\bddtests-result-net452.xml'
				}
				
				try {
					bat 'dotnet test Aspose.Words.Cloud.Sdk.BddTests\\Aspose.Words.Cloud.Sdk.BddTests.csproj --framework netcoreapp2.1 --logger "junit;LogFilePath=%CD%\\testResults\\bddtests-result-netcoreapp2.xml" --no-restore --no-build'
				} finally {
					junit 'testResults\\bddtests-result-netcoreapp2.xml'
				}
			}
		}
	} finally {
		bat 'docker system prune -f'
		deleteDir()
	}
}