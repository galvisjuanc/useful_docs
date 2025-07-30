<h2 align="left"> Publicación de Imágenes Docker en DockerHub con Jenkins </h2>

<h3 align="left"> ¿Qué es un Artifact en Docker y cómo se utiliza en Jenkins?
 </h3>
<p align="left">  Un Artifact es el resultado final de un proceso de integración y desarrollo continuo, y en Docker, puede ser la imagen que montamos para correr nuestros tests. Esta imagen de Docker es crucial porque encapsula todo lo necesario para que una aplicación funcione. Además, es necesario almacenar este Artifact de manera segura y accesible. Docker ofrece el concepto de repositorios para almacenar imágenes, siendo Docker Hub uno de los más comunes. Los repositorios te permiten almacenar y gestionar tus imágenes de manera centralizada.

 </p>

<h3 align="left"> ¿Cómo podemos almacenar imágenes en Docker Hub? </h3>
<p align="left">  Para empezar a almacenar imágenes en Docker Hub, lo primero que debes hacer es crear una cuenta. Esto se hace en hub.docker.com. Una vez que tengas tu cuenta, sigue estos pasos:

1. Obtener un token de autenticación: Utiliza este token en tu consola de Docker. Este token actúa como una contraseña que te permitirá interactuar de manera segura con Docker Hub.

2. Configurar Jenkins para usar Docker Hub: Es crucial que Jenkins pueda autenticar de manera segura y continua con Docker Hub. Para ello:
    * Ve a la sección de Credentials en Jenkins.
    * Navega a 'Jenkins' > 'Global Credentials'.
    * Añade unas nuevas credenciales utilizando la opción de "user name with password". Aquí introduces tu nombre de usuario de Docker y el token como contraseña.
    * Asigna un ID a estas credenciales, tal como 'DockerHub Credentials'. Asegúrate de recordar este ID para su uso en el código posterior.

 </p>

 <h3 align="left"> ¿Cómo configuramos el Jenkins file para publicar la imagen?
 </h3>
<p align="left">  Una vez que Jenkins está configurado para interactuar con Docker Hub, debes ajustar el Jenkins file para que publique las imágenes cuando cumpla ciertas condiciones, como en ramas específicas de tu proyecto:

<code> 

    def registry = '<tu-repositorio>/mi-imagen'
    def registryCredential = 'DockerHub Credentials'

    pipeline {
        agent any

        stages {
            stage('Build') {
                steps {
                    script {
                        docker.build("${registry}:latest")
                    }
                }
            }
            stage('Push') {
                steps {
                    script {
                        docker.withRegistry('', registryCredential) {
                            docker.image("${registry}:latest").push()
                        }
                    }
                }
            }
        }
    }
    
</code>

docker.withRegistry(''): Aquí se deja en blanco para usar el default que es Docker Hub. Si tienes otro repositorio, especifica la URL.

docker.image("${registry}:latest").push(): Esta línea sube la imagen a Docker Hub. Ya está etiquetada desde el build, de modo que no necesitas volver a hacerlo.

 </p>
