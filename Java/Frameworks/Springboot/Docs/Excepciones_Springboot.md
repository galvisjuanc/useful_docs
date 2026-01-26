<h2 align="left"> Control de excepciones con @RestControllerAdvice en Spring Boot </h2>

<h3 align="left"> ¿Por qué es clave el control de errores en una API Spring? </h3>

<p align="left"> Gestionar los posibles errores garantiza una experiencia de usuario transparente y una API robusta. Por ejemplo, al guardar películas, puede ser necesario evitar que existan títulos duplicados—aunque la base de datos lanza un error, debemos traducirlo en mensajes útiles, amigables y específicos para quien consume la API.

* Evitar errores inesperados reduce frustración del usuario.
* Centralizar excepciones simplifica el mantenimiento y mejora la trazabilidad.
* Proveer mensajes claros ayuda a los desarrolladores a comprender rápidamente los problemas. </p>

<h3 align="left"> ¿Cómo se valida la unicidad de títulos antes de guardar? </h3>

<p align="left"> El código implementa una validación previa a la creación de registros, consultando si ya existe una película con el mismo título utilizando un query method:

* Método personalizado: Se define findFirstBytitulo en el repositorio para verificar la existencia previa del título.
* Lógica de control: Si el título ya está en la base de datos, se lanza una excepción personalizada.

Esto evita confiar solo en restricciones de la base de datos, respondiendo de forma proactiva ante posibles colisiones. </p>

<h3 align="left"> ¿Cómo crear y lanzar excepciones personalizadas en Spring? </h3>

<p align="left"> Ante la detección de un intento de guardar una película repetida, se genera una excepción específica:

* Paquete nuevo para excepciones: Se crea un paquete exception donde residen todas las clases relacionadas.
* Clase propia para el caso: MovieAlreadyExistsException extiende RuntimeException y recibe el título problemático para personalizar el mensaje de error.
* Lanzamiento de la excepción: Al detectar duplicidad, se utiliza throw new MovieAlreadyExistsException(nombreDeLaPelicula). 

Esta estrategia ayuda a identificar el tipo de conflicto y detalla el motivo a quienes consumen la API. </p>

<h3 align="left"> ¿De qué manera @RestControllerAdvice permite capturar y procesar excepciones? </h3>

<p align="left"> Centralizar el control de errores mediante @RestControllerAdvice beneficia la organización del código y la claridad en la respuesta:

* Clase manejadora: Se crea RestExceptionHandler, anotada con @RestControllerAdvice, para capturar excepciones en toda la aplicación.
* Registro de error estructurado: Se define un record Error que retorna el tipo y la descripción del problema.
* Método de manejo: Al capturar MovieAlreadyExistsException, se responde con un código 400 (Bad Request) y un cuerpo claro:
* Tipo: MovieAlreadyExists.
* Mensaje: “La película 'Son como niños' ya existe.”

Así, los errores internos se transforman en respuestas interpretables y útiles para clientes externos. </p>

<h3 align="left"> ¿Qué otros escenarios comunes deben controlarse en una API REST? </h3>

<p align="left"> La práctica de capturar errores se puede extender fácilmente a otros casos:

* Intentos de editar o eliminar recursos inexistentes.
* Recepción de datos incorrectos (lo que se abordará en la próxima lección mediante anotaciones).

Abordar dichos escenarios eleva la calidad de la API y evita respuestas ambiguas. 

Recordatorios:

* Las excepciones del dominio representan errores de negocio, independientemente de como se expone el servicio. Además, no contienen información sobre el protocolo y se pueden reutilizar en cualquier interfaz.

* En la capa web, se incluye un manejador global de errores, con el fin de estructurar una respuesta mas diciente de cara al usuario, donde se especifique el tipo de error y un mensaje con el detalle.

Esta separación garantiza que el dominio sea limpio y agnóstico a la web.

</p>