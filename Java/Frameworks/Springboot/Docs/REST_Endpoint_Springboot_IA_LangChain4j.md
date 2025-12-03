<h2 align="left"> Crear un endpoint REST con Spring Boot e integrarlo con IA usando LangChain4j </h2>

<h3 align="left"> ¿Cómo crear un endpoint REST en Java con Spring Boot? </h3>

<p align="left"> Primero, asegúrate de tener tu proyecto cargado y corriendo en IntelliJ IDEA; si puedes ver una respuesta desde el navegador, vas por buen camino.

* Debes crear una nueva clase llamada HelloController dentro del paquete com.platzi.play.
* Anota la clase con @RestController, lo que le indica a Spring Boot que aceptará y gestionará peticiones HTTP.
* Agrega un método que retorne, por ejemplo, Hello world. Usa la anotación @GetMapping para especificar que este método responderá a peticiones GET.
* Si accedes desde el navegador al endpoint raíz, obtendrás la respuesta definida, por ejemplo: “Hola mundo, Hello world”. </p>

<h3 align="left"> ¿Cómo integrar inteligencia artificial a un proyecto Spring Boot con LangChain4j? </h3>

<p align="left"> El siguiente paso es sumar inteligencia artificial a tu proyecto. Para esto, sigue estos puntos:

* Usa la librería LangChain4j, especialmente diseñada para conectar APIs de inteligencia artificial con tus servicios Java.
* Busca la documentación oficial de LangChain4j y agrega sus dependencias en el archivo build.gradle. Incluye las dependencias para OpenAI y Spring Boot usando la versión 1.0.0-beta1, que permite el uso de una demo API key gratuita.
* Refresca el proyecto Gradle para descargar e instalar las dependencias.
* En el archivo application.properties dentro de la carpeta Resources, configura los parámetros necesarios para LangChain4j:

        langchain4j.openai.chatmodel.apikey=demo
        langchain4j.openai.chatmodel.model-name=gpt-4omini 
        
Esto habilita a tu aplicación para procesar solicitudes de IA fácilmente.

</p>

<h3 align="left"> ¿Cómo crear y consumir un servicio de inteligencia artificial personalizado en Spring Boot? </h3>

<p align="left"> 

* Crea una nueva interface llamada PlatziPlayAIService.
* Anótala con @AIServices para indicar que será usada como servicio de IA.
* En la interface, añade un método llamado generateGreeting anotado con @UserMessage. Usa triple comilla para definir el prompt: pide un saludo de bienvenida, con menos de 120 caracteres y el estilo de Platzi.
* Llegó el momento de integrar este servicio al HelloController. Decláralo como final, agréga una instancia en el constructor para permitir la inyección por Spring.
* Modifica el endpoint para que retorne la respuesta de generateGreeting() en vez de Hello world.
* Relanza la aplicación, accede al endpoint y visualiza un saludo personalizado generado por OpenAI; cada petición puede recibir un mensaje diferente.

</p>

