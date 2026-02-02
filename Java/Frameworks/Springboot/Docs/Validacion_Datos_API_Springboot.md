<h2 align="left"> Validación automática de datos en APIs con Spring Boot </h2>

<h3 align="left"> ¿Por qué validar los datos de entrada en APIs es fundamental? </h3>

<p align="left">Validar los datos desde el inicio evita que información errónea llegue al núcleo de la lógica de la aplicación. Así, tu API responde de manera constructiva ante intentos de enviar datos incompletos o inconsistentes.

* Mejora la experiencia del usuario final al recibir mensajes claros.
* Previene fallos antes de que afecten procesos lógicos internos.
* Facilita el mantenimiento y robustez del código. </p>

<h3 align="left"> ¿Cómo agregar una capa de validación en Spring Boot usando anotaciones? </h3>

<p align="left"> Se recomienda agregar la dependencia "Validation" en tu proyecto mediante Spring Initializer (start.spring.io). Para ello, busca bean validation with Hibernate Validator o agrega 'Spring Boot Starter Validation' en tu archivo build.gradle y actualiza las dependencias.

Luego, utiliza las anotaciones en el DTO que representa el cuerpo de la petición: </p>