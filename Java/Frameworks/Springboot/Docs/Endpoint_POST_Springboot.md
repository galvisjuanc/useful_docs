<h2 align="left"> Crear endpoint POST para guardar películas en Spring Boot </h2>

<h3 align="left"> ¿Cómo funciona el método POST en una API para guardar recursos? </h3>

<p align="left"> El método POST permite recibir información y agregar nuevos recursos en la base de datos. Todo comienza dentro del controlador (MovieController), donde se define un método que: - Responde con un ResponseEntity<MovieDTO>. - Recibe como parámetro un objeto MovieDTO con la anotación @RequestBody para indicar que los datos llegan en el cuerpo de la petición. - Se anota con @PostMapping para asociar la ruta y el verbo HTTP.

Esto habilita la ruta /movies para guardar películas nuevas usando solicitudes POST con datos en formato JSON. </p>

<h3 align="left"> ¿Qué pasos hay que seguir para transformar y guardar los datos recibidos? </h3>

<p align="left"> Para persistir la información recibida es fundamental preparar todos los componentes: 

- El repositorio (CrudMovieEntity) ofrece un método save que requiere una entidad (MovieEntity), no un DTO. 
- Por ello, es necesario crear en el mapper (MovieMapper) una función toEntity, usando @InheritInverseConfiguration de MapStruct, que convierte un MovieDTO en una entidad lista para guardar. 
- El campo especial genre necesita un mapeo adicional usando qualifiedByName, ajustando de stringToGenre a genreToString según el sentido de la conversión. 
- Para asignar el estado por defecto al guardar, se establece manualmente como 'Disponible'. El campo ID no se debe definir, ya que la base de datos lo genera automáticamente.

Después de guardar la entidad, el resultado se transforma nuevamente a DTO para devolverlo al cliente. </p>