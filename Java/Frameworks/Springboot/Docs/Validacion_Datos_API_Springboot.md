<h2 align="left"> Validación automática de datos en APIs con Spring Boot </h2>

<h3 align="left"> ¿Por qué validar los datos de entrada en APIs es fundamental? </h3>

<p align="left">Validar los datos desde el inicio evita que información errónea llegue al núcleo de la lógica de la aplicación. Así, tu API responde de manera constructiva ante intentos de enviar datos incompletos o inconsistentes.

* Mejora la experiencia del usuario final al recibir mensajes claros.
* Previene fallos antes de que afecten procesos lógicos internos.
* Facilita el mantenimiento y robustez del código. </p>

<h3 align="left"> ¿Cómo agregar una capa de validación en Spring Boot usando anotaciones? </h3>

<p align="left"> Se recomienda agregar la dependencia "Validation" en tu proyecto mediante Spring Initializer (start.spring.io). Para ello, busca bean validation with Hibernate Validator o agrega 'Spring Boot Starter Validation' en tu archivo build.gradle y actualiza las dependencias.

Luego, utiliza las anotaciones en el DTO que representa el cuerpo de la petición: 
* Aplica la anotación @Valid directamente en el parámetro que recibe el request body (por ejemplo, un objeto update movie DTO).
* Entre las validaciones más útiles están:
* @NotBlank para campos obligatorios que no pueden ser vacíos (ejemplo: título).
* @PastOrPresent para fechas que no pueden ser futuras (ejemplo: fecha de lanzamiento).
* @Min y @Max para restringir valores numéricos (ejemplo: rating entre 0 y 5).
* Puedes definir mensajes personalizados para cada validación, lo que permite ofrecer retroalimentación clara como "El título es obligatorio" o "El rating no puede ser mayor que cinco".</p>

<h3 align="left"> ¿Cómo reportar errores de validación y manejar excepciones en tu API? </h3>

<p align="left"> Cuando se incumple alguna de estas reglas, Spring lanza una excepción method argument not valid exception. Para manejarla de forma adecuada:

* Implementa un método anotado con @ExceptionHandler para capturar esta excepción específica.
* Devuelve un objeto ResponseEntity con una lista de errores detallada por cada campo que falló.
* Extrae la información relevante mediante getBindingResult().getFieldErrors() y agrega mensaje y campo a dicho listado. 

Este enfoque permite que el cliente reciba una lista con los problemas específicos, en vez de una respuesta genérica sin detalles.

Además, es recomendable agregar un manejador general para captar cualquier otra excepción no controlada (mediante @ExceptionHandler(Exception.class)), y responder con un internal server error y un mensaje explicativo. Así, ninguna excepción quedará sin procesar, y siempre sabrás qué está fallando. </p>

<h3 align="left"> ¿Qué prácticas adicionales potencian la robustez de tu API con Spring Validation? </h3>

<p align="left">

* Crea validadores para todos los endpoints críticos, no solo para actualizaciones.
* Ofrece siempre mensajes orientados al usuario para facilitar la solución del problema.
* Lleva seguimiento de los fallos en un log para futuras auditorías o depuración.
* Realiza pruebas simulando envíos incorrectos desde herramientas como Postman para garantizar la cobertura de escenarios.

 </p>