<h2 align="left"> Despliegue de API Java con Docker en Render </h2>

<h3 align="left"> ¿Cómo configurar un Dockerfile para una aplicación Java en Render? </h3>

<p align="left"> Un Dockerfile funciona como una receta que le indica a Docker cómo construir la imagen de la aplicación. Hay dos etapas esenciales:

* Etapa de compilación: 
    * Se utiliza una imagen específica de Gradle (por ejemplo, 8.14.2-jdk21), alineada con la versión definida en Gradle wrapper.
    * Se copia el contenido de la aplicación al contenedor (/app) y se ejecuta el comando gradle boot jar.
* Etapa de ejecución: 
    * Se utiliza una imagen de JDK21 (en el ejemplo, Eclipse Temurin) para correr la aplicación.
    * Se trasladan los archivos generados como .jar desde el build a la ruta preferida y se ejecuta el archivo con el perfil de producción tal cual como se configuró localmente.</p>