<h2 align="left"> Sistema de recomendaciones de películas con IA en Java </h2>

<h3 align="left"> ¿Cómo eliminar películas en la base de datos usando Java? </h3>

<p align="left"> Eliminar películas es sencillo empleando la notación @DeleteMapping. El método recibe el ID de la película como variable de ruta y responde con un ResponseEntity.ok().build(), ya que el método delete no retorna datos. El uso de Void en el ResponseEntity es importante porque Delete no regresa un objeto, solo indica que la operación fue realizada.

Para probar esta operación, se puede utilizar Postman enviando una petición DELETE al endpoint correspondiente con el ID de la película. Si el borrado es exitoso, se recibirá un status code 200 y el cuerpo estará vacío, confirmando la eliminación. </p>

<h3 align="left"> ¿Cómo funciona el sistema de sugerencias de películas potenciado por IA? </h3>

<p align="left"> El corazón del sistema es el servicio Platzi Play AiService, donde se integra la anotación AiService de LangChain4j. El método principal, llamado generateMovieSuggestions, toma como entrada un mensaje del usuario (las preferencias) usando la anotación @UserMessage.

Se define un mensaje de sistema personalizado para que la IA actúe como un experto en cine. El prompt restringe la respuesta a un máximo de tres películas y exige que solo se sugieran títulos disponibles en Plazy Play, asegurando recomendaciones relevantes y precisas. </p>

<h3 align="left"> ¿Cómo se estructuran las peticiones y la transferencia de datos del usuario? </h3>

<p align="left"> El controlador recibe las preferencias del usuario como un objeto llamado SuggestRequestDTO, implementado como un record en Java. Este DTO solo contiene el campo userPreference, que captura los gustos expresados por la persona. Se utiliza @PostMapping para definir el endpoint /suggest, el cual responde con una lista de sugerencias generadas dinámicamente.

La inyección del servicio se realiza gracias a la anotación correspondiente y el uso de constructores. El controlador envía las preferencias del usuario al método generateMovieSuggestions del aiService y retorna la respuesta de forma segura y eficiente empleando ResponseEntity. </p>

<h3 align="left"> ¿Cómo conoce la IA las películas disponibles en la plataforma? </h3>

<p align="left"> Se aprovecha el método getAll del MovieService, anotado con @Tool de LangChain4j. Esta anotación convierte el método en una herramienta disponible para el modelo, permitiéndole consultar la lista actualizada de películas durante la generación de recomendaciones. El prompt asociado indica: "busca todas las películas que existan dentro de la plataforma", asegurando que las respuestas estén alineadas con el catálogo real. </p>