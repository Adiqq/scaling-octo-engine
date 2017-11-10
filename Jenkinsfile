pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'docker build -t identity-server Identity.Server'
	sh 'docker build -t api Api'
      }
    }
    stage('Run') {
      steps {
        sh '''
        docker stop identity-server || true
        docker rm identity-server || true
        docker run --network=final --name=identity-server \\
          --restart=always -d -p 30001:80 \\
          -e CONNECTION_STRING="$CONNECTION_STRING" \\
          -e AUTHORITY="http://adwa.westeurope.cloudapp.azure.com:30001" \\
          identity-server
	docker stop api || true
	docker rm api || true
	docker run --network=final --name=api \\
	  --restart=always -d -p 30002:80 \\
	  -e AUTHORITY="http://adwa.westeurope.cloudapp.azure.com:30001" \\
	  api'''
      }
    }
  }
}
