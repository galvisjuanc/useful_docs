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

<h3 align="left"> ¿Cómo configurar Docker Compose para PostgreSQL con persistencia de datos? </h3>

<p align="left"> Spring Initializr genera un archivo compose.yaml con la configuración básica de la base de datos. Debes ajustarlo para asegurar que los datos persistan entre reinicios y la gestión sea sencilla:

* Usar la propiedad restart: unless-stopped para reinicios automáticos solo si el contenedor se apaga por error.
* Mapear correctamente el puerto local (5432:5432).
* Definir un volumen pgdata en data/postgres para que la información no se borre después de cada reinicio.
* Ajustar las variables de entorno, como el nombre de la base de datos, usuario y contraseña.

Al final, importa el volumen para asegurar la persistencia, y verifica que la configuración apunte a la imagen más reciente de PostgreSQL.

</p>

<h3 align="left"> ¿Cómo conectar Spring Boot al contenedor de PostgreSQL? </h3>

<p align="left"> Ve a src/main/resources y configura las propiedades necesarias:

* spring.datasource.driver-class-name: org.postgresql.Driver
* spring.datasource.url: jdbc:postgresql://localhost:5432/push_play_db
* spring.datasource.username: el usuario que configuraste en Docker Compose (por ejemplo, xxxx).
* spring.datasource.password: la contraseña elegida (por ejemplo, xxx.xxx).

Guarda estos datos en un archivo de configuración general para que estén disponibles en todo tu entorno de desarrollo.

</p>