#!groovy
def version = "1.0." + env.BUILD_NUMBER + (env.BRANCH_NAME=="master");
def versionVSIX = "1.0." + env.BUILD_NUMBER;

node{

	try {
			stage 'checkout'
			checkout scm
				
			stage 'nuget restore'
			bat '"C:\\Program Files (x86)\\NuGet\\Visual Studio 2015\\nuget.exe" TestConsoleAppliaction.sln'
			
			stage 'build x64 TestConsoleAppliaction'
			bat "\"${msbuild}\" /t:Clean,Build /p:Platform=x64 TestConsoleAppliaction.sln"
			
			echo "currentBuild.toString() + env.JOB_NAME+' - Build '+env.BUILD_NUMBER+' - '+(currentBuild.result == null? "STABLE":currentBuild.result)"
		}
	catch(e) {
				node {
						def sub = env.JOB_NAME+' - Build '+env.BUILD_NUMBER+' - FAILED'
						echo "${env.JOB_NAME} failed with ${e.message}"
					}
    throw e
}
}
