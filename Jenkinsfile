pipeline {
  agent any
  stages {
    stage('Build') {
      environment {
        MSBuild = 'C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\MSBuild.exe'
      }
      steps {
        bat(script: 'bat \'nuget restore OctoFX\\OctoFX.sln\'', label: 'Restore Nuget Packages')
        bat 'bat "\\"${tool \'MSBuild\'}\\" OctoFX\\OctoFX.sln /p:Configuration=Debug /p:Platform=\\"Any CPU\\"'
      }
    }
  }
}