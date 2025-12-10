<h2 align="left"> Configuración de application.properties y perfiles en Spring Boot </h2>

<h3 align="left"> ¿Cómo se utilizan application.properties y perfiles en Spring para configurar la aplicación? </h3>

<p align="left"> El archivo application.properties centraliza la configuración en una app Spring Boot. Permite establecer desde el API key y el modelo usado con librerías como LangChain4j, hasta aspectos cruciales como el puerto del servidor o el contexto de la URL.

* Puedes definir parámetros como server.port para cambiar el puerto (por ejemplo, a 8090).
* Para cambiar el contexto raíz, se usa server.servlet.contextPath (e.g., /platzi-play/api).
* Los cambios se reflejan tras reiniciar la aplicación, afectando cómo y dónde responde tu API. </p>

<h3 align="left"> ¿Qué ventajas ofrecen los diferentes archivos de propiedades para cada entorno? </h3>

<p align="left"> Spring permite tener múltiples archivos de configuración según ambiente: desarrollo, pruebas o producción. Esto se gestiona creando archivos como application-dev.properties o application-prod.properties dentro del directorio resources.

* Cada archivo puede contener variables específicas solo para ese entorno.
* El archivo principal (application.properties) mantiene las configuraciones generales.
* Se activa un perfil con la propiedad spring.profiles.active, por ejemplo, dev o prod, para que Spring use ese archivo.
* Así puedes, por ejemplo, habilitar logs detallados solo en desarrollo y desactivarlos en producción. </p>

<h3 align="left"> ¿Cómo se acceden y utilizan las variables de configuración en el código Spring? </h3>

<p align="left"> Las variables en application.properties pueden ser utilizadas directamente en el código de la aplicación a través de la anotación @Value.

* Por ejemplo, puedes inyectar el nombre de la aplicación usando @Value("${spring.application.name}") en el constructor de tu controlador.
* Así se evita "quemar" valores en el código y permite una gestión centralizada y flexible.
* Cambios en las variables del properties se reflejan al reiniciar la app, mostrando los resultados, por ejemplo, en las respuestas de la API. </p>

<h3 align="left"> ¿Cómo se configuran logs y otros parámetros específicos según el entorno? </h3>

<p align="left">

* En el archivo application-dev.properties puedes agregar parámetros para mostrar logs de request y response, permitiendo ver internamente cómo opera una librería como LangChain4j.
* En producción, se recomienda minimizar los logs para evitar exponer información sensible o saturar la consola.
* Cada entorno puede personalizar el nivel de logueo y otros detalles de configuración según sea necesario. </p>