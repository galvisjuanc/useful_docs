<h2 align="left"> Despliegue de API Java con Docker en Render </h2>

<h3 align="left"> ¿Cómo configurar un Dockerfile para una aplicación Java en Render? </h3>

<p align="left"> Un Dockerfile funciona como una receta que le indica a Docker cómo construir la imagen de la aplicación. Hay dos etapas esenciales:

* Etapa de compilación: 
    * Se utiliza una imagen específica de Gradle (por ejemplo, 8.14.2-jdk21), alineada con la versión definida en Gradle wrapper.
    * Se copia el contenido de la aplicación al contenedor (/app) y se ejecuta el comando gradle boot jar.
* Etapa de ejecución: 
    * Se utiliza una imagen de JDK21 (en el ejemplo, Eclipse Temurin) para correr la aplicación.
    * Se trasladan los archivos generados como .jar desde el build a la ruta preferida y se ejecuta el archivo con el perfil de producción tal cual como se configuró localmente.
    
Así, Docker encapsula la app y asegura la consistencia entre ambientes.

</p>

<h3 align="left"> ¿Qué aspectos debes considerar en la configuración de Render y la base de datos? </h3>

<p align="left"> Render facilita el despliegue ofreciendo capas gratuitas y manejo sencillo de repositorios. Algunos aspectos importantes a considerar:

* El archivo application.properties requiere ajustar la URL de la base de datos. Al ejecutarse dentro de Render, la cadena se simplifica, quitando referencias externas (como oregon-postgres.render.com).
* Mantener la referencia del puerto en la URL luego de remover el prefijo.
* Subir los cambios a GitHub es necesario, pues Render obtiene el código directamente del repositorio.
* Se recomienda agregar variables de entorno si tu aplicación las requiere, como API keys.

Render mostrará en su consola cada paso del proceso de compilación y despliegue, permitiendo visualizar advertencias relevantes, por ejemplo, spring-jpa-open-in-view, relacionada con la gestión de conexiones a la base de datos durante la renderización de respuestas. </p>

<h3 align="left"> ¿Cómo validar y acceder a tu API tras el despliegue en la nube? </h3>

<p align="left"> Una vez desplegada la aplicación y completadas las configuraciones, Render te proporcionará una URL pública para acceder al servicio. Aquí algunos puntos clave:

* La URL puede devolver un código 404 si no se incluye el contexto definido en application.properties.
* Recuerda usar los endpoints configurados (ejemplo: /movies para comprobar la lista de películas o /hello para saludar, según lo definido durante el desarrollo).
* Si aparece un error inesperado, confirma que estés invocando los servicios correctamente y que el contexto de ruta sea el adecuado.

</p>