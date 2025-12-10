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