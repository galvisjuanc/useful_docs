<h2 align="left"> Conexión de Spring Boot con PostgreSQL usando Docker </h2>

<h3 align="left"> ¿Cómo utilizar Docker para bases de datos en desarrollo Spring Boot? </h3>

<p align="left"> Docker es una herramienta que ejecuta aplicaciones en contenedores. Estos entornos son livianos, portables y garantizan que todo funcione igual en cualquier máquina. Al usar Docker, puedes iniciar una base PostgreSQL "limpia" dentro de un contenedor, facilitando su administración y, cuando sea necesario, eliminarla sin afectar el resto de tu sistema.

* Asegúrate de tener Docker o Docker Desktop instalado.
* Si ya tienes PostgreSQL local, puedes conectarte sin contenedor; los pasos son similares, solo omitiendo Docker. </p>

<h3 align="left"> ¿Qué dependencias debes agregar a tu proyecto para conectar Spring Boot y PostgreSQL? </h3>

<p align="left"> 

En start.spring.io (Spring Initializr), busca y añade estas dependencias esenciales:

* Spring Data JPA: Para acceder y manipular tus datos fácilmente.
* Driver de PostgreSQL: Hace posible la conexión entre tu aplicación y la base de datos.
* Docker Compose: Disponible desde Spring Boot 3.1, detecta y gestiona automáticamente los contenedores necesarios en desarrollo. 

Agrega estas dependencias en tu archivo build.gradle. Recuerda refrescar Gradle para que descargue todos los paquetes y construya el entorno correctamente.

</p>