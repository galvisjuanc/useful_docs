<h2 align="left"> Códigos HTTP y Response Entity en APIs REST </h2>

<h3 align="left"> ¿Qué son los códigos HTTP y por qué son importantes? </h3>

<p align="left"> Los códigos HTTP son valores numéricos estándar que indican el resultado de una petición entre un cliente y un servidor.

* El 200 muestra que la solicitud fue exitosa.
* El 201 indica que se creó un recurso nuevo.
* El 400 señala una petición incorrecta.
* El 404 se refiere a recursos no encontrados.
* El 500 marca errores internos del servidor. 

Utilizar estos códigos correctamente guía a quienes consumen tu API sobre lo que realmente ocurrió con cada solicitud. Así, tu backend envía respuestas precisas y profesionales.

</p>

<h3 align="left"> ¿Cómo personalizar las respuestas de una API con Response Entity? </h3>

<p align="left"> Al emplear la clase Response Entity, se gana control total sobre el contenido y código de cada respuesta. Por ejemplo, al buscar una película por ID:

* Si el recurso existe, se devuelve con un 200 y el JSON correspondiente.
* Si el recurso no está, lo adecuado es responder con un 404.

</p>

<h3 align="left"> Pasos clave en la implementación </h3>

<p align="left"> 

1. Cambia el tipo de retorno a ResponseEntity<MovieDTO> en el controlador.
2. Busca la entidad por su ID y almacénala en una variable.
3. Si el resultado es nulo, devuelve ResponseEntity.notFound().build().
4. Si existe, usa ResponseEntity.ok(movieDTO).

Este patrón permite respuestas claras, acordes a la lógica de negocio, y mejora la experiencia para quienes interactúan con tu API.

</p>