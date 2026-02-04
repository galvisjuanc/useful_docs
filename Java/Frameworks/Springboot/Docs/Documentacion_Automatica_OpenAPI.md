<h2 align="left"> Documentación automática de APIs con OpenAPI en Spring Boot </h2>

<h3 align="left"> ¿Cómo generar documentación para una API con OpenAPI en Spring Boot? </h3>

<p align="left"> Una API profesional no solo cumple su función, también debe ser sencilla de consumir y entender. Para lograrlo, puedes integrar OpenAPI en tu proyecto. 

Solo necesitas agregar una dependencia al archivo build.gradle siguiendo el formato grupo:artefacto:versión, basado en la documentación oficial de springdoc.org. Tras sincronizar y lanzar la aplicación, la documentación estará disponible en localhost:8090/platzi-play/api/swagger-ui.html. Se genera de forma automática y muestra todos los métodos disponibles, permitiendo incluso probarlos desde el navegador. </p>

<h3 align="left"> ¿Por qué es útil la documentación generada automáticamente? </h3>

<p align="left">

* Refleja todos los endpoints construidos en el proyecto.
* Permite probar llamadas a la API directamente desde el navegador.
* Muestra todos los parámetros y posibles respuestas.
* Incluye validaciones y reglas definidas por anotaciones en el código, como campos obligatorios y rangos aceptados. </p>

<h3 align="left"> ¿Cómo personalizar la documentación de la API en Spring Boot? </h3>

<p align="left"> Tu API puede tener descripciones a medida para cada endpoint y parámetro. Por ejemplo, usando la anotación @Tag de io.swagger.v3.oas.annotations, se define un nombre y descripción para un controlador. Esto mejora el entendimiento y la presentación de los recursos en la documentación. Además, cada método puede ser anotado con @Operation y describir brevemente su función, lo que espera recibir y retornar, así como las posibles respuestas, usando @ApiResponse.

* @ApiResponse permite definir el código de respuesta (como 200 u 404) y su significado, ajustando los ejemplos y el cuerpo de respuesta según corresponda.
* El parámetro de un endpoint puede anotarse con @Parameter y agregar descripción y ejemplo, lo que ayuda a quienes consumen la API a comprender cada campo.

Al personalizar estos detalles, la documentación habla el idioma y contexto deseado, mostrando títulos y descripciones adecuadas.
 </p>