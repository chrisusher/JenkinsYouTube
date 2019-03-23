pipeline {
  agent any
  stages {
    stage('Build') {
      environment {
        MSBuild = 'C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\MSBuild.exe'
        NuGet = 'C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\nuget.exe'
      }
      steps {
        bat(script: '$NuGet restore OctoFX\\OctoFX.sln', label: 'Restore Nuget Packages')
        bat(script: '$MSBuild OctoFX\\OctoFX.sln /p:Configuration=Debug /p:Platform=\\"Any CPU\\"', label: 'Build Solution')
      }
    }
  }
}