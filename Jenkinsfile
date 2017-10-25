pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'docker build -t scaling-octo-engine scaling-octo-engine'
      }
    }
  }
}