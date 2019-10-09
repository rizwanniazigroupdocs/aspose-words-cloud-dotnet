properties([
	parameters([string(defaultValue: 'refs/heads/master', description: 'the branch to build', name: 'branch', trim: true)])
])

node('words-windows') {
	try {
		stage('build') {
			bat 'docker build .\\scripts -f .\\scripts\\build.Dockerfile -t netsdkbuild'
			bat 'docker run -v "${PWD}:C:\\Build\\" netsdkbuild c:\\build\\scripts\\build.bat' 
		}
		
		stage('tests') {	
			bat 'mkdir testResults'
			bar 'mkdir Settings'
			withCredentials([usernamePassword(credentialsId: '6839cbe8-39fa-40c0-86ce-90706f0bae5d', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
				bat "echo {\"AppSid\":\"%AppSid%\",\"AppKey\":\"%AppKey%\" } > Settings\\servercreds.json"
			}
			
			try {
				bat 'tools\\nunit\\nunit3-console.exe buildOut\\Aspose.Words.Cloud.Sdk.Tests.dll  --result="testResults\\tests-result.xml;transform=tools\\nunit\\nunit3-junit.xslt"'
			} finally {
				junit 'testResults\\tests-result.xml'
			}
			
			try {
				bat 'tools\\nunit\\nunit3-console.exe buildOut\\Aspose.Words.Cloud.Sdk.BddTests.dll --result="testResults\\bddtests-result.xml;transform=tools\\nunit\\nunit3-junit.xslt"'
			} finally {
				junit 'testResults\\bddtests-result.xml'
			}
		}
	} finally {                       
		deleteDir()
	}
}