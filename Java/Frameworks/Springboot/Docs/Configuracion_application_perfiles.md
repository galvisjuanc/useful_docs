<h2 align="left"> Configuración de application.properties y perfiles en Spring Boot </h2>

<h3 align="left"> ¿Cómo se utilizan application.properties y perfiles en Spring para configurar la aplicación? </h3>

<p align="left"> El archivo application.properties centraliza la configuración en una app Spring Boot. Permite establecer desde el API key y el modelo usado con librerías como LangChain4j, hasta aspectos cruciales como el puerto del servidor o el contexto de la URL.

* Puedes definir parámetros como server.port para cambiar el puerto (por ejemplo, a 8090).
* Para cambiar el contexto raíz, se usa server.servlet.contextPath (e.g., /platzi-play/api).
* Los cambios se reflejan tras reiniciar la aplicación, afectando cómo y dónde responde tu API. </p>