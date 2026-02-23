<h2 align="left"> Despliegue de API Java con Docker en Render </h2>

<h3 align="left"> ¿Cómo configurar un Dockerfile para una aplicación Java en Render? </h3>

<p align="left"> Un Dockerfile funciona como una receta que le indica a Docker cómo construir la imagen de la aplicación. Hay dos etapas esenciales:

* Etapa de compilación: 
    * Se utiliza una imagen específica de Gradle (por ejemplo, 8.14.2-jdk21), alineada con la versión definida en Gradle wrapper.
    * Se copia el contenido de la aplicación al contenedor (/app) y se ejecuta el comando gradle boot jar.</p>