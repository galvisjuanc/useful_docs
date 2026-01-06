<h2 align="left"> Crear endpoint POST para guardar películas en Spring Boot </h2>

<h3 align="left"> ¿Cómo funciona el método POST en una API para guardar recursos? </h3>

<p align="left"> El método POST permite recibir información y agregar nuevos recursos en la base de datos. Todo comienza dentro del controlador (MovieController), donde se define un método que: - Responde con un ResponseEntity<MovieDTO>. - Recibe como parámetro un objeto MovieDTO con la anotación @RequestBody para indicar que los datos llegan en el cuerpo de la petición. - Se anota con @PostMapping para asociar la ruta y el verbo HTTP.

Esto habilita la ruta /movies para guardar películas nuevas usando solicitudes POST con datos en formato JSON. </p>