pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'docker build -t scaling-octo-engine scaling-octo-engine'
      }
    }
    stage('Run') {
      steps {
        sh '''docker stop scaling-octo-engine || true
docker rm scaling-octo-engine || true
docker run --name=scaling-octo-engine --restart=always \\\\
-d -p 30001:80 scaling-octo-engine'''
      }
    }
  }
}