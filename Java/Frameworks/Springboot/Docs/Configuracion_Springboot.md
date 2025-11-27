<h2 align="left"> Configuración inicial de proyecto Spring Boot con Java 21 </h2>

<h3 align="left"> ¿Qué necesitas para iniciar con Spring Boot y cómo preparar el entorno?
 </h3>

<p align="left"> Antes de iniciar, asegúrate de tener conocimientos previos en Java y de contar con el JDK versión 21 instalado en tu equipo. Si aún no lo tienes, IntelliJ IDEA te permite descargarlo e instalarlo fácilmente desde el propio editor. IntelliJ IDEA de JetBrains es reconocido por su soporte completo para Java y sus herramientas impulsadas por inteligencia artificial para mejorar la experiencia de desarrollo.

Para probar tu API, necesitarás el navegador y Postman, ideal para pruebas avanzadas de servicios. Además, utilizarás Docker para levantar una instancia de PostgreSQL para la base de datos. Si ya tienes PostgreSQL instalado, puedes usar tu propia configuración sin complicaciones. </p>

<h3 align="left"> ¿Cómo crear un nuevo proyecto Spring Boot paso a paso? </h3>

<p align="left"> A continuación se nombran los pasos para crear un proyecto Springboot:

* Dirígete a start.spring.io, la plataforma oficial Spring Initializer.
* Elige la configuración sugerida: proyecto Gradle, lenguaje Java, versión 3.5.3 de Spring Boot.
* Establece el grupo como com.xxxxx y el artefacto como --- Play.
* Especifica que el objetivo del proyecto es una plataforma de gestión de películas donde podrás consultar, actualizar y agregar títulos.
* Usa com.xxxx.play como nombre de paquete y selecciona el empaquetado JAR para aprovechar el servidor embebido.
* Selecciona la dependencia Spring Web para crear servicios RESTful apoyados por Spring MVC y el servidor embebido Apache Tomcat.

Explora la estructura que generará la herramienta, incluyendo el archivo build.gradle y la carpeta src para tu código fuente. Haz clic en Generar para descargar el archivo .zip y descomprímelo en una ubicación fácilmente accesible: evita usar la carpeta de descargas para prevenir borrados accidentales. </p>

<h3 align="left"> ¿Cómo abrir y preparar el proyecto en IntelliJ IDEA? </h3>

<p align="left"> Abre IntelliJ IDEA y selecciona Open para cargar la carpeta descomprimida del proyecto. Al ubicar el archivo build.gradle, elige abrirlo como proyecto, lo que permitirá gestionar automáticamente todas las dependencias.

Verifica que el proyecto esté corriendo con Java 21 desde los ajustes del módulo (Open Module Settings) en el SDK. Dentro del paquete com.xxx.play, encontrarás la clase PlayApplication con el método principal main, encargado de iniciar la aplicación Java.

Ejecuta tu aplicación desde IntelliJ; verás en la consola que el servicio Tomcat inicia rápidamente y la aplicación está disponible en el puerto 8080. Al ingresar a localhost:8080 desde el navegador, verás un mensaje de error 404, lo cual indica que tu servidor responde correctamente, aunque aún no hay endpoints activos.</p>