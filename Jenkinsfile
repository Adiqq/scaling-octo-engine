pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'docker build -t identity-server Identity.Server'
      }
    }
    stage('Run') {
      steps {
        sh '''docker stop identity-server || true
docker rm identity-server || true
docker run --network=final --name=identity-server --restart=always \\
-d -p 30001:80 identity-server'''
      }
    }
  }
}