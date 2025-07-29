<h2 align="left"> Pruebas Automatizadas con Docker y Jenkins en CI/CD </h2>

<h3 align="left"> ¿Cómo correr pruebas usando Docker y Jenkins? </h3>
<p align="left">  En el emocionante mundo del despliegue y desarrollo de software, Docker y Jenkins son herramientas fundamentales que nos permiten automatizar procesos y gestionar nuestros proyectos de manera eficiente. A continuación, desglosaremos cómo utilizar Docker tanto localmente como en Jenkins para ejecutar pruebas automáticas y asegurar que nuestro código esté listo para producción. </p>

<h3 align="left"> ¿Cómo correr pruebas localmente usando Docker? </h3>
<p align="left">  Una vez tienes Docker instalado, es hora de ponerlo en movimiento para ejecutar pruebas:

1. Construir la imagen de Docker: docker build -t mi_repositorio/webApp:tag .

2. Ejecutar las pruebas: docker run -it mi_repositorio/webApp:tag npm test


Este comando ejecutará las pruebas en el contenedor. El uso de npm test sobrescribe el comando definido en el Dockerfile, permitiéndote correr exactamente lo que necesitas. </p>

<h3 align="left"> ¿Cómo integrar Docker con Jenkins para pruebas continuas? </h3>

<p align="left">  Jenkins permite la automatización de procesos a través de pipelines, los cuales detallan cada paso que debe ejecutar, desde construir la imagen hasta correr las pruebas.

Definición del Jenkinsfile:

<code>
pipeline {
    agent any
    environment {
        ARTIFACT_ID = "mi_repositorio/webApp:\${BUILD_NUMBER}"
    }
    stages {
        stage('Build') {
            steps {
                script {
                    docker.build(ARTIFACT_ID)
                }
            }
        }
        stage('Test') {
            steps {
                script {
                    sh 'docker run mi_repositorio/webApp:tag npm test'
                }
            }
        }
    }
}

</code>

</p>

<h3 align="left"> ¿Por qué construir imágenes en Jenkins y no localmente?
 </h3>
<p align="left">  Construir imágenes en Jenkins asegura que el caché y las imágenes estén centralizadas. Jenkins se convierte en el punto de referencia para el estado de nuestro código, facilitando la colaboración y la transparencia entre los equipos.
 </p>

 <h3 align="left"> ¿Cómo configurar Jenkins para que ejecute los pasos definidos en Jenkinsfile? </h3>
<p align="left">  

1. Crear un nuevo proyecto en Jenkins:
    
    1.1 Selecciona "Pipeline Multibranch".
    
    1.2 Asocia el archivo Jenkinsfile al proyecto según lo explicado en el curso de Jenkins.

2. Ejecutar el Pipeline:

    2.1 Accede al proyecto.

    2.2 Corre las etapas definidas verificando que todo funcione correctamente.
 </p>